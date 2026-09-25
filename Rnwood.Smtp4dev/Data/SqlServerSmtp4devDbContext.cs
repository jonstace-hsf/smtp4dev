using Microsoft.EntityFrameworkCore;
using Rnwood.Smtp4dev.DbModel;

namespace Rnwood.Smtp4dev.Data
{
    /// <summary>
    /// SQL Server-specific derived DbContext. SQL Server migrations are tagged to this type
    /// so that they are only discovered when running against SQL Server.
    /// </summary>
    public class SqlServerSmtp4devDbContext : Smtp4devDbContext
    {
        public SqlServerSmtp4devDbContext(DbContextOptions<SqlServerSmtp4devDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // SQL Server rejects multiple cascade paths. Messages are cascade-deleted via the
            // Mailbox -> MailboxFolder -> Message path, so the legacy direct Mailbox -> Message
            // relationship must not also cascade.
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Mailbox)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Rnwood.Smtp4dev.Data
{
    /// <summary>
    /// Design-time factory for the SQL Server-flavoured DbContext. Used by EF Core tools
    /// (e.g. <c>dotnet ef migrations add</c>) when targeting the SQL Server provider.
    /// Set the <c>SMTP4DEV_SQLSERVER_CONNECTION</c> environment variable to override the
    /// default localdb connection string.
    /// </summary>
    public class SqlServerSmtp4devDbContextFactory : IDesignTimeDbContextFactory<SqlServerSmtp4devDbContext>
    {
        public SqlServerSmtp4devDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqlServerSmtp4devDbContext>();
            var connectionString = Environment.GetEnvironmentVariable("SMTP4DEV_SQLSERVER_CONNECTION")
                ?? "Server=(localdb)\\MSSQLLocalDB;Database=smtp4dev;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            return new SqlServerSmtp4devDbContext(optionsBuilder.Options);
        }
    }
}

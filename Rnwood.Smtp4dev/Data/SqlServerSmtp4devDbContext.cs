using Microsoft.EntityFrameworkCore;

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
    }
}

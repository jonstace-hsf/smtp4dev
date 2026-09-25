using Microsoft.EntityFrameworkCore;

namespace Rnwood.Smtp4dev.Data
{
    /// <summary>
    /// SQLite-specific derived DbContext. Existing migrations are tagged to this type so that
    /// they are only discovered when running against SQLite.
    /// </summary>
    public class SqliteSmtp4devDbContext : Smtp4devDbContext
    {
        public SqliteSmtp4devDbContext(DbContextOptions<SqliteSmtp4devDbContext> options)
            : base(options)
        {
        }
    }
}

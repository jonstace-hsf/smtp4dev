using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Rnwood.Smtp4dev.Data
{
    /// <summary>
    /// Design-time factory for the SQLite-flavoured DbContext. Used by EF Core tools
    /// (e.g. <c>dotnet ef migrations add</c>) when targeting the SQLite provider.
    /// </summary>
    public class SqliteSmtp4devDbContextFactory : IDesignTimeDbContextFactory<SqliteSmtp4devDbContext>
    {
        public SqliteSmtp4devDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqliteSmtp4devDbContext>();
            var connectionString = Environment.GetEnvironmentVariable("SMTP4DEV_SQLITE_CONNECTION")
                ?? "Data Source=smtp4dev.db";
            optionsBuilder.UseSqlite(connectionString);
            return new SqliteSmtp4devDbContext(optionsBuilder.Options);
        }
    }
}


namespace Rnwood.Smtp4dev.Data
{
    /// <summary>
    /// Supported Entity Framework Core database providers for smtp4dev.
    /// </summary>
    public enum DatabaseProvider
    {
        /// <summary>
        /// SQLite (default). The Database option is a file path; if empty, an in-memory shared-cache database is used.
        /// </summary>
        Sqlite,

        /// <summary>
        /// Microsoft SQL Server. The Database option is a full ADO.NET connection string.
        /// </summary>
        SqlServer
    }
}

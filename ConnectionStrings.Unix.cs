namespace System.Data.Odbc.Tests
{
    public static class ConnectionStringsUnix
    {
        // requires unixodbc and sqliteodbc
        public const string WorkingConnection =
            "Driver=SQLite3;" +
            "Database=smoketests.sqlite;";
    }
}

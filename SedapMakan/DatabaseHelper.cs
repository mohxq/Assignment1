using System.Data.SqlClient;

namespace SedapMakan
{
    public static class DatabaseHelper
    {
        private const string ConnectionString = "Server=localhost;Database=SedapMakanDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}

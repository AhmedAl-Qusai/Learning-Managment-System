using System.Configuration;
using System.Data.SqlClient;

namespace UniTaskSystem.Data
{
    public static class Db
    {
        public static SqlConnection GetConnection()
        {
            var cs = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            return new SqlConnection(cs);
        }
    }
}

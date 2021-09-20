using System.Data.SqlClient;
using System.Web.Configuration;

namespace LogInInfoDetails.Gateway
{
    public class CommonGateway
    {
        public int Id { get; set; }
        public SqlCommand Command { get; set; }
        public SqlConnection Connection { get; set; }
        public SqlDataReader Reader { get; set; }
        public int RowAffected { get; set; }
        private string connectionString = WebConfigurationManager.ConnectionStrings["LogInDB"].ConnectionString;

        public CommonGateway()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}
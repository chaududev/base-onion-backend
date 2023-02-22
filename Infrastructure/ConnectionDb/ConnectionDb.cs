using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConnectionDb
{
    public class ConnectionDb : IConnectDb
    {
        protected readonly IConfiguration Configuration;
        public ConnectionDb(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public SqlConnection GetConnection()
        {
            SqlConnection conn;
            try
            {
            conn = new SqlConnection("Server=DESKTOP-FF1278R;Database=MvcDemo;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False");
                return conn;
            }
            catch (Exception)
            {

                return null;
            }
           
        }
    }
}

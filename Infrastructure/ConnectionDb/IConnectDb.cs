using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ConnectionDb
{
    public interface IConnectDb
    {
       public SqlConnection GetConnection();
    }
}

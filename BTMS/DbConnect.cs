using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS
{
    public class DBConnect
    {
        public static SqlConnection Connect()
        {
            return new SqlConnection(@"Data Source = HOME; Initial Catalog = CBC; Integrated Security = True"); //change this only if required
        }
    }
}

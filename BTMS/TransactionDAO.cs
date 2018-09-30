using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTMS
{
    class TransactionDAO
    {
        SqlConnection con = DBConnect.Connect();

        public void logTransaction(Transactions obj)
        {
            try
            {
                string sql = "insert into [Transactions] ([Account],[Amount],[Description],[Date],[Teller]) values ('" + obj.Account + "','" +obj.Amount + "','" + obj.Description + "','" + obj.Date + "','" + obj.Teller + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex){ MessageBox.Show(ex.ToString());}
            finally { con.Close(); };
        }

    }
}

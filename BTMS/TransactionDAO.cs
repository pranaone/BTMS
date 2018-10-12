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
                string sql1 = "insert into [Transactions] ([Account],[Amount],[Description],[Date],[Teller]) values ('" + obj.Account + "','" + obj.Amount + "','" + obj.Description + "','" + obj.Date + "','" + obj.Teller + "')";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                con.Open();
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { con.Close(); };

        }

    }
}

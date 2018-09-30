using CrystalDecisions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTMS
{
    public partial class MandateViewer : Form
    {
        public MandateViewer()
        {
            InitializeComponent();
        }

        private void MandateViewer_Load(object sender, EventArgs e)
        {
            try
            {
                int num = Session.Account;
                SqlConnection con = DBConnect.Connect();
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select * from customerAccount where Number = '" + num + "'", con);
                sda.Fill(ds);
                con.Close();

                Mandate obj = new Mandate();
                obj.Database.Tables["customerAccount"].SetDataSource(ds.Tables[0]);
                crvViewer.ReportSource = obj;
            }
            catch (Exception) { MessageBox.Show("Error Occured!!"); }

        }
    }
}

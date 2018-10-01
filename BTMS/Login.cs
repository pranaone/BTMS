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
    public partial class Login : Form
    {
        SqlConnection con = DBConnect.Connect();
        string user;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Session.Username = txtUsername.Text;
            con.Open();
            string password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand("select * from Employee where Username='" + txtUsername.Text + "' and Password ='" + password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                user = dt.Rows[0][2].ToString().Trim();
                if (user == "Admin")
                {
                    Session.UserType = "Admin";
                    this.Hide();
                    new MainWindow().Show(); 
                }
                else if (user == "Teller")
                {
                    Session.UserType = "Teller";
                    this.Hide();
                    new MainWindow().Show();
                }
                else { MessageBox.Show("Undefined User!!"); }
            }
            else { MessageBox.Show("Invalid Username or Password!!"); }

            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // completely stops the thread after exiting the application
            // prevents application running in the background even after exiting 
        }
    }
}

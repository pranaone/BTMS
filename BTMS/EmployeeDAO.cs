using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTMS
{
    class EmployeeDAO
    {
        public bool passCheck;
        public Employee emp;
        SqlConnection con = DBConnect.Connect();

        public void createUser(Employee obj) // add employee function
        {
            try
            {
                string sql = "insert into Employee (EID,Name,Designation,Email,Username,Password) values ('" + obj.EmpID + "','" + obj.Name + "','" + obj.Designation + "','" + obj.Email + "','" + obj.Username + "','" + obj.Password + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added!!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            { MessageBox.Show("User Already Exist!!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { con.Close(); };
        }

        public void deleteUser(string eid) // delete employee function
        {
            try
            {
                string sql = "delete from Employee where EID = '" + eid + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted!!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { con.Close(); };
        }

        public void updateUser(Employee obj) // update employee function
        {
            try
            {
                string sql = "update Employee set Name ='" + obj.Name + "', Designation ='" + obj.Designation + "', Email ='" + obj.Email + "', Username ='" + obj.Username + "', Password ='" + obj.Password + "' where EID='" + obj.EmpID + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated!!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { con.Close(); };
        }

        public Employee searchUser(string eid) // search employee function
        {
            try
            {
                string sql = "select * from [Employee] where Username = '" + eid + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    string EID = dreader[0].ToString();
                    string Name = dreader[1].ToString();
                    string Designation = dreader[2].ToString();
                    string Email = dreader[3].ToString();
                    string Username = dreader[4].ToString();
                    string Password = dreader[5].ToString();

                    emp = new Employee(EID, Name, Designation, Email, Username, Password);
                }
                dreader.Close();
            }
            catch (Exception) { MessageBox.Show("User not Found!!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { con.Close(); }
            return emp;
        }

        public bool validatePassword(string eid, string pass) 
        {
            try
            {
                string sql = "select * from [Employee] where Username = '" + eid + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    string Password = dreader[5].ToString();
                    if (Password == pass)
                    {
                        passCheck = true;
                    }
                }
                dreader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { con.Close(); }
            return passCheck;
        }

        public void changePassword(string eid, string pass)
        {
            try
            {
                string sql = "update Employee set Password ='" + pass + "' where EID ='" +eid+ "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Successfully Changed!!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { con.Close(); };
        }

    }
}

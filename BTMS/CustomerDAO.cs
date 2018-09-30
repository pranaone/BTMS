using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTMS
{
    class CustomerDAO
    {
        public Customer cust;
        SqlConnection con = DBConnect.Connect();

        public void createCustomer(Customer obj) // create customer function
        {
            try
            {
                string sql = "insert into Customer (NIC,Name,Address,Contact,Email,DOB,Occupation,Photo,Signature)" +
                "values (@nic,@name,@address,@contact,@email,@dob,@occupation,@photo,@signature)";
                SqlCommand cmd = new SqlCommand(sql, con);
                //specifying database type for each parameter to avoid string casting error that prevented images from showing up
                cmd.Parameters.Add("@nic", SqlDbType.VarChar).Value = obj.NIC;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.Address;
                cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = obj.Contact;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = obj.DOB;
                cmd.Parameters.Add("@occupation", SqlDbType.VarChar).Value = obj.Occupation;
                cmd.Parameters.Add("@photo", SqlDbType.Image).Value = obj.Photo; 
                cmd.Parameters.Add("@signature", SqlDbType.Image).Value = obj.Signature;
                con.Open();
                cmd.ExecuteScalar();
                MessageBox.Show("Customer Successfully Added");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally { con.Close(); };
        }
        public void deleteCustomer(string cid) // delete customer function
        {
            try
            {
                string sql = "delete from Customer where CID = '" + cid + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { con.Close(); };
        }
        public void updateCustomer(Customer obj) // update customer function
        {
            try
            {
                string sql = "update Customer set NIC = @nic, Name = @name, Address = @address, Email = @email, DOB = @dob, Occupation = @occupation, Photo = @photo, Signature = @signature where CID = @cid";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@cid", SqlDbType.Int).Value = obj.CID;
                cmd.Parameters.Add("@nic", SqlDbType.VarChar).Value = obj.NIC;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.Address;
                cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = obj.Contact;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = obj.DOB;
                cmd.Parameters.Add("@occupation", SqlDbType.VarChar).Value = obj.Occupation;
                cmd.Parameters.Add("@photo", SqlDbType.Image).Value = obj.Photo;
                cmd.Parameters.Add("@signature", SqlDbType.Image).Value = obj.Signature;
                con.Open();
                cmd.ExecuteScalar();
                MessageBox.Show("Customer Successfully Updated");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { con.Close(); };
        }
        public Customer searchCustomer(string nic) // search customer function
        {
            try
            {
                string sql = "select * from [Customer] where NIC = '" + nic + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    int CID = Convert.ToInt16(dreader[0]);
                    string NIC = dreader[1].ToString();
                    string Name = dreader[2].ToString();
                    string Address = dreader[3].ToString();
                    string Contact = dreader[4].ToString();
                    string Email = dreader[5].ToString();
                    string Occupation = dreader[7].ToString();
                    DateTime DOB = Convert.ToDateTime(dreader[6]);
                    var Photo = (byte[])dreader[8]; 
                    var Signature = (byte[])dreader[9];

                    cust = new Customer(CID, NIC, Name, Address, Contact, Email, Occupation, DOB, Photo, Signature);
                }
                dreader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { con.Close(); }
            return cust;
        }
    }
}

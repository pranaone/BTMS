using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTMS
{
    class AccountDAO
    {
        int bal;
        bool close, found;
        string name;
        SqlConnection con = DBConnect.Connect();

        public void openAccount(Account obj)
        {
            try
            {
                int openBal = 0;
                string sql = "insert into Account ([Customer Name],Balance,CID,[Date Opened],Status) values ('" + obj.CustomerName + "','" + openBal + "','" + obj.CustomerID + "','" + obj.DateOpened + "','" + obj.Status + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Successfully Opened!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            { MessageBox.Show("Unable to Open Account!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { con.Close(); };
        }

        public void closeAccount(int account)
        {
            var bal = checkBalance(account);
            if (isClose(account) != true)
            {
                if (bal <= 1000)
                {
                    try
                    {
                        int closeOutBal = 0;
                        string sql = "update Account set Status = 'Close', Balance = '" + closeOutBal + "' where Number ='" + account + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account Successfully Closed!!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    { MessageBox.Show("Unable to Close Account!!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    finally { con.Close(); };
                }
                else { MessageBox.Show("Account has a balance amount above the minimum!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Account is Already Closed!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        public int checkBalance(int account)
        {
            try
            {
                string sql = "select * from Account where Number = '" + account + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                { bal = Convert.ToInt32(dreader[2]); }
                dreader.Close();
            }
            catch (Exception) { MessageBox.Show("Unable to Check Balance!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { con.Close(); }
            return bal;
        }

        public string getAccountName(int account)
        {
            try
            {
                string sql = "select * from Account where Number = '" + account + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                { name = dreader[1].ToString(); }
                dreader.Close();
            }
            catch (Exception) { MessageBox.Show("Unable to Retrieve Account Name!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { con.Close(); }
            return name;

        }

        public bool checkAccount(int account)
        {
            try
            {
                string sql = "select * from Account where Number = '" + account + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    var acc = Convert.ToInt32(dreader[0]);
                    if (acc == account)
                    {
                        found = true;
                    }
                    else { found = false; }
                }
                dreader.Close();
            }
            catch (Exception) { MessageBox.Show("Unable to Find Account!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { con.Close(); }
            return found;
        }


        public bool isClose(int account)
        {
            try
            {
                string sql = "select * from Account where Number = '" + account + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    var status = dreader[5].ToString();
                    if (status == "Close")
                    {
                        close = true;
                    }
                }
                else { close = false; }
                dreader.Close();
            }
            catch (Exception) { MessageBox.Show("Unable to Check Status of Account!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { con.Close(); }
            return close;
        }
        public void updateAccBalDep(int account, int currentBal, int depositAmt)
        {
            if (checkAccount(account) == true)
            {
                if (isClose(account) == false)
                {
                    int newBal = currentBal + depositAmt;
                    try
                    {
                        string sql = "update Account set Balance ='" + newBal + "' where Number = '" + account + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deposit Successfull!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    { MessageBox.Show("Deposit Failed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    finally { con.Close(); };
                }
                else { MessageBox.Show("Account is Closed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Invalid Account Number!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        public void updateAccBalWd(int account, int currentBal, int withdrawalAmt)
        {
            if (checkAccount(account) == true)
            {
                if (isClose(account) == false)
                {
                    int newBal = currentBal - withdrawalAmt;
                    if (newBal >= 0)
                    {
                        try
                        {
                            string sql = "update Account set Balance ='" + newBal + "' where Number = '" + account + "'";
                            SqlCommand cmd = new SqlCommand(sql, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Withdrawal Successfull!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        { MessageBox.Show("Withdrawal Failed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        finally { con.Close(); };
                    }
                    else { MessageBox.Show("Withdrawal Amount Exceeds Available Account Balance!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else { MessageBox.Show("Account is Closed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Invalid Account Number!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }
        public void fundsTransfer(int frmAccount, int frmCurBal, int trfAmt, int toAccount, int toCurBal)
        {
            if (checkAccount(toAccount) == true)
            {
                if (isClose(toAccount) == false)
                {

                    if (checkAccount(frmAccount) == true)
                    {
                        if (isClose(frmAccount) == false)
                        {
                            int newFrmBal = frmCurBal - trfAmt;
                            if (newFrmBal >= 0)
                            {
                                try
                                {
                                    string sql = "update Account set Balance ='" + newFrmBal + "' where Number = '" + frmAccount + "'";
                                    SqlCommand cmd = new SqlCommand(sql, con);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception)
                                { MessageBox.Show("Transfer Failed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                                finally { con.Close(); };

                                int newToBal = toCurBal + trfAmt;
                                try
                                {
                                    string sql = "update Account set Balance ='" + newToBal + "' where Number = '" + toAccount + "'";
                                    SqlCommand cmd = new SqlCommand(sql, con);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Funds Transfer Successfull!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception)
                                { MessageBox.Show("Transfer Failed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                                finally { con.Close(); };

                            }
                            else { MessageBox.Show("Transfer Amount Exceeds Available Account Balance!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                        }
                        else { MessageBox.Show("Unable to Transfer - From Account is Closed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("Unable to Transfer - Invalid From Account Number!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Unable to Transfer - To Account is Closed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Unable to Transfer - Invalid To Account Number!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
            
    }
}

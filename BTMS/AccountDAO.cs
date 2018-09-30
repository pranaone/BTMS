﻿using System;
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
        bool close;
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
                MessageBox.Show("Account Successfully Opened!!");
            }
            catch (Exception)
            { MessageBox.Show("Error Occured - Unable to Open Account!!"); }
            finally { con.Close(); };
        }

        public void closeAccount(int account)
        {
            var bal = checkBalance(account);
            if (isClose(account) == true)
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
                        MessageBox.Show("Account Successfully Closed!!");
                    }
                    catch (Exception)
                    { MessageBox.Show("Error Occured - Unable to Close Account!!"); }
                    finally { con.Close(); };
                }
                else { MessageBox.Show("Account has a balance amount above the minimum!!"); }
            }
            else { MessageBox.Show("Account is Already Closed!!"); }

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
            catch (Exception) { MessageBox.Show("Error Occured - Unable to Check Balance!!"); }
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
            catch (Exception) { MessageBox.Show("Error Occured - Unable to Check Account Name!!"); }
            finally { con.Close(); }
            return name;

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
            catch (Exception) { MessageBox.Show("Error Occured - Unable to Check Status of Account!!"); }
            finally { con.Close(); }
            return close;
        }
        public void updateAccBalDep(int account, int currentBal, int depositAmt)
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
                    MessageBox.Show("Deposit Successfull!!");
                }
                catch (Exception)
                { MessageBox.Show("Error Occured - Deposit Failed!!"); }
                finally { con.Close(); };
            }
            else { MessageBox.Show("Unable to Deposit - Account is Closed!!"); }

        }

        public void updateAccBalWd(int account, int currentBal, int withdrawalAmt)
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
                        MessageBox.Show("Withdrawal Successfull!!");
                    }
                    catch (Exception)
                    { MessageBox.Show("Error Occured - Withdrawal Failed!!"); }
                    finally { con.Close(); };


                }
                else { MessageBox.Show("Withdrawal Amount Exceeds Available Account Balance!!"); }
            }
            else { MessageBox.Show("Unable to Withdraw - Account is Closed!!"); }


        }
        public void fundsTransfer(int frmAccount, int frmCurBal, int trfAmt, int toAccount, int toCurBal)
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
                    { MessageBox.Show("Error Occured - Transfer Failed!!"); }
                    finally { con.Close(); };

                    if (isClose(toAccount) == false)
                    {
                        int newToBal = toCurBal + trfAmt;
                        try
                        {
                            string sql = "update Account set Balance ='" + newToBal + "' where Number = '" + toAccount + "'";
                            SqlCommand cmd = new SqlCommand(sql, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Funds Transfer Successfull!!");
                        }
                        catch (Exception)
                        { MessageBox.Show("Error Occured - Transfer Failed!!"); }
                        finally { con.Close(); };
                    }
                    else { MessageBox.Show("Unable to Transfer - To Account is Closed!!"); }
                }
                else { MessageBox.Show("Transfer Amount Exceeds Available Account Balance!!"); }
            }
            else { MessageBox.Show("Unable to Transfer - From Account is Closed!!"); }

        }
    }
}

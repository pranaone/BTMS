using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTMS
{
    public partial class MainWindow : Form
    {
        SqlConnection con = DBConnect.Connect();
        TransactionDAO tDAO = new TransactionDAO();
        string accountSelect;

    public MainWindow()
        {
            InitializeComponent();
            txtUser.Text = Session.Username;
            if (Session.Usertype == "Admin")
            {
                Tabs.TabPages.Remove(ManageCustomer);
                Tabs.TabPages.Remove(ManageAccount);
                Tabs.TabPages.Remove(Deposit);
                Tabs.TabPages.Remove(Withdrawal);
                Tabs.TabPages.Remove(FundTransfer);
                Tabs.TabPages.Remove(TransactionHistory);
            }
            else
            {
                Tabs.TabPages.Remove(ManageUser);
            }
       
        }
        private void userProfile()
        {
            EmployeeDAO objUP = new EmployeeDAO();
            objUP.searchUser(txtUser.Text);
            txtUserEmpName.Text = objUP.emp.Name;
            txtUserEmpEmail.Text = objUP.emp.Email;
        }
        private void clearUser()
        {
            txtEmpID.Clear();
            txtEmpName.Clear();
            txtEmpEmail.Clear();
            txtEmpUsername.Clear();
            txtEmpPassword.Clear();
            cbxUserType.ResetText();
        }
        private void clearCustomer()
        {
            txtID.Clear();
            txtFullName.Clear();
            txtCustomerID.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtOccupation.Clear();
            pbxPhotograph.Image = null;
            pbxSignature.Image = null;
            txtDOB.Value = DateTime.Now;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDAO eDAOx = new EmployeeDAO();
                eDAOx.searchUser(txtEmpID.Text);
                txtEmpName.Text = eDAOx.emp.Name;
                cbxUserType.Text = eDAOx.emp.Designation;
                txtEmpEmail.Text = eDAOx.emp.Email;
                txtEmpUsername.Text = eDAOx.emp.Username;
                txtEmpPassword.Text = eDAOx.emp.Password;
            }
            catch (Exception)
            {
                MessageBox.Show("User Not Found!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearUser();
            }

        }

        private void btnCreateEmp_Click(object sender, EventArgs e)
        {
            try
            {
                Employee obj = new Employee(txtEmpID.Text, txtEmpName.Text, cbxUserType.Text,
                txtEmpEmail.Text, txtEmpUsername.Text, txtEmpPassword.Text);
                EmployeeDAO objCE = new EmployeeDAO();
                objCE.createUser(obj);
                clearUser();
            }
            catch (Exception) { MessageBox.Show("Please enter employee details!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            try
            {
                Employee obj = new Employee(txtEmpID.Text, txtEmpName.Text, cbxUserType.Text,
                txtEmpEmail.Text, txtEmpUsername.Text, txtEmpPassword.Text);
                EmployeeDAO objUE = new EmployeeDAO();
                objUE.updateUser(obj);
                clearUser();
            }
            catch(Exception) { MessageBox.Show("Nothing to Update!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDAO objDE = new EmployeeDAO();
                objDE.deleteUser(txtEmpID.Text);
                clearUser();
            }
            catch(Exception) { MessageBox.Show("Nothing to delete!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            txtEmpUsername.Text = txtEmpID.Text;
        }

        private void btnEmpClear_Click(object sender, EventArgs e)
        {
            clearUser();
        }

        private Image byteArrayToImage(byte[] byteArrayIn) // converts byte array from database to image
        {
            ImageConverter converter = new ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDAO cDAOx = new CustomerDAO();
                cDAOx.searchCustomer(txtID.Text);
                txtFullName.Text = cDAOx.cust.Name;
                txtCustomerID.Text = cDAOx.cust.CID.ToString();
                txtAddress.Text = cDAOx.cust.Address;
                txtContact.Text = cDAOx.cust.Contact;
                txtEmail.Text = cDAOx.cust.Email;
                txtOccupation.Text = cDAOx.cust.Occupation;
                txtDOB.Value = cDAOx.cust.DOB;
                pbxPhotograph.Image = byteArrayToImage(cDAOx.cust.Photo);
                pbxSignature.Image = byteArrayToImage(cDAOx.cust.Signature);
            }
            catch (Exception)
            {
                MessageBox.Show("No Customer Record Found!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearCustomer();
            }
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            
            try
            {
                CustomerDAO objx = new CustomerDAO();
                objx.getCustomerNIC(txtID.Text);
                string custID = objx.customerNIC;
                if (txtID.Text != custID)
                {
                    MemoryStream ms1 = new MemoryStream();
                    pbxPhotograph.Image.Save(ms1, ImageFormat.Jpeg);
                    var Photo = ms1.ToArray();
                    //converting images in picturebox to bytes array to be stored in DB 

                    MemoryStream ms2 = new MemoryStream();
                    pbxSignature.Image.Save(ms2, ImageFormat.Jpeg);
                    var Signature = ms2.ToArray();

                    Customer obj = new Customer(txtID.Text, txtFullName.Text, txtAddress.Text, txtContact.Text, txtEmail.Text, txtOccupation.Text, txtDOB.Value, Photo, Signature);
                    CustomerDAO objCC = new CustomerDAO();
                    objCC.createCustomer(obj);
                    clearCustomer();
                }
                else { MessageBox.Show("Customer Record Already Exists!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                
            }
            catch (Exception) { MessageBox.Show("Please Upload Customer Photograph/Signature!!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms1 = new MemoryStream();
                pbxPhotograph.Image.Save(ms1, ImageFormat.Jpeg);
                var Photo = ms1.ToArray();

                MemoryStream ms2 = new MemoryStream();
                pbxSignature.Image.Save(ms2, ImageFormat.Jpeg);
                var Signature = ms2.ToArray();

                var CID = Convert.ToInt32(txtCustomerID.Text);

                Customer obj = new Customer(CID, txtID.Text, txtFullName.Text, txtAddress.Text, txtContact.Text, txtEmail.Text, txtOccupation.Text, txtDOB.Value, Photo, Signature);
                CustomerDAO objUC = new CustomerDAO();
                objUC.updateCustomer(obj);
                clearCustomer();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDAO objDC = new CustomerDAO();
                objDC.deleteCustomer(txtCustomerID.Text);
                clearCustomer();
            }
            catch(Exception) { MessageBox.Show("Nothing to Delete!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            

        }

        private void pbxPhotograph_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog obj = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    string imageName = obj.FileName;
                    pbxPhotograph.Image = Image.FromFile(imageName);
                }
            }
        }

        private void pbxSignature_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog obj = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    string imageName = obj.FileName;
                    pbxSignature.Image = Image.FromFile(imageName);
                }
            }
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            clearCustomer();
        }

        private void UserProfile_Enter(object sender, EventArgs e)
        {
            userProfile();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            EmployeeDAO objCP = new EmployeeDAO();
            objCP.validatePassword(txtUser.Text, txtCurrentPassword.Text);
            if (objCP.passCheck == true)
            {
                objCP.changePassword(txtUser.Text,txtNewPassword.Text);
                txtNewPassword.Clear();
                txtCurrentPassword.Clear();
            }
            else
            {
                MessageBox.Show("Entered Current Password Is Incorrect!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Clear();
                txtCurrentPassword.Clear();
            }
        }

        private void btnAccSearch_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDAO cDAOx = new CustomerDAO();
                cDAOx.searchCustomer(txtAccID.Text);
                txtAccCustID.Text = cDAOx.cust.CID.ToString();
                txtAccCustName.Text = cDAOx.cust.Name;
                var CID = cDAOx.cust.CID.ToString();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Account where CID = '" + CID + "'", con);
                sda.Fill(dt);
                dgvAccount.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("No Customer Found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAccID.Clear();
            }
    
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Account obj = new Account(txtAccCustName.Text, Convert.ToInt16(txtAccCustID.Text), DateTime.Now, "Open");
                AccountDAO objAO = new AccountDAO();
                objAO.openAccount(obj);
            }
            catch (Exception) { MessageBox.Show("Please Search Customer!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }          
        }

        private void btnAccClear_Click(object sender, EventArgs e)
        {
            txtAccID.Clear();
            txtAccCustName.Clear();
            txtAccCustID.Clear();
            dgvAccount.DataSource = null;
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (accountSelect != null)
                {
                    AccountDAO objAC = new AccountDAO();
                    objAC.closeAccount(Convert.ToInt32(accountSelect));
                }
                else { MessageBox.Show("Please choose the account to be closed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception) { MessageBox.Show("System Error!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvAccount.Rows[index];

           accountSelect = selectedRow.Cells[0].Value.ToString();
        }

        private void txtDepAccNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AccountDAO obj = new AccountDAO();
                txtDepAccBalance.Text = obj.checkBalance(Convert.ToInt32(txtDepAccNumber.Text)).ToString();
                txtDepAccName.Text = obj.getAccountName(Convert.ToInt32(txtDepAccNumber.Text));
            }
            catch (Exception) { }
         
        }

        private void clearDeposit()
        {
            txtDepAccNumber.Clear();
            txtDepAccName.Clear();
            txtDepAmount.Clear();
            txtDepAccBalance.Clear();
        }

        private void BtnDepCancel_Click(object sender, EventArgs e)
        {
            clearDeposit();
            
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                var account = Convert.ToInt32(txtDepAccNumber.Text);
                var currentBal = Convert.ToInt32(txtDepAccBalance.Text);
                var depAmt = Convert.ToInt32(txtDepAmount.Text);
                AccountDAO objDp = new AccountDAO();
                objDp.deposit(account, currentBal, depAmt);

                Transactions objx = new Transactions(account, depAmt, txtDepDescription.Text, DateTime.Now, txtUser.Text);
                tDAO.logTransaction(objx);

                clearDeposit();
            }
            catch (Exception) { MessageBox.Show("Please complete all fields!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void clearWithdrawal()
        {
            txtWithAccNumber.Clear();
            txtWithAccBalance.Clear();
            txtWithAccName.Clear();
            txtWithAmount.Clear();
        }

        private void btnWithdrawCancel_Click(object sender, EventArgs e)
        {
            clearWithdrawal();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                var account = Convert.ToInt32(txtWithAccNumber.Text);
                var currentBal = Convert.ToInt32(txtWithAccBalance.Text);
                var WithdrawalAmt = Convert.ToInt32(txtWithAmount.Text);
                AccountDAO objWd = new AccountDAO();
                objWd.withdrawal(account, currentBal, WithdrawalAmt);

                Transactions objx = new Transactions(account, WithdrawalAmt, txtWithDescription.Text, DateTime.Now, txtUser.Text);
                tDAO.logTransaction(objx);

                clearWithdrawal();
            }
            catch (Exception) { MessageBox.Show("Please complete all fields!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }  
        }

        private void txtWithAccNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AccountDAO obj = new AccountDAO();
                txtWithAccBalance.Text = obj.checkBalance(Convert.ToInt32(txtWithAccNumber.Text)).ToString();
                txtWithAccName.Text = obj.getAccountName(Convert.ToInt32(txtWithAccNumber.Text));
            }
            catch (Exception) { /* to suppress invalid input string error */}
        }
        private void clearTransfer()
        {
            txtFdAmount.Clear();
            txtFdFrmAccBalance.Clear();
            txtFdFrmAccDescription.Clear();
            txtFdFrmAccName.Clear();
            txtFdFrmAccount.Clear();
            txtFdToAccDescription.Clear();
            txtFdToAccName.Clear();
            txtFdToAccount.Clear();
            txtFdToAccBalance.Clear();

        }

        private void btnFdTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                var frmAcc = Convert.ToInt32(txtFdFrmAccount.Text);
                var frmCurBal = Convert.ToInt32(txtFdFrmAccBalance.Text);
                var trfAmt = Convert.ToInt32(txtFdAmount.Text);
                var toAcc = Convert.ToInt32(txtFdToAccount.Text);
                var toCurBal = Convert.ToInt32(txtFdToAccBalance.Text);

                AccountDAO objFT = new AccountDAO();
                objFT.fundsTransfer(frmAcc, frmCurBal, trfAmt, toAcc, toCurBal);

                Transactions objx = new Transactions(frmAcc, trfAmt, txtFdFrmAccDescription.Text, DateTime.Now, txtUser.Text);
                tDAO.logTransaction(objx);

                clearTransfer();

            }
            catch(Exception) { MessageBox.Show("Please complete all fields!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnFdCancel_Click(object sender, EventArgs e)
        {
            clearTransfer();
        }

        private void txtFdFrmAccount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AccountDAO obj1 = new AccountDAO();
                txtFdFrmAccBalance.Text = obj1.checkBalance(Convert.ToInt32(txtFdFrmAccount.Text)).ToString();
                txtFdFrmAccName.Text = obj1.getAccountName(Convert.ToInt32(txtFdFrmAccount.Text));
            }
            catch (Exception) { /* to suppress invalid input string error */}
        }

        private void txtFdToAccount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AccountDAO obj2 = new AccountDAO();
                txtFdToAccBalance.Text = obj2.checkBalance(Convert.ToInt32(txtFdToAccount.Text)).ToString();
                txtFdToAccName.Text = obj2.getAccountName(Convert.ToInt32(txtFdToAccount.Text));
            }
            catch (Exception) { /* to suppress invalid input string error */}
        }

        private void btnPrintMandate_Click(object sender, EventArgs e)
        {
            try
            {
                if (accountSelect != null)
                {
                    Session.Account = Convert.ToInt32(accountSelect);
                    new MandateViewer().Show();
                }
                else { MessageBox.Show("Please choose the account to be printed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                
            }
            catch (Exception) { MessageBox.Show("System Error!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Transactions where Teller ='"+txtUser.Text+"'", con);
            sda.Fill(dt);
            dgvTransHistory.DataSource = dt;
            // displays all the transactions done by the logged in teller
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            // completely stops the thread after exiting the application
            // prevents application running in the background even after exiting 
        }
    }
}


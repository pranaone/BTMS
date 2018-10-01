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
        CustomerDAO cDAO = new CustomerDAO();
        EmployeeDAO eDAO = new EmployeeDAO();
        AccountDAO aDAO = new AccountDAO();
        TransactionDAO tDAO = new TransactionDAO();
       

    public MainWindow()
        {
            InitializeComponent();
            txtUser.Text = Session.Username;
            if (Session.UserType != "Admin")
            {Tabs.TabPages.Remove(ManageUser);}
       
        }
        private void userProfile()
        {
            eDAO.searchUser(txtUser.Text);
            txtUserEmpName.Text = eDAO.emp.Name;
            txtUserEmpEmail.Text = eDAO.emp.Email;
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
            new Login().Show();
            this.Close();
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
                MessageBox.Show("User Not Found!!");
                clearUser();
            }

        }

        private void btnCreateEmp_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee(txtEmpID.Text, txtEmpName.Text, cbxUserType.Text,
            txtEmpEmail.Text, txtEmpUsername.Text, txtEmpPassword.Text);
            eDAO.createUser(obj);
            clearUser();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee(txtEmpID.Text, txtEmpName.Text, cbxUserType.Text,
            txtEmpEmail.Text, txtEmpUsername.Text, txtEmpPassword.Text);
            eDAO.updateUser(obj);
            clearUser();
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            eDAO.deleteUser(txtEmpID.Text);
            clearUser();

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
                MessageBox.Show("No Customer Record Found!!");
                clearCustomer();
            }
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            //converting images in picturebox to bytes array to be stored in DB 
            try
            {
                MemoryStream ms1 = new MemoryStream();
                pbxPhotograph.Image.Save(ms1, ImageFormat.Jpeg);
                var Photo = ms1.ToArray();

                MemoryStream ms2 = new MemoryStream();
                pbxSignature.Image.Save(ms2, ImageFormat.Jpeg);
                var Signature = ms2.ToArray();

                cDAO.getCustomerNIC(txtID.Text);
                string custID = cDAO.customerNIC.ToString();
                if (custID != txtID.Text)
                {
                    Customer obj = new Customer(txtID.Text, txtFullName.Text, txtAddress.Text, txtContact.Text, txtEmail.Text, txtOccupation.Text, txtDOB.Value, Photo, Signature);
                    cDAO.createCustomer(obj);
                }
                else
                {
                    MessageBox.Show("Customer Record Already Exists!!");
                    clearCustomer();
                }
            }
                
           
            catch (Exception) { MessageBox.Show("Please Upload Customer Photograph/Signature!!");}
            
            clearCustomer();

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            MemoryStream ms1 = new MemoryStream();
            pbxPhotograph.Image.Save(ms1, ImageFormat.Jpeg);
            var Photo = ms1.ToArray();

            MemoryStream ms2 = new MemoryStream();
            pbxSignature.Image.Save(ms2, ImageFormat.Jpeg);
            var Signature = ms2.ToArray();

            var CID = Convert.ToInt16(txtCustomerID.Text);

            Customer obj = new Customer(CID, txtID.Text, txtFullName.Text, txtAddress.Text, txtContact.Text, txtEmail.Text, txtOccupation.Text, txtDOB.Value, Photo, Signature);
            cDAO.updateCustomer(obj);
            clearCustomer();

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            cDAO.deleteCustomer(txtCustomerID.Text);
            clearCustomer();

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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            

        }

        private void UserProfile_Enter(object sender, EventArgs e)
        {
            userProfile();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            eDAO.validatePassword(txtUser.Text, txtCurrentPassword.Text);
            if (eDAO.passCheck == true)
            {
                eDAO.changePassword(txtUser.Text,txtNewPassword.Text);
                txtNewPassword.Clear();
                txtCurrentPassword.Clear();
            }
            else
            {
                MessageBox.Show("Entered Current Password Is Incorrect!!");
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
                MessageBox.Show("No Customer Found!!");
                txtAccID.Clear();
            }
    
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            Account obj = new Account(txtAccCustName.Text, Convert.ToInt16(txtAccCustID.Text), DateTime.Now, "Open");
            aDAO.openAccount(obj);
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
            aDAO.closeAccount(Convert.ToInt32(txtAccountNumber.Text));
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvAccount.Rows[index];

            txtAccountNumber.Text = selectedRow.Cells[0].Value.ToString();
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
            var account = Convert.ToInt32(txtDepAccNumber.Text);
            var currentBal = Convert.ToInt32(txtDepAccBalance.Text);
            var depAmt = Convert.ToInt32(txtDepAmount.Text);
            aDAO.updateAccBalDep(account, currentBal, depAmt);

            Transactions obj = new Transactions(account,depAmt,txtDepDescription.Text,DateTime.Now,txtUser.Text);
            tDAO.logTransaction(obj);

            clearDeposit();

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
           
            GC.Collect();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var account = Convert.ToInt32(txtWithAccNumber.Text);
            var currentBal = Convert.ToInt32(txtWithAccBalance.Text);
            var WithdrawalAmt = Convert.ToInt32(txtWithAmount.Text);
            aDAO.updateAccBalWd(account, currentBal, WithdrawalAmt);

            Transactions obj = new Transactions(account, WithdrawalAmt, txtWithDescription.Text, DateTime.Now, txtUser.Text);
            tDAO.logTransaction(obj);

            clearWithdrawal();
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
            var frmAcc = Convert.ToInt32(txtFdFrmAccount.Text);
            var frmCurBal = Convert.ToInt32(txtFdFrmAccBalance.Text);
            var trfAmt = Convert.ToInt32(txtFdAmount.Text);
            var toAcc = Convert.ToInt32(txtFdToAccount.Text);
            var toCurBal = Convert.ToInt32(txtFdToAccBalance.Text);

            aDAO.fundsTransfer(frmAcc,frmCurBal,trfAmt,toAcc,toCurBal);

            Transactions obj = new Transactions(frmAcc, trfAmt, txtFdFrmAccDescription.Text, DateTime.Now, txtUser.Text);
            tDAO.logTransaction(obj);

            clearTransfer();

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
            Session.Account = Convert.ToInt32(txtAccountNumber.Text);
            new MandateViewer().Show();

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


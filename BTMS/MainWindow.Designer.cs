namespace BTMS
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ManageUser = new System.Windows.Forms.TabPage();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.btnEmpClear = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnCreateEmp = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.txtEmpPassword = new System.Windows.Forms.TextBox();
            this.txtEmpUsername = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.UserProfile = new System.Windows.Forms.TabPage();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtUserEmpEmail = new System.Windows.Forms.TextBox();
            this.txtUserEmpName = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TransactionHistory = new System.Windows.Forms.TabPage();
            this.dgvTransHistory = new System.Windows.Forms.DataGridView();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBCDataSet = new BTMS.CBCDataSet();
            this.FundTransfer = new System.Windows.Forms.TabPage();
            this.label44 = new System.Windows.Forms.Label();
            this.txtFdToAccBalance = new System.Windows.Forms.TextBox();
            this.txtFdToAccName = new System.Windows.Forms.TextBox();
            this.txtFdFrmAccBalance = new System.Windows.Forms.TextBox();
            this.txtFdFrmAccName = new System.Windows.Forms.TextBox();
            this.txtFdToAccDescription = new System.Windows.Forms.TextBox();
            this.txtFdToAccount = new System.Windows.Forms.TextBox();
            this.txtFdFrmAccDescription = new System.Windows.Forms.TextBox();
            this.txtFdAmount = new System.Windows.Forms.TextBox();
            this.txtFdFrmAccount = new System.Windows.Forms.TextBox();
            this.btnFdCancel = new System.Windows.Forms.Button();
            this.btnFdTransfer = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.Withdrawal = new System.Windows.Forms.TabPage();
            this.txtWithAccBalance = new System.Windows.Forms.TextBox();
            this.txtWithAccName = new System.Windows.Forms.TextBox();
            this.txtWithDescription = new System.Windows.Forms.TextBox();
            this.txtWithAmount = new System.Windows.Forms.TextBox();
            this.txtWithAccNumber = new System.Windows.Forms.TextBox();
            this.btnWithdrawCancel = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.Deposit = new System.Windows.Forms.TabPage();
            this.txtDepAccBalance = new System.Windows.Forms.TextBox();
            this.txtDepAccName = new System.Windows.Forms.TextBox();
            this.txtDepDescription = new System.Windows.Forms.TextBox();
            this.txtDepAmount = new System.Windows.Forms.TextBox();
            this.txtDepAccNumber = new System.Windows.Forms.TextBox();
            this.BtnDepCancel = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ManageAccount = new System.Windows.Forms.TabPage();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnAccClear = new System.Windows.Forms.Button();
            this.btnCloseAccount = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOpenedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrintMandate = new System.Windows.Forms.Button();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.btnAccSearch = new System.Windows.Forms.Button();
            this.txtAccCustID = new System.Windows.Forms.TextBox();
            this.txtAccCustName = new System.Windows.Forms.TextBox();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.ManageCustomer = new System.Windows.Forms.TabPage();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pbxSignature = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pbxPhotograph = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.cBCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new BTMS.CBCDataSetTableAdapters.TransactionsTableAdapter();
            this.accountTableAdapter = new BTMS.CBCDataSetTableAdapters.AccountTableAdapter();
            this.ManageUser.SuspendLayout();
            this.UserProfile.SuspendLayout();
            this.TransactionHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBCDataSet)).BeginInit();
            this.FundTransfer.SuspendLayout();
            this.Withdrawal.SuspendLayout();
            this.Deposit.SuspendLayout();
            this.ManageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.ManageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhotograph)).BeginInit();
            this.Tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBCDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(642, 8);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(65, 20);
            this.txtUser.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(713, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User :";
            // 
            // ManageUser
            // 
            this.ManageUser.Controls.Add(this.cbxUserType);
            this.ManageUser.Controls.Add(this.btnEmpClear);
            this.ManageUser.Controls.Add(this.btnDeleteEmp);
            this.ManageUser.Controls.Add(this.btnUpdateEmp);
            this.ManageUser.Controls.Add(this.btnCreateEmp);
            this.ManageUser.Controls.Add(this.btnSearchEmp);
            this.ManageUser.Controls.Add(this.txtEmpPassword);
            this.ManageUser.Controls.Add(this.txtEmpUsername);
            this.ManageUser.Controls.Add(this.txtEmpEmail);
            this.ManageUser.Controls.Add(this.txtEmpName);
            this.ManageUser.Controls.Add(this.txtEmpID);
            this.ManageUser.Controls.Add(this.label18);
            this.ManageUser.Controls.Add(this.label17);
            this.ManageUser.Controls.Add(this.label16);
            this.ManageUser.Controls.Add(this.label15);
            this.ManageUser.Controls.Add(this.label14);
            this.ManageUser.Controls.Add(this.label13);
            this.ManageUser.Location = new System.Drawing.Point(4, 22);
            this.ManageUser.Name = "ManageUser";
            this.ManageUser.Padding = new System.Windows.Forms.Padding(3);
            this.ManageUser.Size = new System.Drawing.Size(738, 371);
            this.ManageUser.TabIndex = 7;
            this.ManageUser.Text = "Manage User";
            this.ManageUser.UseVisualStyleBackColor = true;
            // 
            // cbxUserType
            // 
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "Teller",
            "Admin"});
            this.cbxUserType.Location = new System.Drawing.Point(184, 293);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(121, 21);
            this.cbxUserType.TabIndex = 17;
            // 
            // btnEmpClear
            // 
            this.btnEmpClear.Location = new System.Drawing.Point(459, 39);
            this.btnEmpClear.Name = "btnEmpClear";
            this.btnEmpClear.Size = new System.Drawing.Size(75, 23);
            this.btnEmpClear.TabIndex = 16;
            this.btnEmpClear.Text = "Clear";
            this.btnEmpClear.UseVisualStyleBackColor = true;
            this.btnEmpClear.Click += new System.EventHandler(this.btnEmpClear_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(516, 275);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmp.TabIndex = 15;
            this.btnDeleteEmp.Text = "Delete User";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(516, 221);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEmp.TabIndex = 14;
            this.btnUpdateEmp.Text = "Update User";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnCreateEmp
            // 
            this.btnCreateEmp.Location = new System.Drawing.Point(516, 169);
            this.btnCreateEmp.Name = "btnCreateEmp";
            this.btnCreateEmp.Size = new System.Drawing.Size(75, 23);
            this.btnCreateEmp.TabIndex = 13;
            this.btnCreateEmp.Text = "Create User";
            this.btnCreateEmp.UseVisualStyleBackColor = true;
            this.btnCreateEmp.Click += new System.EventHandler(this.btnCreateEmp_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Location = new System.Drawing.Point(319, 38);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(116, 23);
            this.btnSearchEmp.TabIndex = 12;
            this.btnSearchEmp.Text = "Search User";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // txtEmpPassword
            // 
            this.txtEmpPassword.Location = new System.Drawing.Point(184, 238);
            this.txtEmpPassword.Name = "txtEmpPassword";
            this.txtEmpPassword.PasswordChar = 'x';
            this.txtEmpPassword.Size = new System.Drawing.Size(100, 20);
            this.txtEmpPassword.TabIndex = 11;
            // 
            // txtEmpUsername
            // 
            this.txtEmpUsername.Enabled = false;
            this.txtEmpUsername.Location = new System.Drawing.Point(184, 189);
            this.txtEmpUsername.Name = "txtEmpUsername";
            this.txtEmpUsername.Size = new System.Drawing.Size(100, 20);
            this.txtEmpUsername.TabIndex = 10;
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(184, 142);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(209, 20);
            this.txtEmpEmail.TabIndex = 9;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(184, 92);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(209, 20);
            this.txtEmpName.TabIndex = 7;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(184, 41);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 20);
            this.txtEmpID.TabIndex = 6;
            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(82, 245);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Password :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(82, 196);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Username :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(82, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Email :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "User Type :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(82, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Employee Name :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Employee ID :";
            // 
            // UserProfile
            // 
            this.UserProfile.Controls.Add(this.txtNewPassword);
            this.UserProfile.Controls.Add(this.txtCurrentPassword);
            this.UserProfile.Controls.Add(this.txtUserEmpEmail);
            this.UserProfile.Controls.Add(this.txtUserEmpName);
            this.UserProfile.Controls.Add(this.btnChangePassword);
            this.UserProfile.Controls.Add(this.label19);
            this.UserProfile.Controls.Add(this.label21);
            this.UserProfile.Controls.Add(this.label23);
            this.UserProfile.Location = new System.Drawing.Point(4, 22);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Padding = new System.Windows.Forms.Padding(3);
            this.UserProfile.Size = new System.Drawing.Size(738, 371);
            this.UserProfile.TabIndex = 6;
            this.UserProfile.Text = "User Profile";
            this.UserProfile.UseVisualStyleBackColor = true;
            this.UserProfile.Enter += new System.EventHandler(this.UserProfile_Enter);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(292, 206);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(118, 20);
            this.txtNewPassword.TabIndex = 26;
            this.txtNewPassword.Text = "New Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(292, 162);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(118, 20);
            this.txtCurrentPassword.TabIndex = 24;
            this.txtCurrentPassword.Text = "Current Password";
            // 
            // txtUserEmpEmail
            // 
            this.txtUserEmpEmail.Enabled = false;
            this.txtUserEmpEmail.Location = new System.Drawing.Point(292, 104);
            this.txtUserEmpEmail.Name = "txtUserEmpEmail";
            this.txtUserEmpEmail.Size = new System.Drawing.Size(209, 20);
            this.txtUserEmpEmail.TabIndex = 22;
            // 
            // txtUserEmpName
            // 
            this.txtUserEmpName.Enabled = false;
            this.txtUserEmpName.Location = new System.Drawing.Point(292, 48);
            this.txtUserEmpName.Name = "txtUserEmpName";
            this.txtUserEmpName.Size = new System.Drawing.Size(209, 20);
            this.txtUserEmpName.TabIndex = 20;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(292, 249);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(118, 23);
            this.btnChangePassword.TabIndex = 25;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(196, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Password :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(196, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Email :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(196, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Employee Name :";
            // 
            // TransactionHistory
            // 
            this.TransactionHistory.Controls.Add(this.dgvTransHistory);
            this.TransactionHistory.Location = new System.Drawing.Point(4, 22);
            this.TransactionHistory.Name = "TransactionHistory";
            this.TransactionHistory.Padding = new System.Windows.Forms.Padding(3);
            this.TransactionHistory.Size = new System.Drawing.Size(738, 371);
            this.TransactionHistory.TabIndex = 5;
            this.TransactionHistory.Text = "Transaction History";
            this.TransactionHistory.UseVisualStyleBackColor = true;
            this.TransactionHistory.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // dgvTransHistory
            // 
            this.dgvTransHistory.AutoGenerateColumns = false;
            this.dgvTransHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.tellerDataGridViewTextBoxColumn});
            this.dgvTransHistory.DataSource = this.transactionsBindingSource;
            this.dgvTransHistory.Location = new System.Drawing.Point(33, 21);
            this.dgvTransHistory.Name = "dgvTransHistory";
            this.dgvTransHistory.Size = new System.Drawing.Size(643, 288);
            this.dgvTransHistory.TabIndex = 0;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "TID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "TID";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // tellerDataGridViewTextBoxColumn
            // 
            this.tellerDataGridViewTextBoxColumn.DataPropertyName = "Teller";
            this.tellerDataGridViewTextBoxColumn.HeaderText = "Teller";
            this.tellerDataGridViewTextBoxColumn.Name = "tellerDataGridViewTextBoxColumn";
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.cBCDataSet;
            // 
            // cBCDataSet
            // 
            this.cBCDataSet.DataSetName = "CBCDataSet";
            this.cBCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FundTransfer
            // 
            this.FundTransfer.Controls.Add(this.label44);
            this.FundTransfer.Controls.Add(this.txtFdToAccBalance);
            this.FundTransfer.Controls.Add(this.txtFdToAccName);
            this.FundTransfer.Controls.Add(this.txtFdFrmAccBalance);
            this.FundTransfer.Controls.Add(this.txtFdFrmAccName);
            this.FundTransfer.Controls.Add(this.txtFdToAccDescription);
            this.FundTransfer.Controls.Add(this.txtFdToAccount);
            this.FundTransfer.Controls.Add(this.txtFdFrmAccDescription);
            this.FundTransfer.Controls.Add(this.txtFdAmount);
            this.FundTransfer.Controls.Add(this.txtFdFrmAccount);
            this.FundTransfer.Controls.Add(this.btnFdCancel);
            this.FundTransfer.Controls.Add(this.btnFdTransfer);
            this.FundTransfer.Controls.Add(this.label40);
            this.FundTransfer.Controls.Add(this.label39);
            this.FundTransfer.Controls.Add(this.label38);
            this.FundTransfer.Controls.Add(this.label37);
            this.FundTransfer.Controls.Add(this.label36);
            this.FundTransfer.Controls.Add(this.label35);
            this.FundTransfer.Controls.Add(this.label34);
            this.FundTransfer.Controls.Add(this.label33);
            this.FundTransfer.Location = new System.Drawing.Point(4, 22);
            this.FundTransfer.Name = "FundTransfer";
            this.FundTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.FundTransfer.Size = new System.Drawing.Size(738, 371);
            this.FundTransfer.TabIndex = 4;
            this.FundTransfer.Text = "Funds Transfer";
            this.FundTransfer.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(386, 249);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(95, 13);
            this.label44.TabIndex = 20;
            this.label44.Text = "Account Balance :";
            // 
            // txtFdToAccBalance
            // 
            this.txtFdToAccBalance.Enabled = false;
            this.txtFdToAccBalance.Location = new System.Drawing.Point(497, 246);
            this.txtFdToAccBalance.Name = "txtFdToAccBalance";
            this.txtFdToAccBalance.Size = new System.Drawing.Size(164, 20);
            this.txtFdToAccBalance.TabIndex = 19;
            // 
            // txtFdToAccName
            // 
            this.txtFdToAccName.Enabled = false;
            this.txtFdToAccName.Location = new System.Drawing.Point(497, 204);
            this.txtFdToAccName.Name = "txtFdToAccName";
            this.txtFdToAccName.Size = new System.Drawing.Size(164, 20);
            this.txtFdToAccName.TabIndex = 18;
            // 
            // txtFdFrmAccBalance
            // 
            this.txtFdFrmAccBalance.Enabled = false;
            this.txtFdFrmAccBalance.Location = new System.Drawing.Point(497, 106);
            this.txtFdFrmAccBalance.Name = "txtFdFrmAccBalance";
            this.txtFdFrmAccBalance.Size = new System.Drawing.Size(164, 20);
            this.txtFdFrmAccBalance.TabIndex = 17;
            // 
            // txtFdFrmAccName
            // 
            this.txtFdFrmAccName.Enabled = false;
            this.txtFdFrmAccName.Location = new System.Drawing.Point(497, 60);
            this.txtFdFrmAccName.Name = "txtFdFrmAccName";
            this.txtFdFrmAccName.Size = new System.Drawing.Size(164, 20);
            this.txtFdFrmAccName.TabIndex = 16;
            // 
            // txtFdToAccDescription
            // 
            this.txtFdToAccDescription.Location = new System.Drawing.Point(175, 249);
            this.txtFdToAccDescription.Name = "txtFdToAccDescription";
            this.txtFdToAccDescription.Size = new System.Drawing.Size(140, 20);
            this.txtFdToAccDescription.TabIndex = 15;
            // 
            // txtFdToAccount
            // 
            this.txtFdToAccount.Location = new System.Drawing.Point(175, 204);
            this.txtFdToAccount.Name = "txtFdToAccount";
            this.txtFdToAccount.Size = new System.Drawing.Size(140, 20);
            this.txtFdToAccount.TabIndex = 14;
            this.txtFdToAccount.TextChanged += new System.EventHandler(this.txtFdToAccount_TextChanged);
            // 
            // txtFdFrmAccDescription
            // 
            this.txtFdFrmAccDescription.Location = new System.Drawing.Point(175, 154);
            this.txtFdFrmAccDescription.Name = "txtFdFrmAccDescription";
            this.txtFdFrmAccDescription.Size = new System.Drawing.Size(140, 20);
            this.txtFdFrmAccDescription.TabIndex = 13;
            // 
            // txtFdAmount
            // 
            this.txtFdAmount.Location = new System.Drawing.Point(175, 106);
            this.txtFdAmount.Name = "txtFdAmount";
            this.txtFdAmount.Size = new System.Drawing.Size(140, 20);
            this.txtFdAmount.TabIndex = 12;
            // 
            // txtFdFrmAccount
            // 
            this.txtFdFrmAccount.Location = new System.Drawing.Point(175, 60);
            this.txtFdFrmAccount.Name = "txtFdFrmAccount";
            this.txtFdFrmAccount.Size = new System.Drawing.Size(140, 20);
            this.txtFdFrmAccount.TabIndex = 11;
            this.txtFdFrmAccount.TextChanged += new System.EventHandler(this.txtFdFrmAccount_TextChanged);
            // 
            // btnFdCancel
            // 
            this.btnFdCancel.Location = new System.Drawing.Point(358, 320);
            this.btnFdCancel.Name = "btnFdCancel";
            this.btnFdCancel.Size = new System.Drawing.Size(75, 23);
            this.btnFdCancel.TabIndex = 9;
            this.btnFdCancel.Text = "Cancel";
            this.btnFdCancel.UseVisualStyleBackColor = true;
            this.btnFdCancel.Click += new System.EventHandler(this.btnFdCancel_Click);
            // 
            // btnFdTransfer
            // 
            this.btnFdTransfer.Location = new System.Drawing.Point(240, 320);
            this.btnFdTransfer.Name = "btnFdTransfer";
            this.btnFdTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnFdTransfer.TabIndex = 8;
            this.btnFdTransfer.Text = "Transfer";
            this.btnFdTransfer.UseVisualStyleBackColor = true;
            this.btnFdTransfer.Click += new System.EventHandler(this.btnFdTransfer_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(381, 207);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(100, 13);
            this.label40.TabIndex = 7;
            this.label40.Text = "To Account Name :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(386, 109);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 13);
            this.label39.TabIndex = 6;
            this.label39.Text = "Account Balance :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(381, 63);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(110, 13);
            this.label38.TabIndex = 5;
            this.label38.Text = "From Account Name :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(51, 249);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 13);
            this.label37.TabIndex = 4;
            this.label37.Text = "Description :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(51, 207);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(109, 13);
            this.label36.TabIndex = 3;
            this.label36.Text = "To Account Number :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(51, 161);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(66, 13);
            this.label35.TabIndex = 2;
            this.label35.Text = "Description :";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(45, 106);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(91, 13);
            this.label34.TabIndex = 1;
            this.label34.Text = "Transfer Amount :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(45, 63);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(119, 13);
            this.label33.TabIndex = 0;
            this.label33.Text = "From Account Number :";
            // 
            // Withdrawal
            // 
            this.Withdrawal.Controls.Add(this.txtWithAccBalance);
            this.Withdrawal.Controls.Add(this.txtWithAccName);
            this.Withdrawal.Controls.Add(this.txtWithDescription);
            this.Withdrawal.Controls.Add(this.txtWithAmount);
            this.Withdrawal.Controls.Add(this.txtWithAccNumber);
            this.Withdrawal.Controls.Add(this.btnWithdrawCancel);
            this.Withdrawal.Controls.Add(this.btnWithdraw);
            this.Withdrawal.Controls.Add(this.label28);
            this.Withdrawal.Controls.Add(this.label29);
            this.Withdrawal.Controls.Add(this.label30);
            this.Withdrawal.Controls.Add(this.label31);
            this.Withdrawal.Controls.Add(this.label32);
            this.Withdrawal.Location = new System.Drawing.Point(4, 22);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Padding = new System.Windows.Forms.Padding(3);
            this.Withdrawal.Size = new System.Drawing.Size(738, 371);
            this.Withdrawal.TabIndex = 3;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.UseVisualStyleBackColor = true;
            // 
            // txtWithAccBalance
            // 
            this.txtWithAccBalance.Enabled = false;
            this.txtWithAccBalance.Location = new System.Drawing.Point(499, 159);
            this.txtWithAccBalance.Name = "txtWithAccBalance";
            this.txtWithAccBalance.Size = new System.Drawing.Size(100, 20);
            this.txtWithAccBalance.TabIndex = 23;
            // 
            // txtWithAccName
            // 
            this.txtWithAccName.Enabled = false;
            this.txtWithAccName.Location = new System.Drawing.Point(497, 98);
            this.txtWithAccName.Name = "txtWithAccName";
            this.txtWithAccName.Size = new System.Drawing.Size(100, 20);
            this.txtWithAccName.TabIndex = 22;
            // 
            // txtWithDescription
            // 
            this.txtWithDescription.Location = new System.Drawing.Point(238, 229);
            this.txtWithDescription.Name = "txtWithDescription";
            this.txtWithDescription.Size = new System.Drawing.Size(100, 20);
            this.txtWithDescription.TabIndex = 21;
            this.txtWithDescription.Text = "Cash Withdrawal";
            // 
            // txtWithAmount
            // 
            this.txtWithAmount.Location = new System.Drawing.Point(238, 159);
            this.txtWithAmount.Name = "txtWithAmount";
            this.txtWithAmount.Size = new System.Drawing.Size(100, 20);
            this.txtWithAmount.TabIndex = 20;
            // 
            // txtWithAccNumber
            // 
            this.txtWithAccNumber.Location = new System.Drawing.Point(238, 98);
            this.txtWithAccNumber.Name = "txtWithAccNumber";
            this.txtWithAccNumber.Size = new System.Drawing.Size(100, 20);
            this.txtWithAccNumber.TabIndex = 19;
            this.txtWithAccNumber.TextChanged += new System.EventHandler(this.txtWithAccNumber_TextChanged);
            // 
            // btnWithdrawCancel
            // 
            this.btnWithdrawCancel.Location = new System.Drawing.Point(522, 227);
            this.btnWithdrawCancel.Name = "btnWithdrawCancel";
            this.btnWithdrawCancel.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawCancel.TabIndex = 18;
            this.btnWithdrawCancel.Text = "Cancel";
            this.btnWithdrawCancel.UseVisualStyleBackColor = true;
            this.btnWithdrawCancel.Click += new System.EventHandler(this.btnWithdrawCancel_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(392, 227);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 17;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(383, 162);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 13);
            this.label28.TabIndex = 16;
            this.label28.Text = "Account Balance :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(383, 101);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 13);
            this.label29.TabIndex = 15;
            this.label29.Text = "Account Name :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(149, 232);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(66, 13);
            this.label30.TabIndex = 14;
            this.label30.Text = "Description :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(127, 162);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(105, 13);
            this.label31.TabIndex = 13;
            this.label31.Text = "Withdrawal Amount :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(127, 101);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(93, 13);
            this.label32.TabIndex = 12;
            this.label32.Text = "Account Number :";
            // 
            // Deposit
            // 
            this.Deposit.Controls.Add(this.txtDepAccBalance);
            this.Deposit.Controls.Add(this.txtDepAccName);
            this.Deposit.Controls.Add(this.txtDepDescription);
            this.Deposit.Controls.Add(this.txtDepAmount);
            this.Deposit.Controls.Add(this.txtDepAccNumber);
            this.Deposit.Controls.Add(this.BtnDepCancel);
            this.Deposit.Controls.Add(this.btnDeposit);
            this.Deposit.Controls.Add(this.label27);
            this.Deposit.Controls.Add(this.label26);
            this.Deposit.Controls.Add(this.label25);
            this.Deposit.Controls.Add(this.label24);
            this.Deposit.Controls.Add(this.label20);
            this.Deposit.Location = new System.Drawing.Point(4, 22);
            this.Deposit.Name = "Deposit";
            this.Deposit.Padding = new System.Windows.Forms.Padding(3);
            this.Deposit.Size = new System.Drawing.Size(738, 371);
            this.Deposit.TabIndex = 2;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            // 
            // txtDepAccBalance
            // 
            this.txtDepAccBalance.Enabled = false;
            this.txtDepAccBalance.Location = new System.Drawing.Point(504, 156);
            this.txtDepAccBalance.Name = "txtDepAccBalance";
            this.txtDepAccBalance.Size = new System.Drawing.Size(100, 20);
            this.txtDepAccBalance.TabIndex = 11;
            // 
            // txtDepAccName
            // 
            this.txtDepAccName.Enabled = false;
            this.txtDepAccName.Location = new System.Drawing.Point(502, 95);
            this.txtDepAccName.Name = "txtDepAccName";
            this.txtDepAccName.Size = new System.Drawing.Size(100, 20);
            this.txtDepAccName.TabIndex = 10;
            // 
            // txtDepDescription
            // 
            this.txtDepDescription.Location = new System.Drawing.Point(231, 222);
            this.txtDepDescription.Name = "txtDepDescription";
            this.txtDepDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDepDescription.TabIndex = 9;
            this.txtDepDescription.Text = "Cash Deposit";
            // 
            // txtDepAmount
            // 
            this.txtDepAmount.Location = new System.Drawing.Point(231, 159);
            this.txtDepAmount.Name = "txtDepAmount";
            this.txtDepAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDepAmount.TabIndex = 8;
            // 
            // txtDepAccNumber
            // 
            this.txtDepAccNumber.Location = new System.Drawing.Point(231, 95);
            this.txtDepAccNumber.Name = "txtDepAccNumber";
            this.txtDepAccNumber.Size = new System.Drawing.Size(100, 20);
            this.txtDepAccNumber.TabIndex = 7;
            this.txtDepAccNumber.TextChanged += new System.EventHandler(this.txtDepAccNumber_TextChanged);
            // 
            // BtnDepCancel
            // 
            this.BtnDepCancel.Location = new System.Drawing.Point(527, 224);
            this.BtnDepCancel.Name = "BtnDepCancel";
            this.BtnDepCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnDepCancel.TabIndex = 6;
            this.BtnDepCancel.Text = "Cancel";
            this.BtnDepCancel.UseVisualStyleBackColor = true;
            this.BtnDepCancel.Click += new System.EventHandler(this.BtnDepCancel_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(397, 224);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 5;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(388, 159);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 13);
            this.label27.TabIndex = 4;
            this.label27.Text = "Account Balance :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(388, 98);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "Account Name :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(154, 229);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Description :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(132, 159);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Deposit Amount :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(132, 98);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Account Number :";
            // 
            // ManageAccount
            // 
            this.ManageAccount.Controls.Add(this.txtAccountNumber);
            this.ManageAccount.Controls.Add(this.btnAccClear);
            this.ManageAccount.Controls.Add(this.btnCloseAccount);
            this.ManageAccount.Controls.Add(this.dgvAccount);
            this.ManageAccount.Controls.Add(this.btnPrintMandate);
            this.ManageAccount.Controls.Add(this.btnOpenAccount);
            this.ManageAccount.Controls.Add(this.btnAccSearch);
            this.ManageAccount.Controls.Add(this.txtAccCustID);
            this.ManageAccount.Controls.Add(this.txtAccCustName);
            this.ManageAccount.Controls.Add(this.txtAccID);
            this.ManageAccount.Controls.Add(this.label43);
            this.ManageAccount.Controls.Add(this.label42);
            this.ManageAccount.Controls.Add(this.label41);
            this.ManageAccount.Location = new System.Drawing.Point(4, 22);
            this.ManageAccount.Name = "ManageAccount";
            this.ManageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.ManageAccount.Size = new System.Drawing.Size(738, 371);
            this.ManageAccount.TabIndex = 1;
            this.ManageAccount.Text = "Manage Account";
            this.ManageAccount.UseVisualStyleBackColor = true;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Enabled = false;
            this.txtAccountNumber.Location = new System.Drawing.Point(623, 192);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 15;
            // 
            // btnAccClear
            // 
            this.btnAccClear.Location = new System.Drawing.Point(315, 124);
            this.btnAccClear.Name = "btnAccClear";
            this.btnAccClear.Size = new System.Drawing.Size(75, 23);
            this.btnAccClear.TabIndex = 14;
            this.btnAccClear.Text = "Clear";
            this.btnAccClear.UseVisualStyleBackColor = true;
            this.btnAccClear.Click += new System.EventHandler(this.btnAccClear_Click);
            // 
            // btnCloseAccount
            // 
            this.btnCloseAccount.Location = new System.Drawing.Point(622, 279);
            this.btnCloseAccount.Name = "btnCloseAccount";
            this.btnCloseAccount.Size = new System.Drawing.Size(101, 23);
            this.btnCloseAccount.TabIndex = 13;
            this.btnCloseAccount.Text = "Close Account";
            this.btnCloseAccount.UseVisualStyleBackColor = true;
            this.btnCloseAccount.Click += new System.EventHandler(this.btnCloseAccount_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoGenerateColumns = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.dateOpenedDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvAccount.DataSource = this.accountBindingSource;
            this.dgvAccount.Location = new System.Drawing.Point(62, 179);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(545, 123);
            this.dgvAccount.TabIndex = 12;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // dateOpenedDataGridViewTextBoxColumn
            // 
            this.dateOpenedDataGridViewTextBoxColumn.DataPropertyName = "Date Opened";
            this.dateOpenedDataGridViewTextBoxColumn.HeaderText = "Date Opened";
            this.dateOpenedDataGridViewTextBoxColumn.Name = "dateOpenedDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.cBCDataSet;
            // 
            // btnPrintMandate
            // 
            this.btnPrintMandate.Location = new System.Drawing.Point(621, 236);
            this.btnPrintMandate.Name = "btnPrintMandate";
            this.btnPrintMandate.Size = new System.Drawing.Size(102, 23);
            this.btnPrintMandate.TabIndex = 11;
            this.btnPrintMandate.Text = "Print Mandate";
            this.btnPrintMandate.UseVisualStyleBackColor = true;
            this.btnPrintMandate.Click += new System.EventHandler(this.btnPrintMandate_Click);
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(409, 33);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(101, 23);
            this.btnOpenAccount.TabIndex = 10;
            this.btnOpenAccount.Text = "Open Account";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // btnAccSearch
            // 
            this.btnAccSearch.Location = new System.Drawing.Point(315, 33);
            this.btnAccSearch.Name = "btnAccSearch";
            this.btnAccSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAccSearch.TabIndex = 8;
            this.btnAccSearch.Text = "Search";
            this.btnAccSearch.UseVisualStyleBackColor = true;
            this.btnAccSearch.Click += new System.EventHandler(this.btnAccSearch_Click);
            // 
            // txtAccCustID
            // 
            this.txtAccCustID.Enabled = false;
            this.txtAccCustID.Location = new System.Drawing.Point(186, 124);
            this.txtAccCustID.Name = "txtAccCustID";
            this.txtAccCustID.Size = new System.Drawing.Size(100, 20);
            this.txtAccCustID.TabIndex = 6;
            // 
            // txtAccCustName
            // 
            this.txtAccCustName.Enabled = false;
            this.txtAccCustName.Location = new System.Drawing.Point(186, 77);
            this.txtAccCustName.Name = "txtAccCustName";
            this.txtAccCustName.Size = new System.Drawing.Size(202, 20);
            this.txtAccCustName.TabIndex = 5;
            // 
            // txtAccID
            // 
            this.txtAccID.Location = new System.Drawing.Point(186, 37);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.Size = new System.Drawing.Size(113, 20);
            this.txtAccID.TabIndex = 4;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(59, 127);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(71, 13);
            this.label43.TabIndex = 2;
            this.label43.Text = "Customer ID :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(59, 84);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(88, 13);
            this.label42.TabIndex = 1;
            this.label42.Text = "Customer Name ;";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(59, 37);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(109, 13);
            this.label41.TabIndex = 0;
            this.label41.Text = "NIC/PP/DL Number :";
            // 
            // ManageCustomer
            // 
            this.ManageCustomer.Controls.Add(this.btnClearCustomer);
            this.ManageCustomer.Controls.Add(this.btnDeleteCustomer);
            this.ManageCustomer.Controls.Add(this.btnUpdateCustomer);
            this.ManageCustomer.Controls.Add(this.btnCreateCustomer);
            this.ManageCustomer.Controls.Add(this.txtCustomerID);
            this.ManageCustomer.Controls.Add(this.txtOccupation);
            this.ManageCustomer.Controls.Add(this.txtEmail);
            this.ManageCustomer.Controls.Add(this.txtContact);
            this.ManageCustomer.Controls.Add(this.txtAddress);
            this.ManageCustomer.Controls.Add(this.txtFullName);
            this.ManageCustomer.Controls.Add(this.txtID);
            this.ManageCustomer.Controls.Add(this.label12);
            this.ManageCustomer.Controls.Add(this.txtDOB);
            this.ManageCustomer.Controls.Add(this.btnCustomerSearch);
            this.ManageCustomer.Controls.Add(this.label11);
            this.ManageCustomer.Controls.Add(this.pbxSignature);
            this.ManageCustomer.Controls.Add(this.label10);
            this.ManageCustomer.Controls.Add(this.pbxPhotograph);
            this.ManageCustomer.Controls.Add(this.label9);
            this.ManageCustomer.Controls.Add(this.label8);
            this.ManageCustomer.Controls.Add(this.label7);
            this.ManageCustomer.Controls.Add(this.label6);
            this.ManageCustomer.Controls.Add(this.label5);
            this.ManageCustomer.Controls.Add(this.label4);
            this.ManageCustomer.Controls.Add(this.label3);
            this.ManageCustomer.Location = new System.Drawing.Point(4, 22);
            this.ManageCustomer.Name = "ManageCustomer";
            this.ManageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.ManageCustomer.Size = new System.Drawing.Size(738, 371);
            this.ManageCustomer.TabIndex = 0;
            this.ManageCustomer.Text = "Manage Customer";
            this.ManageCustomer.UseVisualStyleBackColor = true;
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Location = new System.Drawing.Point(435, 27);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnClearCustomer.TabIndex = 24;
            this.btnClearCustomer.Text = "Clear";
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClearCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(306, 329);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(123, 23);
            this.btnDeleteCustomer.TabIndex = 23;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(165, 329);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(121, 23);
            this.btnUpdateCustomer.TabIndex = 22;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(24, 329);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(114, 23);
            this.btnCreateCustomer.TabIndex = 21;
            this.btnCreateCustomer.Text = "Create Customer";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(615, 27);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 20;
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(126, 234);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(160, 20);
            this.txtOccupation.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(126, 148);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(160, 20);
            this.txtContact.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(126, 108);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(363, 20);
            this.txtAddress.TabIndex = 14;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(126, 70);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(363, 20);
            this.txtFullName.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(126, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(160, 20);
            this.txtID.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(532, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Customer ID :";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(126, 278);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(160, 20);
            this.txtDOB.TabIndex = 18;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Location = new System.Drawing.Point(306, 27);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(115, 23);
            this.btnCustomerSearch.TabIndex = 13;
            this.btnCustomerSearch.Text = "Search Customer";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(512, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Signature :";
            // 
            // pbxSignature
            // 
            this.pbxSignature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxSignature.Location = new System.Drawing.Point(586, 217);
            this.pbxSignature.Name = "pbxSignature";
            this.pbxSignature.Size = new System.Drawing.Size(129, 94);
            this.pbxSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSignature.TabIndex = 9;
            this.pbxSignature.TabStop = false;
            this.pbxSignature.Click += new System.EventHandler(this.pbxSignature_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Photograph :";
            // 
            // pbxPhotograph
            // 
            this.pbxPhotograph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPhotograph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPhotograph.Location = new System.Drawing.Point(586, 70);
            this.pbxPhotograph.Name = "pbxPhotograph";
            this.pbxPhotograph.Size = new System.Drawing.Size(129, 129);
            this.pbxPhotograph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhotograph.TabIndex = 7;
            this.pbxPhotograph.TabStop = false;
            this.pbxPhotograph.Click += new System.EventHandler(this.pbxPhotograph_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Date of Birth :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Occupation :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contact No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Full Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "NIC/PP/DL No :";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.ManageCustomer);
            this.Tabs.Controls.Add(this.ManageAccount);
            this.Tabs.Controls.Add(this.Deposit);
            this.Tabs.Controls.Add(this.Withdrawal);
            this.Tabs.Controls.Add(this.FundTransfer);
            this.Tabs.Controls.Add(this.TransactionHistory);
            this.Tabs.Controls.Add(this.UserProfile);
            this.Tabs.Controls.Add(this.ManageUser);
            this.Tabs.Location = new System.Drawing.Point(27, 34);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(746, 397);
            this.Tabs.TabIndex = 3;
            // 
            // cBCDataSetBindingSource
            // 
            this.cBCDataSetBindingSource.DataSource = this.cBCDataSet;
            this.cBCDataSetBindingSource.Position = 0;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CBC Bank Transaction Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ManageUser.ResumeLayout(false);
            this.ManageUser.PerformLayout();
            this.UserProfile.ResumeLayout(false);
            this.UserProfile.PerformLayout();
            this.TransactionHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBCDataSet)).EndInit();
            this.FundTransfer.ResumeLayout(false);
            this.FundTransfer.PerformLayout();
            this.Withdrawal.ResumeLayout(false);
            this.Withdrawal.PerformLayout();
            this.Deposit.ResumeLayout(false);
            this.Deposit.PerformLayout();
            this.ManageAccount.ResumeLayout(false);
            this.ManageAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ManageCustomer.ResumeLayout(false);
            this.ManageCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhotograph)).EndInit();
            this.Tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cBCDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.TabPage ManageUser;
        private System.Windows.Forms.Button btnEmpClear;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnCreateEmp;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox txtEmpPassword;
        private System.Windows.Forms.TextBox txtEmpUsername;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage UserProfile;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtUserEmpEmail;
        private System.Windows.Forms.TextBox txtUserEmpName;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage TransactionHistory;
        private System.Windows.Forms.TabPage FundTransfer;
        private System.Windows.Forms.TextBox txtFdToAccName;
        private System.Windows.Forms.TextBox txtFdFrmAccBalance;
        private System.Windows.Forms.TextBox txtFdFrmAccName;
        private System.Windows.Forms.TextBox txtFdToAccDescription;
        private System.Windows.Forms.TextBox txtFdToAccount;
        private System.Windows.Forms.TextBox txtFdFrmAccDescription;
        private System.Windows.Forms.TextBox txtFdAmount;
        private System.Windows.Forms.TextBox txtFdFrmAccount;
        private System.Windows.Forms.Button btnFdCancel;
        private System.Windows.Forms.Button btnFdTransfer;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TabPage Withdrawal;
        private System.Windows.Forms.TextBox txtWithAccBalance;
        private System.Windows.Forms.TextBox txtWithAccName;
        private System.Windows.Forms.TextBox txtWithDescription;
        private System.Windows.Forms.TextBox txtWithAmount;
        private System.Windows.Forms.TextBox txtWithAccNumber;
        private System.Windows.Forms.Button btnWithdrawCancel;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage Deposit;
        private System.Windows.Forms.TextBox txtDepAccBalance;
        private System.Windows.Forms.TextBox txtDepAccName;
        private System.Windows.Forms.TextBox txtDepDescription;
        private System.Windows.Forms.TextBox txtDepAmount;
        private System.Windows.Forms.TextBox txtDepAccNumber;
        private System.Windows.Forms.Button BtnDepCancel;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage ManageAccount;
        private System.Windows.Forms.TabPage ManageCustomer;
        private System.Windows.Forms.Button btnClearCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbxSignature;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbxPhotograph;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnPrintMandate;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Button btnAccSearch;
        private System.Windows.Forms.TextBox txtAccCustID;
        private System.Windows.Forms.TextBox txtAccCustName;
        private System.Windows.Forms.TextBox txtAccID;
        private System.Windows.Forms.Button btnCloseAccount;
        private System.Windows.Forms.DataGridView dgvTransHistory;
        private System.Windows.Forms.BindingSource cBCDataSetBindingSource;
        private CBCDataSet cBCDataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private CBCDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private CBCDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOpenedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAccClear;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtFdToAccBalance;
        private System.Windows.Forms.ComboBox cbxUserType;
    }
}
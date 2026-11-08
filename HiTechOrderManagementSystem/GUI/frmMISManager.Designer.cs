namespace HiTechOrderManagementSystem.GUI
{
    partial class frmMISManager
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
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.btnClearUser = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lvViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtUPassword = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtEmpIdUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearEmp = new System.Windows.Forms.Button();
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabEmployee.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackColor = System.Drawing.Color.SlateGray;
            this.tabEmployee.Controls.Add(this.btnExit1);
            this.tabEmployee.Controls.Add(this.btnClearUser);
            this.tabEmployee.Controls.Add(this.cboStatus);
            this.tabEmployee.Controls.Add(this.lvViewUsers);
            this.tabEmployee.Controls.Add(this.btnListUsers);
            this.tabEmployee.Controls.Add(this.btnAddUser);
            this.tabEmployee.Controls.Add(this.btnUpdateUser);
            this.tabEmployee.Controls.Add(this.btnDeleteUser);
            this.tabEmployee.Controls.Add(this.btnSearchUser);
            this.tabEmployee.Controls.Add(this.txtUPassword);
            this.tabEmployee.Controls.Add(this.txtUName);
            this.tabEmployee.Controls.Add(this.txtEmpIdUser);
            this.tabEmployee.Controls.Add(this.label6);
            this.tabEmployee.Controls.Add(this.label5);
            this.tabEmployee.Controls.Add(this.label8);
            this.tabEmployee.Controls.Add(this.label7);
            this.tabEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmployee.Location = new System.Drawing.Point(4, 27);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(788, 486);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Users";
            this.tabEmployee.Click += new System.EventHandler(this.tabEmployee_Click);
            // 
            // btnExit1
            // 
            this.btnExit1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit1.Location = new System.Drawing.Point(673, 411);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(96, 41);
            this.btnExit1.TabIndex = 28;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = false;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // btnClearUser
            // 
            this.btnClearUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClearUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUser.Location = new System.Drawing.Point(308, 215);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(96, 41);
            this.btnClearUser.TabIndex = 27;
            this.btnClearUser.Text = "Clear";
            this.btnClearUser.UseVisualStyleBackColor = false;
            this.btnClearUser.Click += new System.EventHandler(this.btnClearUser_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(429, 94);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(151, 26);
            this.cboStatus.TabIndex = 26;
            // 
            // lvViewUsers
            // 
            this.lvViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvViewUsers.HideSelection = false;
            this.lvViewUsers.Location = new System.Drawing.Point(17, 306);
            this.lvViewUsers.Name = "lvViewUsers";
            this.lvViewUsers.Size = new System.Drawing.Size(650, 146);
            this.lvViewUsers.TabIndex = 25;
            this.lvViewUsers.UseCompatibleStateImageBehavior = false;
            this.lvViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User Name";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EmployeeID";
            this.columnHeader3.Width = 153;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "StatusID";
            this.columnHeader4.Width = 178;
            // 
            // btnListUsers
            // 
            this.btnListUsers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUsers.Location = new System.Drawing.Point(43, 215);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(222, 39);
            this.btnListUsers.TabIndex = 24;
            this.btnListUsers.Text = "List All Users DB";
            this.btnListUsers.UseVisualStyleBackColor = false;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(621, 31);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(129, 38);
            this.btnAddUser.TabIndex = 23;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(621, 89);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(129, 39);
            this.btnUpdateUser.TabIndex = 22;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(621, 148);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(129, 37);
            this.btnDeleteUser.TabIndex = 21;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Location = new System.Drawing.Point(621, 208);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(129, 46);
            this.btnSearchUser.TabIndex = 20;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtUPassword
            // 
            this.txtUPassword.Location = new System.Drawing.Point(429, 35);
            this.txtUPassword.Name = "txtUPassword";
            this.txtUPassword.Size = new System.Drawing.Size(151, 24);
            this.txtUPassword.TabIndex = 19;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(142, 32);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(151, 24);
            this.txtUName.TabIndex = 17;
            // 
            // txtEmpIdUser
            // 
            this.txtEmpIdUser.Location = new System.Drawing.Point(142, 91);
            this.txtEmpIdUser.Name = "txtEmpIdUser";
            this.txtEmpIdUser.Size = new System.Drawing.Size(151, 24);
            this.txtEmpIdUser.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "User Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Employee ID :";
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.SlateGray;
            this.tabUsers.Controls.Add(this.btnExit);
            this.tabUsers.Controls.Add(this.btnClearEmp);
            this.tabUsers.Controls.Add(this.lvEmployees);
            this.tabUsers.Controls.Add(this.label4);
            this.tabUsers.Controls.Add(this.label3);
            this.tabUsers.Controls.Add(this.label2);
            this.tabUsers.Controls.Add(this.label1);
            this.tabUsers.Controls.Add(this.btnListAll);
            this.tabUsers.Controls.Add(this.btnSearchEmp);
            this.tabUsers.Controls.Add(this.btnDeleteEmp);
            this.tabUsers.Controls.Add(this.btnAddEmp);
            this.tabUsers.Controls.Add(this.btnUpdateEmp);
            this.tabUsers.Controls.Add(this.txtFName);
            this.tabUsers.Controls.Add(this.txtLName);
            this.tabUsers.Controls.Add(this.txtJobID);
            this.tabUsers.Controls.Add(this.txtEmpID);
            this.tabUsers.Location = new System.Drawing.Point(4, 27);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(788, 486);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Employees";
            this.tabUsers.Click += new System.EventHandler(this.tabUsers_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(651, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearEmp
            // 
            this.btnClearEmp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClearEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEmp.Location = new System.Drawing.Point(301, 240);
            this.btnClearEmp.Name = "btnClearEmp";
            this.btnClearEmp.Size = new System.Drawing.Size(117, 35);
            this.btnClearEmp.TabIndex = 14;
            this.btnClearEmp.Text = "Clear";
            this.btnClearEmp.UseVisualStyleBackColor = false;
            this.btnClearEmp.Click += new System.EventHandler(this.btnClearEmp_Click);
            // 
            // lvEmployees
            // 
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvEmployees.HideSelection = false;
            this.lvEmployees.Location = new System.Drawing.Point(25, 313);
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(620, 149);
            this.lvEmployees.TabIndex = 13;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "EmployeeID";
            this.columnHeader5.Width = 153;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "First Name";
            this.columnHeader6.Width = 154;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Last Name";
            this.columnHeader7.Width = 171;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "JobID";
            this.columnHeader8.Width = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "JobID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "EmployeeID :";
            // 
            // btnListAll
            // 
            this.btnListAll.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAll.Location = new System.Drawing.Point(39, 240);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(222, 35);
            this.btnListAll.TabIndex = 8;
            this.btnListAll.Text = "List All Employees DB";
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmp.Location = new System.Drawing.Point(613, 215);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(129, 38);
            this.btnSearchEmp.TabIndex = 7;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmp.Location = new System.Drawing.Point(613, 160);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(129, 35);
            this.btnDeleteEmp.TabIndex = 6;
            this.btnDeleteEmp.Text = "Delete";
            this.btnDeleteEmp.UseVisualStyleBackColor = false;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(613, 43);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(129, 40);
            this.btnAddEmp.TabIndex = 5;
            this.btnAddEmp.Text = "Add";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmp.Location = new System.Drawing.Point(613, 107);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(129, 36);
            this.btnUpdateEmp.TabIndex = 4;
            this.btnUpdateEmp.Text = "Update";
            this.btnUpdateEmp.UseVisualStyleBackColor = false;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(140, 113);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(151, 24);
            this.txtFName.TabIndex = 3;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(427, 110);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(139, 24);
            this.txtLName.TabIndex = 2;
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(427, 43);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(139, 24);
            this.txtJobID.TabIndex = 1;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(140, 38);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(151, 24);
            this.txtEmpID.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabUsers);
            this.tabs.Controls.Add(this.tabEmployee);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(796, 517);
            this.tabs.TabIndex = 0;
            // 
            // frmMISManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 537);
            this.Controls.Add(this.tabs);
            this.Name = "frmMISManager";
            this.Text = "MIS Manager";
            this.Load += new System.EventHandler(this.frmMISManager_Load);
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.ListView lvViewUsers;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtUPassword;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.TextBox txtEmpIdUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.ListView lvEmployees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnClearEmp;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnClearUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExit1;
    }
}
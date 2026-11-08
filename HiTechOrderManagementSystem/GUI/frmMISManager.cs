using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HiTechOrderManagementSystem.DAL;
using HiTechOrderManagementSystem.BLL;


namespace HiTechOrderManagementSystem.GUI
{
    public partial class frmMISManager : Form
    {
        public frmMISManager()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text) ||
                string.IsNullOrWhiteSpace(txtLName.Text) ||
                string.IsNullOrWhiteSpace(txtJobID.Text))
            {
                MessageBox.Show("Please enter all employee information.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee emp = new Employee();
            emp.FirstName = txtFName.Text.Trim();
            emp.LastName = txtLName.Text.Trim();
            emp.JobId = Convert.ToInt32(txtJobID.Text.Trim());

            EmployeeDB.AddEmployee(emp);

            MessageBox.Show("Employee has been successfully added.",
                "Add Employee");

            ClearEmployeeFields();
        }

       

        private void btnListAll_Click(object sender, EventArgs e)
        {
            lvEmployees.Items.Clear();

            List<Employee> list = EmployeeDB.GetAllEmployees();

            foreach (Employee emp in list)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);
                item.SubItems.Add(emp.JobId.ToString());
                lvEmployees.Items.Add(item);
            }
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee ID.",
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int empId = Convert.ToInt32(txtEmpID.Text.Trim());
            Employee emp = EmployeeDB.SearchEmployee(empId);

            if (emp != null)
            {
                txtFName.Text = emp.FirstName;
                txtLName.Text = emp.LastName;
                txtJobID.Text = emp.JobId.ToString();
            }
            else
            {
                MessageBox.Show("Employee not found.",
                    "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee ID.",
                    "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this employee?",
                "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int empId = Convert.ToInt32(txtEmpID.Text.Trim());
                EmployeeDB.DeleteEmployee(empId);

                MessageBox.Show("Employee deleted successfully.",
                    "Delete Employee");

                ClearEmployeeFields();
            }
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee ID.",
                    "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(txtEmpID.Text.Trim());
            emp.FirstName = txtFName.Text.Trim();
            emp.LastName = txtLName.Text.Trim();
            emp.JobId = Convert.ToInt32(txtJobID.Text.Trim());

            EmployeeDB.UpdateEmployee(emp);

            MessageBox.Show("Employee data has been updated.",
                "Update Success");
        }

        private void btnClearEmp_Click(object sender, EventArgs e)
        {
            
                ClearEmployeeFields();
        }

        private void ClearEmployeeFields()
        {
            txtEmpID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtJobID.Text = "";
            txtFName.Focus();
        }

        private void frmMISManager_Load(object sender, EventArgs e)
        {
            cboStatus.DataSource = StatusDB.GetAllStatuses();
            cboStatus.DisplayMember = "Description";   // what shows to user
            cboStatus.ValueMember = "StatusId";        // real ID
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUName.Text) ||
        string.IsNullOrWhiteSpace(txtUPassword.Text) ||
        string.IsNullOrWhiteSpace(txtEmpIdUser.Text))
            {
                MessageBox.Show("Please enter User Name, Password and Employee ID.",
                                "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int empId;
            if (!int.TryParse(txtEmpIdUser.Text.Trim(), out empId))
            {
                MessageBox.Show("Employee ID must be a number.",
                                "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmpIdUser.Focus();
                return;
            }

            Employee emp = EmployeeDB.SearchEmployee(empId);
            if (emp == null)
            {
                MessageBox.Show("This Employee ID does not exist in Employees table.\n" +
                                "Please add the employee first.",
                                "Invalid Employee ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpIdUser.Focus();
                return;
            }

            User user = new User();
            user.UserName = txtUName.Text.Trim();
            user.Password = txtUPassword.Text.Trim();
            user.EmployeeId = empId;
            user.StatusId = Convert.ToInt32(cboStatus.SelectedValue);

            UserDB.SaveRecord(user);
            MessageBox.Show("User saved successfully.");
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            
        
            User user = new User();

            user.UserName = txtUName.Text.Trim();
            user.Password = txtUPassword.Text.Trim();
            user.EmployeeId = Convert.ToInt32(txtEmpIdUser.Text.Trim());
            user.StatusId = Convert.ToInt32(cboStatus.SelectedValue);

            UserDB.UpdateRecord(user);
            MessageBox.Show("User updated successfully.");
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {


            string userName = txtUName.Text.Trim();

            User user = UserDB.SearchRecord(userName);

            if (user != null)
            {
                txtUPassword.Text = user.Password;
                txtEmpIdUser.Text = user.EmployeeId.ToString();
                cboStatus.SelectedValue = user.StatusId;
            }
            else
            {
                MessageBox.Show("User not found.", "Search");
            }
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            lvViewUsers.Items.Clear();

            List<User> list = UserDB.GetAllRecords();
            List<Status> allStatuses = StatusDB.GetAllStatuses();

            foreach (User user in list)
            {
                Status st = allStatuses.Find(s => s.StatusId == user.StatusId);
                string desc = st != null ? st.Description : "Unknown";

                ListViewItem item = new ListViewItem(user.UserName);
                item.SubItems.Add(user.Password);
                item.SubItems.Add(user.EmployeeId.ToString());
                item.SubItems.Add(desc);

                lvViewUsers.Items.Add(item);
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            txtUName.Text = "";
            txtUPassword.Text = "";
            txtEmpIdUser.Text = "";
            cboStatus.SelectedIndex = 0;

            txtUName.Focus();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string userName = txtUName.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter a username to delete.",
                                "Missing Username",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                UserDB.DeleteRecord(userName);
                MessageBox.Show("User deleted successfully.", "Delete User");

             
            }
        }

        private void tabEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();             
            frmMain mainForm = new frmMain();
            mainForm.ShowDialog();    
            this.Close();

        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMISManager misForm = new frmMISManager();
            misForm.ShowDialog();
            this.Close();
        }

        private void tabUsers_Click(object sender, EventArgs e)
        {

        }
    }
}

    


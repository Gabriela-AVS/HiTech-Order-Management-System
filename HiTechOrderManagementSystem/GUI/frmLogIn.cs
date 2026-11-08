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
using HiTechOrderManagementSystem.BLL;
using HiTechOrderManagementSystem.DAL;

namespace HiTechOrderManagementSystem.GUI
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picLogo.Width - 1, picLogo.Height - 1);
            picLogo.Region = new Region(gp);

            this.AcceptButton = btnLogin;




        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            
            if (userName == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.", "Login",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            Employee emp = EmployeeDB.GetEmployeeByLogin(userName, password);

            if (emp == null)
            {
                MessageBox.Show("Invalid username or password.", "Login",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            CurrentSession.EmployeeId = emp.EmployeeId;
            CurrentSession.JobId = emp.JobId;
            CurrentSession.UserName = emp.FirstName + " " + emp.LastName;

            MessageBox.Show($"Welcome {emp.FirstName} {emp.LastName} to HiTech Order Management System!","Welcome",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }
    






        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

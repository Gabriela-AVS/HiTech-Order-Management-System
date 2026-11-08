using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechOrderManagementSystem.BLL;
using HiTechOrderManagementSystem.DAL;

namespace HiTechOrderManagementSystem.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mISManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentSession.JobId != 1)
            {
                MessageBox.Show("You are not allowed to access MIS Manager.", "Access Denied");
                return;
            }

            frmMISManager frmMISManager = new frmMISManager();
            frmMISManager.ShowDialog();
        }

        private void salesManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentSession.JobId != 2)
            {
                MessageBox.Show("You are not allowed to access Sales Manager.", "Access Denied");
                return;
            }

            frmSalesManager frmSalesManager = new frmSalesManager();
            frmSalesManager.ShowDialog();
        }

        private void inventoryControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentSession.JobId != 3)
            {
                MessageBox.Show("You are not allowed to access Inventory Controller.", "Access Denied");
                return;
            }

            frmInventoryController frmInventoryController = new frmInventoryController();
            frmInventoryController.ShowDialog();
        }

        private void orderClerksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentSession.JobId != 4)
            {
                MessageBox.Show("You are not allowed to access Order Clerks.", "Access Denied");
                return;
            }

            frmOrderClerks frmOrderClerks = new frmOrderClerks();
            frmOrderClerks.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you really want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, PicLogo.Width, PicLogo.Height);
            PicLogo.Region = new Region(path);



        }
    }
}

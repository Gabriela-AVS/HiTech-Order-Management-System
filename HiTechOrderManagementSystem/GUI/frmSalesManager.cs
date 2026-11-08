using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HiTechOrderManagementSystem.BLL;
using HiTechOrderManagementSystem.DAL;
using HiTechOrderManagementSystem.VALIDATOR;

using System.Data.SqlClient;

namespace HiTechOrderManagementSystem.GUI
{
    public partial class frmSalesManager : Form
    {
        SqlDataAdapter da;
        DataSet dsHiTechDB;
        DataTable dtCustomers;
        SqlCommandBuilder cmdBuilder;
        Customer customer = new Customer();

        public frmSalesManager()
        {
            InitializeComponent();
        }

   
        private void btnListAllCustomers_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            List<Customer> listC = customer.GetAllCustomers();

          

            if ((listC != null) && (listC.Count > 0))
            {
                dataGridViewCustomers.AutoGenerateColumns = false;
                dataGridViewCustomers.DataSource = listC;
            }
            else
            {
                MessageBox.Show("Customer not found in database.",
                                "No Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtCustomerId.Text) ||
         string.IsNullOrWhiteSpace(txtNameOfInstitution.Text) ||
         string.IsNullOrWhiteSpace(txtStreet.Text) ||
         string.IsNullOrWhiteSpace(txtCity.Text) ||
         string.IsNullOrWhiteSpace(txtPostalCode.Text) ||
         string.IsNullOrWhiteSpace(txtTelephone.Text) ||
         string.IsNullOrWhiteSpace(txtFax.Text) ||
         string.IsNullOrWhiteSpace(txtCreditLimit.Text))
    {
                MessageBox.Show("Please fill in all required fields.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtCustomerId.Focus();
                return;
            }

           
            if (!Validator.IsValidQuebecPostalCode(txtPostalCode.Text))
            {
                MessageBox.Show("Invalid Quebec postal code. It must start with H, G, or J.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPostalCode.Focus();
                return;
            }

            if (!Validator.IsValidPhone(txtTelephone.Text))
            {
                MessageBox.Show("Telephone must contain exactly 10 digits.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtTelephone.Focus();
                return;
            }

            if (!Validator.IsValidFax(txtFax.Text))
            {
                MessageBox.Show("Fax must contain exactly 10 digits.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtFax.Focus();
                return;
            }

            if (!Validator.IsValidCreditLimit(txtCreditLimit.Text))
            {
                MessageBox.Show("Credit limit must be a valid number and cannot be negative.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtCreditLimit.Focus();
                return;
            }



            DataRow drCustomer = dtCustomers.NewRow();
            drCustomer["CustomerId"] = Convert.ToInt32(txtCustomerId.Text.Trim());
            drCustomer["NameOfInstitution"] = txtNameOfInstitution.Text.Trim();
            drCustomer["Street"] = txtStreet.Text.Trim();
            drCustomer["City"] = txtCity.Text.Trim();
            drCustomer["PostalCode"] = txtPostalCode.Text.Trim();
            drCustomer["Telephone"] = txtTelephone.Text.Trim();
            drCustomer["Fax"] = txtFax.Text.Trim();
            drCustomer["CreditLimit"] = Convert.ToDecimal(txtCreditLimit.Text.Trim());

            dtCustomers.Rows.Add(drCustomer);

            MessageBox.Show(drCustomer.RowState.ToString());
        }

      
        private void btnUpdateDatabase_Click(object sender, EventArgs e)
        {
            da.Update(dsHiTechDB.Tables["Customers"]);
            MessageBox.Show("Database has been updated Successfully.", "Confirmation");
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerId.Text))
            {
                MessageBox.Show("Please enter a Customer ID.", "Input Required");
                return;
            }

            DataRow dr = dtCustomers.Rows.Find(Convert.ToInt32(txtCustomerId.Text.Trim()));

            if (dr != null)
            {
                txtNameOfInstitution.Text = dr["NameOfInstitution"].ToString();
                txtStreet.Text = dr["Street"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtPostalCode.Text = dr["PostalCode"].ToString().Trim();
                txtTelephone.Text = dr["Telephone"].ToString().Trim();
                txtFax.Text = dr["Fax"].ToString().Trim();
                txtCreditLimit.Text = dr["CreditLimit"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Customer info not found.", "Invalid Information");
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerId.Text))
            {
                MessageBox.Show("Please enter a Customer ID you wish to modify.",
                                "Input Required",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow dr = dtCustomers.Rows.Find(Convert.ToInt32(txtCustomerId.Text.Trim()));

            if (dr != null)
            {
                dr["NameOfInstitution"] = txtNameOfInstitution.Text.Trim();
                dr["Street"] = txtStreet.Text.Trim();
                dr["City"] = txtCity.Text.Trim();
                dr["PostalCode"] = txtPostalCode.Text.Trim();
                dr["Telephone"] = txtTelephone.Text.Trim();
                dr["Fax"] = txtFax.Text.Trim();
                dr["CreditLimit"] = Convert.ToDecimal(txtCreditLimit.Text.Trim());

                MessageBox.Show("Customer info updated in memory.\nClick 'Update Database' to save to SQL.",
                                "Modified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!Validator.IsValidQuebecPostalCode(txtPostalCode.Text))
            {
                MessageBox.Show("Invalid Quebec postal code. It must start with H, G, or J.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPostalCode.Focus();
                return;
            }

            if (!Validator.IsValidPhone(txtTelephone.Text))
            {
                MessageBox.Show("Telephone must contain exactly 10 digits.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtTelephone.Focus();
                return;
            }

            if (!Validator.IsValidFax(txtFax.Text))
            {
                MessageBox.Show("Fax must contain exactly 10 digits.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtFax.Focus();
                return;
            }

            if (!Validator.IsValidCreditLimit(txtCreditLimit.Text))
            {
                MessageBox.Show("Credit limit must be a valid number and cannot be negative.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtCreditLimit.Focus();
                return;
            }



        }


        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerId.Text))
            {
                MessageBox.Show("Please enter a Customer ID to delete.",
                                "Input Required",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow dr = dtCustomers.Rows.Find(Convert.ToInt32(txtCustomerId.Text.Trim()));

            if (dr != null)
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to delete this customer?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    dr.Delete();
                    MessageBox.Show("Customer deleted in memory.\nClick 'Update Database' to save changes.",
                                    "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Customer not found!",
                                "Invalid Customer ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
            txtNameOfInstitution.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtPostalCode.Text = "";
            txtTelephone.Text = "";
            txtFax.Text = "";
            txtCreditLimit.Text = "";
            txtCustomerId.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMainMenu = new frmMain();
            frmMainMenu.ShowDialog();
        }


        private void frmSalesManager_Load(object sender, EventArgs e)
        {
          
            dsHiTechDB = new DataSet("HiTechDS");

            dtCustomers = new DataTable("Customers");
            dsHiTechDB.Tables.Add(dtCustomers);

     
            dtCustomers.Columns.Add("CustomerId", typeof(int));
            dtCustomers.Columns.Add("NameOfInstitution", typeof(string));
            dtCustomers.Columns.Add("Street", typeof(string));
            dtCustomers.Columns.Add("City", typeof(string));
            dtCustomers.Columns.Add("PostalCode", typeof(string));
            dtCustomers.Columns.Add("Telephone", typeof(string));
            dtCustomers.Columns.Add("Fax", typeof(string));
            dtCustomers.Columns.Add("CreditLimit", typeof(decimal));

         
            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerId"] };

           
            da = new SqlDataAdapter("SELECT * FROM Customers", UtilityDB.GetDBConnection());

            cmdBuilder = new SqlCommandBuilder(da);

        
            da.Fill(dsHiTechDB.Tables["Customers"]);
            dtCustomers = dsHiTechDB.Tables["Customers"];
        }
    }
}

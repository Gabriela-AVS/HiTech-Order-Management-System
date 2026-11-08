using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Text;
using HiTechOrderManagementSystem.DAL;
using HiTechOrderManagementSystem.EFData;
using HiTechOrderManagementSystem.BLL;
using System.Drawing;
using System.Data.Entity;

namespace HiTechOrderManagementSystem.GUI
{
    public partial class frmOrderClerks : Form
    {
        
        private OrderClerksRepository repo = new OrderClerksRepository();  


        public frmOrderClerks()
        {
            InitializeComponent();
        }

     
        private void frmOrderClerks_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadBooks();
            PrepareOrderDetailsGrid();
            LoadPaymentMethods();
            LoadOrderStatus();
            LoadOrderMethods();



        }
        private void LoadOrderStatus()
        {
            cboOrderStatus.Items.Clear();
            cboOrderStatus.Items.Add("New");
            cboOrderStatus.Items.Add("Pending");
            cboOrderStatus.Items.Add("Canceled");
            cboOrderStatus.SelectedItem = "New";
        }

        private void LoadCustomers()
        {
            var customers = repo.GetAllCustomers();

            cboCustomer.DataSource = customers;
            cboCustomer.DisplayMember = "NameOfInstitution";
            cboCustomer.ValueMember = "CustomerId";

            cboCustomer.SelectedIndex = -1;
            cboCustomer.Text = string.Empty;
        }

        private void LoadBooks()
        {
            var books = repo.GetBooksQuery()
                    .OrderBy(b => b.BookId)
                    .Select(b => new
                    {
                        b.BookId,
                        b.ISBN,
                        b.Booktitle,
                        b.UnitPrice,
                        b.QOH
                    })
                    .ToList();

            dgvBooks.AutoGenerateColumns = true;
            dgvBooks.DataSource = books;
        }

        private void LoadOrderMethods()
        {
            cboOrderMethod.Items.Clear();
            cboOrderMethod.Items.Add("Phone");
            cboOrderMethod.Items.Add("Fax");
            cboOrderMethod.Items.Add("Email");
            cboOrderMethod.SelectedIndex = -1;     
            cboOrderMethod.Text = string.Empty;
        }

        private void PrepareOrderDetailsGrid()
        {
            dgvOrderDetails.Columns.Clear();
            dgvOrderDetails.AutoGenerateColumns = false;
            dgvOrderDetails.AllowUserToAddRows = false;

            dgvOrderDetails.Columns.Add("ISBN", "ISBN");
            dgvOrderDetails.Columns.Add("Title", "Title");
            dgvOrderDetails.Columns.Add("UnitPrice", "Unit Price");
            dgvOrderDetails.Columns.Add("Quantity", "Qty");
            dgvOrderDetails.Columns.Add("LineTotal", "Total");

            dgvOrderDetails.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
            dgvOrderDetails.Columns["LineTotal"].DefaultCellStyle.Format = "C2";
        }

        private void LoadPaymentMethods()
        {
            cboPayment.Items.Clear();
            cboPayment.Items.Add("Direct Withdrawal – RBC");
            cboPayment.Items.Add("Direct Withdrawal – TD");
            cboPayment.Items.Add("Direct Withdrawal – Scotiabank");
            cboPayment.Items.Add("Direct Withdrawal – CIBC");
            cboPayment.Items.Add("Direct Withdrawal – BMO");
            cboPayment.Items.Add("Direct Withdrawal – Desjardins");

            cboPayment.SelectedIndex = -1;
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer.", "HiTech",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasLines = dgvOrderDetails.Rows
                                           .Cast<DataGridViewRow>()
                                           .Any(r => !r.IsNewRow);

            if (!hasLines)
            {
                MessageBox.Show("Please add at least one book to the order.", "HiTech",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = Convert.ToInt32(cboCustomer.SelectedValue);
            DateTime orderDate = dtpOrderDate.Value;

            var order = new Order
            {
                CustomerId = customerId,
                OrderDate = orderDate,
                OrderStatus = "New",
                OrderSource = cboOrderMethod.Text,
                PaymentMethod = cboPayment.Text
            };

            List<OrderDetail> details = new List<OrderDetail>();

            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (row.IsNewRow) continue;

                string isbn = row.Cells["ISBN"].Value.ToString();

                
                var book = repo.GetBooksQuery().SingleOrDefault(b => b.ISBN == isbn);

                if (book == null)
                {
                    MessageBox.Show($"Book with ISBN {isbn} not found.", "HiTech",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal unitPrice = book.UnitPrice;

                details.Add(new OrderDetail
                {
                    BookId = book.BookId,
                    Quantity = quantity,
                    UnitPrice = unitPrice
                });
            }

            decimal total = 0m;
            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["LineTotal"].Value == null) continue;

                total += Convert.ToDecimal(row.Cells["LineTotal"].Value);
            }

            
            try
            {
               
                repo.SaveOrderWithDetails(order, details);

               
                string clerkName = "Order clerk";
                if (order.Employee != null)
                {
                    
                    string first = order.Employee.FirstName;
                    string last = order.Employee.LastName;
                    string full = ((first ?? "") + " " + (last ?? "")).Trim();
                    if (!string.IsNullOrWhiteSpace(full))
                    {
                        clerkName = full;
                    }
                }


                string confirmation =
                            $"Order #{order.OrderId} has been saved successfully.\n\n" +
                            $"Customer ID : {customerId}\n" +
                            $"Order Date  : {orderDate:d}\n" +
                            $"Order Total : {total:C2}\n" +
                            $"Method      : {order.OrderSource}\n" +
                            $"Payment     : {order.PaymentMethod}\n" +
                            $"Clerk       : {clerkName}\n" +
                            "Confirmation email sent to customer";


                MessageBox.Show(confirmation,
                                "Order Confirmation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                
                

                
                if (dgvOrderDetails.DataSource != null)
                {
                    dgvOrderDetails.DataSource = null;
                    PrepareOrderDetailsGrid();
                }
                dgvOrderDetails.Rows.Clear();

                txtTotal.Clear();
                cboCustomer.SelectedIndex = -1;
                cboPayment.SelectedIndex = -1;
                cboOrderMethod.SelectedIndex = 0;
                cboOrderStatus.SelectedIndex = 0;
                dtpOrderDate.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order: " + ex.Message,
                                "HiTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void dgvBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

            string isbn = row.Cells["ISBN"].Value.ToString();
            string title = row.Cells["Booktitle"].Value.ToString();  
            decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

            int qty = 1;  

            AddOrUpdateOrderLine(isbn, title, unitPrice, qty);
        }
        private void dgvOrderDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

           
            if (dgvOrderDetails.Columns[e.ColumnIndex].Name == "Quantity")
            {
                DataGridViewRow row = dgvOrderDetails.Rows[e.RowIndex];

               
                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);

              
                string isbn = row.Cells["ISBN"].Value.ToString();

                
                var book = repo.GetBooksQuery().FirstOrDefault(b => b.ISBN == isbn);

                if (book == null)
                {
                    MessageBox.Show("Book not found in database.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                if (qty > book.QOH)
                {
                    MessageBox.Show(
                        $"Not enough stock for '{book.Booktitle}'. Available: {book.QOH}",
                        "Stock Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    
                    qty = book.QOH;
                    row.Cells["Quantity"].Value = qty;
                }

               
                decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                row.Cells["LineTotal"].Value = qty * unitPrice;

                UpdateOrderTotal();
            }
        }


        private void AddOrUpdateOrderLine(string isbn, string title, decimal unitPrice, int qty)
        {

            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["ISBN"].Value.ToString() == isbn)
                {
                  
                    int currentQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                    int newQty = currentQty + qty;
                    row.Cells["Quantity"].Value = newQty;

                  
                    row.Cells["LineTotal"].Value = newQty * unitPrice;

                    UpdateOrderTotal();
                    return;
                }
            }

           
            decimal lineTotal = qty * unitPrice;

            dgvOrderDetails.Rows.Add(
                isbn,
                title,
                unitPrice,
                qty,
                lineTotal
            );

           
            UpdateOrderTotal();
        }

        private void UpdateOrderTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["LineTotal"].Value == null) continue;

                total += Convert.ToDecimal(row.Cells["LineTotal"].Value);
            }

            txtTotal.Text = total.ToString("C2");
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvOrderDetails.Rows.Clear();
            txtTotal.Clear();
            cboCustomer.SelectedIndex = -1;
            dtpOrderDate.Value = DateTime.Today; ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListOrders_Click(object sender, EventArgs e)
        {
            var orders = repo.GetAllOrders();

            dgvOrderDetails.Columns.Clear();
            dgvOrderDetails.AutoGenerateColumns = true;
            dgvOrderDetails.DataSource = orders;

        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (txtOrderId == null || txtOrderId.Text.Trim() == "")
            {
                MessageBox.Show("Please load an order to cancel.", "HiTech",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId;
            if (!int.TryParse(txtOrderId.Text.Trim(), out orderId))
            {
                MessageBox.Show("Invalid Order ID.", "HiTech",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to cancel order #: " + orderId + " ?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            
            using (HiTechDbEntities3 db = new HiTechDbEntities3())
            {
                Order anOrder = db.Orders.SingleOrDefault(o => o.OrderId == orderId);

                if (anOrder == null)
                {
                    MessageBox.Show("Order not found.", "HiTech",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                anOrder.OrderStatus = "Canceled";   
                db.SaveChanges();
            }

            
            if (dgvOrderDetails.DataSource != null)
            {
                dgvOrderDetails.DataSource = null;
                PrepareOrderDetailsGrid();
            }
            dgvOrderDetails.Rows.Clear();

            txtTotal.Clear();
            cboCustomer.SelectedIndex = -1;
            cboPayment.SelectedIndex = -1;
            cboOrderMethod.SelectedIndex = 0;   
            cboOrderStatus.SelectedIndex = 0;   

            if (txtOrderId != null)
            {
                txtOrderId.Clear();
            }

            dtpOrderDate.Value = DateTime.Today;

            MessageBox.Show("Order cancelled.", "HiTech",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                MessageBox.Show("Please enter an Order ID.", "HiTech",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtOrderId.Text, out int orderId))
            {
                MessageBox.Show("Order ID must be a number.", "HiTech",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (HiTechDbEntities3 db = new HiTechDbEntities3())
            {
                
                var order = db.Orders
                              .Include("OrderDetails.Book")
                              .SingleOrDefault(o => o.OrderId == orderId);

                if (order == null)
                {
                    MessageBox.Show("Order not found.", "HiTech",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                cboCustomer.SelectedValue = order.CustomerId;
                dtpOrderDate.Value = order.OrderDate;
                cboOrderStatus.Text = order.OrderStatus;
                cboPayment.Text = order.PaymentMethod;
                cboOrderMethod.Text = order.OrderSource;

                
                dgvOrderDetails.DataSource = null;    
                dgvOrderDetails.Columns.Clear();       
                PrepareOrderDetailsGrid();             

                dgvOrderDetails.Rows.Clear();

                decimal total = 0;

                foreach (var d in order.OrderDetails)
                {
                    dgvOrderDetails.Rows.Add(
                        d.Book.ISBN,
                        d.Book.Booktitle,
                        d.UnitPrice,
                        d.Quantity,
                        d.UnitPrice * d.Quantity
                    );

                    total += d.UnitPrice * d.Quantity;
                }

                txtTotal.Text = total.ToString("C2");
            }

            MessageBox.Show("Order loaded successfully.", "HiTech",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                MessageBox.Show("Please load an order first.", "HiTech",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = Convert.ToInt32(txtOrderId.Text);

            using (HiTechDbEntities3 db = new HiTechDbEntities3())

            {
                var order = db.Orders.SingleOrDefault(o => o.OrderId == orderId);

                if (order == null)
                {
                    MessageBox.Show("Order not found.", "HiTech",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                order.CustomerId = (int)cboCustomer.SelectedValue;
                order.OrderDate = dtpOrderDate.Value;
                order.OrderStatus = cboOrderStatus.Text;
                order.PaymentMethod = cboPayment.Text; 
                order.OrderSource = cboOrderMethod.Text; 

              
                db.OrderDetails.RemoveRange(order.OrderDetails);

                
                List<OrderDetail> newDetails = new List<OrderDetail>();
                decimal total = 0;

                foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                {
                    if (row.IsNewRow) continue;

                    string isbn = row.Cells["ISBN"].Value.ToString();
                    var book = db.Books.SingleOrDefault(b => b.ISBN == isbn);

                    int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal price = book.UnitPrice;

                    var detail = new OrderDetail
                    {
                        OrderId = order.OrderId,
                        BookId = book.BookId,
                        Quantity = qty,
                        UnitPrice = price
                    };

                    newDetails.Add(detail);

                    total += qty * price;
                }

                
                foreach (var d in newDetails)
                {
                    db.OrderDetails.Add(d);
                }

                db.SaveChanges();
            }

            MessageBox.Show("Order updated successfully!", "HiTech",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}

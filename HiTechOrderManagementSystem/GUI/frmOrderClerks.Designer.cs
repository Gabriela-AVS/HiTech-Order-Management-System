namespace HiTechOrderManagementSystem.GUI
{
    partial class frmOrderClerks
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
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboOrderMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnListOrders = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.grpOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.BackColor = System.Drawing.Color.Silver;
            this.grpOrderInfo.Controls.Add(this.cboPayment);
            this.grpOrderInfo.Controls.Add(this.label7);
            this.grpOrderInfo.Controls.Add(this.dtpOrderDate);
            this.grpOrderInfo.Controls.Add(this.cboOrderStatus);
            this.grpOrderInfo.Controls.Add(this.cboCustomer);
            this.grpOrderInfo.Controls.Add(this.label2);
            this.grpOrderInfo.Controls.Add(this.label8);
            this.grpOrderInfo.Controls.Add(this.label1);
            this.grpOrderInfo.Controls.Add(this.label6);
            this.grpOrderInfo.Controls.Add(this.cboOrderMethod);
            this.grpOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderInfo.Location = new System.Drawing.Point(12, 12);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(1236, 114);
            this.grpOrderInfo.TabIndex = 0;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Info";
            // 
            // cboPayment
            // 
            this.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Location = new System.Drawing.Point(150, 68);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(213, 26);
            this.cboPayment.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Payment :";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(605, 31);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 24);
            this.dtpOrderDate.TabIndex = 4;
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(150, 29);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(213, 26);
            this.cboCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer :";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(15, 229);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(596, 162);
            this.dgvBooks.TabIndex = 1;
            this.dgvBooks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available Books :";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(661, 229);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(587, 162);
            this.dgvOrderDetails.TabIndex = 3;
            this.dgvOrderDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellEndEdit);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(658, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Order Details :";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSaveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Location = new System.Drawing.Point(1116, 414);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(132, 45);
            this.btnSaveOrder.TabIndex = 5;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(954, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 45);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1116, 593);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 45);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Order Total :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(150, 414);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(208, 22);
            this.txtTotal.TabIndex = 9;
            // 
            // cboOrderMethod
            // 
            this.cboOrderMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderMethod.FormattingEnabled = true;
            this.cboOrderMethod.Location = new System.Drawing.Point(605, 68);
            this.cboOrderMethod.Name = "cboOrderMethod";
            this.cboOrderMethod.Size = new System.Drawing.Size(208, 26);
            this.cboOrderMethod.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Order Method :";
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOrder.Location = new System.Drawing.Point(22, 593);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(203, 45);
            this.btnSearchOrder.TabIndex = 12;
            this.btnSearchOrder.Text = "Search Order";
            this.btnSearchOrder.UseVisualStyleBackColor = false;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Location = new System.Drawing.Point(966, 23);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(208, 26);
            this.cboOrderStatus.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(830, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Order Status:";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.Location = new System.Drawing.Point(617, 414);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(140, 45);
            this.btnCancelOrder.TabIndex = 15;
            this.btnCancelOrder.Text = "Cancel";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(796, 414);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 45);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnListOrders
            // 
            this.btnListOrders.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnListOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListOrders.Location = new System.Drawing.Point(1027, 163);
            this.btnListOrders.Name = "btnListOrders";
            this.btnListOrders.Size = new System.Drawing.Size(206, 45);
            this.btnListOrders.TabIndex = 17;
            this.btnListOrders.Text = "List Orders";
            this.btnListOrders.UseVisualStyleBackColor = false;
            this.btnListOrders.Click += new System.EventHandler(this.btnListOrders_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Order Id:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(150, 507);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(208, 22);
            this.txtOrderId.TabIndex = 19;
            // 
            // frmOrderClerks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1260, 660);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.btnListOrders);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.grpOrderInfo);
            this.Name = "frmOrderClerks";
            this.Text = "Order Clerks";
            this.Load += new System.EventHandler(this.frmOrderClerks_Load);
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboOrderMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.ComboBox cboOrderStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.ComboBox cboPayment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnListOrders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrderId;
    }
}
namespace HiTechOrderManagementSystem.GUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mISManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderClerksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mISManagerToolStripMenuItem,
            this.salesManagerToolStripMenuItem,
            this.inventoryControllerToolStripMenuItem,
            this.orderClerksToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // mISManagerToolStripMenuItem
            // 
            this.mISManagerToolStripMenuItem.Name = "mISManagerToolStripMenuItem";
            this.mISManagerToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.mISManagerToolStripMenuItem.Text = "MIS Manager";
            this.mISManagerToolStripMenuItem.Click += new System.EventHandler(this.mISManagerToolStripMenuItem_Click);
            // 
            // salesManagerToolStripMenuItem
            // 
            this.salesManagerToolStripMenuItem.Name = "salesManagerToolStripMenuItem";
            this.salesManagerToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.salesManagerToolStripMenuItem.Text = "Sales Manager";
            this.salesManagerToolStripMenuItem.Click += new System.EventHandler(this.salesManagerToolStripMenuItem_Click);
            // 
            // inventoryControllerToolStripMenuItem
            // 
            this.inventoryControllerToolStripMenuItem.Name = "inventoryControllerToolStripMenuItem";
            this.inventoryControllerToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.inventoryControllerToolStripMenuItem.Text = "Inventory Controller";
            this.inventoryControllerToolStripMenuItem.Click += new System.EventHandler(this.inventoryControllerToolStripMenuItem_Click);
            // 
            // orderClerksToolStripMenuItem
            // 
            this.orderClerksToolStripMenuItem.Name = "orderClerksToolStripMenuItem";
            this.orderClerksToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.orderClerksToolStripMenuItem.Text = "Order Clerks";
            this.orderClerksToolStripMenuItem.Click += new System.EventHandler(this.orderClerksToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.White;
            this.PicLogo.Image = global::HiTechOrderManagementSystem.Properties.Resources.ChatGPT_Image_Nov_20__2025__11_48_38_PM;
            this.PicLogo.Location = new System.Drawing.Point(523, 45);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(256, 167);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Welcome to HiTech";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mISManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryControllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderClerksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox PicLogo;
    }
}
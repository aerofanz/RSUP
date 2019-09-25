namespace Northwind.App
{
    partial class FrmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mnuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmploye = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonitoring = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePasword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManagementAcces = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShipper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMaster,
            this.mnuTransaksi,
            this.mnuMonitoring,
            this.utilityToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1342, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 699);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1342, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mnuMaster
            // 
            this.mnuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomer,
            this.mnuSupplier,
            this.mnuEmploye,
            this.mnuCategory,
            this.mnuProduct,
            this.mnuRegion,
            this.mnuShipper});
            this.mnuMaster.Name = "mnuMaster";
            this.mnuMaster.Size = new System.Drawing.Size(66, 24);
            this.mnuMaster.Text = "Master";
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(216, 26);
            this.mnuCustomer.Text = "Customer";
            // 
            // mnuSupplier
            // 
            this.mnuSupplier.Name = "mnuSupplier";
            this.mnuSupplier.Size = new System.Drawing.Size(216, 26);
            this.mnuSupplier.Text = "Supplier";
            // 
            // mnuEmploye
            // 
            this.mnuEmploye.Name = "mnuEmploye";
            this.mnuEmploye.Size = new System.Drawing.Size(216, 26);
            this.mnuEmploye.Text = "Employee";
            // 
            // mnuTransaksi
            // 
            this.mnuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTransOrder});
            this.mnuTransaksi.Name = "mnuTransaksi";
            this.mnuTransaksi.Size = new System.Drawing.Size(80, 24);
            this.mnuTransaksi.Text = "Transaksi";
            // 
            // mnuMonitoring
            // 
            this.mnuMonitoring.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMonOrder});
            this.mnuMonitoring.Name = "mnuMonitoring";
            this.mnuMonitoring.Size = new System.Drawing.Size(95, 24);
            this.mnuMonitoring.Text = "Monitoring";
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterUser,
            this.mnuChangePasword,
            this.mnuManagementAcces,
            this.mnuLogout});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // mnuRegisterUser
            // 
            this.mnuRegisterUser.Name = "mnuRegisterUser";
            this.mnuRegisterUser.Size = new System.Drawing.Size(216, 26);
            this.mnuRegisterUser.Text = "Register User";
            // 
            // mnuChangePasword
            // 
            this.mnuChangePasword.Name = "mnuChangePasword";
            this.mnuChangePasword.Size = new System.Drawing.Size(216, 26);
            this.mnuChangePasword.Text = "Change Password";
            // 
            // mnuManagementAcces
            // 
            this.mnuManagementAcces.Name = "mnuManagementAcces";
            this.mnuManagementAcces.Size = new System.Drawing.Size(216, 26);
            this.mnuManagementAcces.Text = "Management Acces";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(216, 26);
            this.mnuLogout.Text = "Log Out";
            // 
            // mnuCategory
            // 
            this.mnuCategory.Name = "mnuCategory";
            this.mnuCategory.Size = new System.Drawing.Size(216, 26);
            this.mnuCategory.Text = "Category";
            // 
            // mnuProduct
            // 
            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Size = new System.Drawing.Size(216, 26);
            this.mnuProduct.Text = "Product";
            // 
            // mnuRegion
            // 
            this.mnuRegion.Name = "mnuRegion";
            this.mnuRegion.Size = new System.Drawing.Size(216, 26);
            this.mnuRegion.Text = "Region";
            // 
            // mnuShipper
            // 
            this.mnuShipper.Name = "mnuShipper";
            this.mnuShipper.Size = new System.Drawing.Size(216, 26);
            this.mnuShipper.Text = "Shipper";
            // 
            // mnuTransOrder
            // 
            this.mnuTransOrder.Name = "mnuTransOrder";
            this.mnuTransOrder.Size = new System.Drawing.Size(216, 26);
            this.mnuTransOrder.Text = "Order";
            // 
            // mnuMonOrder
            // 
            this.mnuMonOrder.Name = "mnuMonOrder";
            this.mnuMonOrder.Size = new System.Drawing.Size(216, 26);
            this.mnuMonOrder.Text = "Order";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 724);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuMaster;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuEmploye;
        private System.Windows.Forms.ToolStripMenuItem mnuCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuRegion;
        private System.Windows.Forms.ToolStripMenuItem mnuShipper;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaksi;
        private System.Windows.Forms.ToolStripMenuItem mnuTransOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuMonitoring;
        private System.Windows.Forms.ToolStripMenuItem mnuMonOrder;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterUser;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePasword;
        private System.Windows.Forms.ToolStripMenuItem mnuManagementAcces;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
    }
}




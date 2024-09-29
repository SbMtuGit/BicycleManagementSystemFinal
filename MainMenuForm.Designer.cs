namespace BicycleManagementSystem
{
    partial class mnuMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnuMainMenu));
            this.mnuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.setMnuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBicycleMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnuinventory = new System.Windows.Forms.ToolStripMenuItem();
            this.addBiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBicMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBicycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBookingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBookingMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBookingMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaylToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.mnuStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStripMainMenu
            // 
            this.mnuStripMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setMnuitem,
            this.Mnuinventory,
            this.MnuBookingItem,
            this.anaylToolStripMenuItem});
            this.mnuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuStripMainMenu.Name = "mnuStripMainMenu";
            this.mnuStripMainMenu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuStripMainMenu.Size = new System.Drawing.Size(942, 30);
            this.mnuStripMainMenu.TabIndex = 0;
            // 
            // setMnuitem
            // 
            this.setMnuitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setBicycleMnu,
            this.UpdateMnuItem,
            this.RemoveMnuItem});
            this.setMnuitem.Name = "setMnuitem";
            this.setMnuitem.Size = new System.Drawing.Size(44, 24);
            this.setMnuitem.Text = "&Set";
            // 
            // setBicycleMnu
            // 
            this.setBicycleMnu.Name = "setBicycleMnu";
            this.setBicycleMnu.Size = new System.Drawing.Size(233, 26);
            this.setBicycleMnu.Text = "&Set Bicycle-Type";
            this.setBicycleMnu.Click += new System.EventHandler(this.setBicycleMnu_Click_1);
            // 
            // UpdateMnuItem
            // 
            this.UpdateMnuItem.Name = "UpdateMnuItem";
            this.UpdateMnuItem.Size = new System.Drawing.Size(233, 26);
            this.UpdateMnuItem.Text = "&Update Bicycle-Type";
            this.UpdateMnuItem.Click += new System.EventHandler(this.UpdateMnuItem_Click);
            // 
            // RemoveMnuItem
            // 
            this.RemoveMnuItem.Name = "RemoveMnuItem";
            this.RemoveMnuItem.Size = new System.Drawing.Size(233, 26);
            this.RemoveMnuItem.Text = "&Remove Bicycle-Type";
            this.RemoveMnuItem.Click += new System.EventHandler(this.RemoveMnuItem_Click);
            // 
            // Mnuinventory
            // 
            this.Mnuinventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBiMenuItem,
            this.updateBicMnuItem,
            this.removeBicycleToolStripMenuItem});
            this.Mnuinventory.Name = "Mnuinventory";
            this.Mnuinventory.Size = new System.Drawing.Size(84, 24);
            this.Mnuinventory.Text = "Inventory";
            // 
            // addBiMenuItem
            // 
            this.addBiMenuItem.Name = "addBiMenuItem";
            this.addBiMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addBiMenuItem.Text = "Add Bicycle";
            this.addBiMenuItem.Click += new System.EventHandler(this.addBiMenuItem_Click_1);
            // 
            // updateBicMnuItem
            // 
            this.updateBicMnuItem.Name = "updateBicMnuItem";
            this.updateBicMnuItem.Size = new System.Drawing.Size(224, 26);
            this.updateBicMnuItem.Text = "&Update Bicycle";
            this.updateBicMnuItem.Click += new System.EventHandler(this.updateBicMnuItem_Click);
            // 
            // removeBicycleToolStripMenuItem
            // 
            this.removeBicycleToolStripMenuItem.Name = "removeBicycleToolStripMenuItem";
            this.removeBicycleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeBicycleToolStripMenuItem.Text = "&Remove Bicycle";
            this.removeBicycleToolStripMenuItem.Click += new System.EventHandler(this.removeBicycleToolStripMenuItem_Click_1);
            // 
            // MnuBookingItem
            // 
            this.MnuBookingItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBookingMnuItem,
            this.cancelBookingMnuItem,
            this.collectBookingToolStripMenuItem,
            this.returnBookingToolStripMenuItem});
            this.MnuBookingItem.Name = "MnuBookingItem";
            this.MnuBookingItem.Size = new System.Drawing.Size(78, 24);
            this.MnuBookingItem.Text = "&Booking";
            // 
            // makeBookingMnuItem
            // 
            this.makeBookingMnuItem.Name = "makeBookingMnuItem";
            this.makeBookingMnuItem.Size = new System.Drawing.Size(224, 26);
            this.makeBookingMnuItem.Text = "&Make Booking";
            this.makeBookingMnuItem.Click += new System.EventHandler(this.makeBookingMnuItem_Click);
            // 
            // cancelBookingMnuItem
            // 
            this.cancelBookingMnuItem.Name = "cancelBookingMnuItem";
            this.cancelBookingMnuItem.Size = new System.Drawing.Size(224, 26);
            this.cancelBookingMnuItem.Text = "&Cancel Booking";
            this.cancelBookingMnuItem.Click += new System.EventHandler(this.cancelBookingMnuItem_Click);
            // 
            // collectBookingToolStripMenuItem
            // 
            this.collectBookingToolStripMenuItem.Name = "collectBookingToolStripMenuItem";
            this.collectBookingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.collectBookingToolStripMenuItem.Text = "&Collect Booking";
            this.collectBookingToolStripMenuItem.Click += new System.EventHandler(this.collectBookingToolStripMenuItem_Click);
            // 
            // returnBookingToolStripMenuItem
            // 
            this.returnBookingToolStripMenuItem.Name = "returnBookingToolStripMenuItem";
            this.returnBookingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.returnBookingToolStripMenuItem.Text = "&Return Booking";
            this.returnBookingToolStripMenuItem.Click += new System.EventHandler(this.returnBookingToolStripMenuItem_Click);
            // 
            // anaylToolStripMenuItem
            // 
            this.anaylToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueReportToolStripMenuItem});
            this.anaylToolStripMenuItem.Name = "anaylToolStripMenuItem";
            this.anaylToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.anaylToolStripMenuItem.Text = "&Analytics";
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.revenueReportToolStripMenuItem.Text = "&Revenue Report";
            this.revenueReportToolStripMenuItem.Click += new System.EventHandler(this.revenueReportToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bicycle Rental Management System";
            // 
            // picMainMenu
            // 
            this.picMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMainMenu.Image")));
            this.picMainMenu.Location = new System.Drawing.Point(288, 195);
            this.picMainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(305, 167);
            this.picMainMenu.TabIndex = 2;
            this.picMainMenu.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(222, 370);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(426, 31);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click_1);
            // 
            // mnuMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 553);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.picMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuStripMainMenu);
            this.MainMenuStrip = this.mnuStripMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mnuMainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.mnuMainMenu_Load);
            this.mnuStripMainMenu.ResumeLayout(false);
            this.mnuStripMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuStripMainMenu;
        private Label label1;
        private PictureBox picMainMenu;
        private Button btnEnter;
        private ToolStripMenuItem setMnuitem;
        private ToolStripMenuItem setBicycleMnu;
        private ToolStripMenuItem Mnuinventory;
        private ToolStripMenuItem addBiMenuItem;
        private ToolStripMenuItem MnuBookingItem;
        private ToolStripMenuItem UpdateMnuItem;
        private ToolStripMenuItem RemoveMnuItem;
        private ToolStripMenuItem updateBicMnuItem;
        private ToolStripMenuItem anaylToolStripMenuItem;
        private ToolStripMenuItem cancelBookingMnuItem;
        private ToolStripMenuItem makeBookingMnuItem;
        private ToolStripMenuItem revenueReportToolStripMenuItem;
        private ToolStripMenuItem removeBicycleToolStripMenuItem;
        private ToolStripMenuItem collectBookingToolStripMenuItem;
        private ToolStripMenuItem returnBookingToolStripMenuItem;
    }
}
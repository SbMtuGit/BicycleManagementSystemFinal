namespace BicycleManagementSystem
{
    partial class FrmCancelBooking
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
            this.fileMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bckMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxBicycleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dGvBookings = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMnuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMnuItem
            // 
            this.fileMnuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bckMnuItem});
            this.fileMnuItem.Name = "fileMnuItem";
            this.fileMnuItem.Size = new System.Drawing.Size(46, 24);
            this.fileMnuItem.Text = "&File";
            // 
            // bckMnuItem
            // 
            this.bckMnuItem.Name = "bckMnuItem";
            this.bckMnuItem.Size = new System.Drawing.Size(123, 26);
            this.bckMnuItem.Text = "&Back";
            this.bckMnuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtBoxBicycleID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBookingID);
            this.groupBox1.Location = new System.Drawing.Point(0, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CancelBooking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please enter your Booking ID to cancel your booking";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(229, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxBicycleID
            // 
            this.txtBoxBicycleID.Location = new System.Drawing.Point(69, 58);
            this.txtBoxBicycleID.Name = "txtBoxBicycleID";
            this.txtBoxBicycleID.Size = new System.Drawing.Size(125, 27);
            this.txtBoxBicycleID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(0, 120);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(77, 20);
            this.lblBookingID.TabIndex = 0;
            this.lblBookingID.Text = "BookingId";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(0, 398);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dGvBookings
            // 
            this.dGvBookings.AllowUserToAddRows = false;
            this.dGvBookings.AllowUserToDeleteRows = false;
            this.dGvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvBookings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvBookings.Location = new System.Drawing.Point(0, 194);
            this.dGvBookings.Name = "dGvBookings";
            this.dGvBookings.RowHeadersWidth = 51;
            this.dGvBookings.RowTemplate.Height = 29;
            this.dGvBookings.Size = new System.Drawing.Size(744, 188);
            this.dGvBookings.TabIndex = 3;
            // 
            // FrmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.dGvBookings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSubmit);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCancelBooking";
            this.Text = "FrmCancelBooking";
            this.Load += new System.EventHandler(this.FrmCancelBooking_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMnuItem;
        private ToolStripMenuItem bckMnuItem;
        private GroupBox groupBox1;
        private TextBox txtBoxBicycleID;
        private Label lblBookingID;
        private Button btnSearch;
        private Label label1;
        private Button btnSubmit;
        private DataGridView dGvBookings;
        private Label label2;
    }
}
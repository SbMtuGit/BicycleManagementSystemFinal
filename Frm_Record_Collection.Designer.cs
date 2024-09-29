namespace BicycleManagementSystem
{
    partial class Frm_Record_Collection
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
            this.GrpBxRecordCollection = new System.Windows.Forms.GroupBox();
            this.TxtBookingId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMessageBookingId = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtTelePhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvBookingInfo = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnFrgBookingID = new System.Windows.Forms.Button();
            this.LblTelephoneNumber = new System.Windows.Forms.Label();
            this.LblSecondName = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.Confirmation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCollect = new System.Windows.Forms.Button();
            this.GrpBxRecordCollection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookingInfo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Confirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBxRecordCollection
            // 
            this.GrpBxRecordCollection.Controls.Add(this.TxtBookingId);
            this.GrpBxRecordCollection.Controls.Add(this.btnSearch);
            this.GrpBxRecordCollection.Controls.Add(this.lblMessageBookingId);
            this.GrpBxRecordCollection.Location = new System.Drawing.Point(0, 27);
            this.GrpBxRecordCollection.Name = "GrpBxRecordCollection";
            this.GrpBxRecordCollection.Size = new System.Drawing.Size(530, 110);
            this.GrpBxRecordCollection.TabIndex = 1;
            this.GrpBxRecordCollection.TabStop = false;
            this.GrpBxRecordCollection.Text = "Collections";
            // 
            // TxtBookingId
            // 
            this.TxtBookingId.Location = new System.Drawing.Point(399, 42);
            this.TxtBookingId.Name = "TxtBookingId";
            this.TxtBookingId.Size = new System.Drawing.Size(125, 27);
            this.TxtBookingId.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(430, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMessageBookingId
            // 
            this.lblMessageBookingId.AutoSize = true;
            this.lblMessageBookingId.Location = new System.Drawing.Point(12, 42);
            this.lblMessageBookingId.Name = "lblMessageBookingId";
            this.lblMessageBookingId.Size = new System.Drawing.Size(367, 20);
            this.lblMessageBookingId.TabIndex = 0;
            this.lblMessageBookingId.Text = "Please enter your BookingId to Record your Collection";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(146, 98);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(125, 27);
            this.TxtLastName.TabIndex = 1;
            // 
            // TxtTelePhoneNumber
            // 
            this.TxtTelePhoneNumber.Location = new System.Drawing.Point(146, 136);
            this.TxtTelePhoneNumber.Name = "TxtTelePhoneNumber";
            this.TxtTelePhoneNumber.Size = new System.Drawing.Size(125, 27);
            this.TxtTelePhoneNumber.TabIndex = 1;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(146, 63);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(125, 27);
            this.TxtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "If you cannont remeber your Booking ID please enter your\r\nFirst name, Second name" +
    ", Telephone number below to find your Booking.";
            // 
            // DgvBookingInfo
            // 
            this.DgvBookingInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookingInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DgvBookingInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookingInfo.Location = new System.Drawing.Point(533, 27);
            this.DgvBookingInfo.Name = "DgvBookingInfo";
            this.DgvBookingInfo.RowHeadersWidth = 51;
            this.DgvBookingInfo.RowTemplate.Height = 29;
            this.DgvBookingInfo.Size = new System.Drawing.Size(677, 123);
            this.DgvBookingInfo.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1288, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFrgBookingID);
            this.groupBox1.Controls.Add(this.LblTelephoneNumber);
            this.groupBox1.Controls.Add(this.LblSecondName);
            this.groupBox1.Controls.Add(this.LblFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtFirstName);
            this.groupBox1.Controls.Add(this.TxtTelePhoneNumber);
            this.groupBox1.Controls.Add(this.TxtLastName);
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 223);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnFrgBookingID
            // 
            this.BtnFrgBookingID.Location = new System.Drawing.Point(146, 169);
            this.BtnFrgBookingID.Name = "BtnFrgBookingID";
            this.BtnFrgBookingID.Size = new System.Drawing.Size(94, 29);
            this.BtnFrgBookingID.TabIndex = 5;
            this.BtnFrgBookingID.Text = "Search";
            this.BtnFrgBookingID.UseVisualStyleBackColor = true;
            this.BtnFrgBookingID.Click += new System.EventHandler(this.BtnFrgBookingID_Click);
            // 
            // LblTelephoneNumber
            // 
            this.LblTelephoneNumber.AutoSize = true;
            this.LblTelephoneNumber.Location = new System.Drawing.Point(8, 143);
            this.LblTelephoneNumber.Name = "LblTelephoneNumber";
            this.LblTelephoneNumber.Size = new System.Drawing.Size(132, 20);
            this.LblTelephoneNumber.TabIndex = 4;
            this.LblTelephoneNumber.Text = "TelephoneNumber";
            // 
            // LblSecondName
            // 
            this.LblSecondName.AutoSize = true;
            this.LblSecondName.Location = new System.Drawing.Point(38, 101);
            this.LblSecondName.Name = "LblSecondName";
            this.LblSecondName.Size = new System.Drawing.Size(102, 20);
            this.LblSecondName.TabIndex = 3;
            this.LblSecondName.Text = "Second Name";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(38, 70);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(77, 20);
            this.LblFirstName.TabIndex = 2;
            this.LblFirstName.Text = "First name";
            // 
            // Confirmation
            // 
            this.Confirmation.Controls.Add(this.label1);
            this.Confirmation.Controls.Add(this.BtnCollect);
            this.Confirmation.Location = new System.Drawing.Point(523, 156);
            this.Confirmation.Name = "Confirmation";
            this.Confirmation.Size = new System.Drawing.Size(291, 210);
            this.Confirmation.TabIndex = 5;
            this.Confirmation.TabStop = false;
            this.Confirmation.Text = "Confirmation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click here to Confirm YourCollection";
            // 
            // BtnCollect
            // 
            this.BtnCollect.Location = new System.Drawing.Point(17, 79);
            this.BtnCollect.Name = "BtnCollect";
            this.BtnCollect.Size = new System.Drawing.Size(155, 29);
            this.BtnCollect.TabIndex = 0;
            this.BtnCollect.Text = "Collect Booking";
            this.BtnCollect.UseVisualStyleBackColor = true;
            this.BtnCollect.Click += new System.EventHandler(this.BtnCollect_Click);
            // 
            // Frm_Record_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 617);
            this.Controls.Add(this.Confirmation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvBookingInfo);
            this.Controls.Add(this.GrpBxRecordCollection);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_Record_Collection";
            this.Text = "Frm_Record_Collection";
            this.GrpBxRecordCollection.ResumeLayout(false);
            this.GrpBxRecordCollection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookingInfo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Confirmation.ResumeLayout(false);
            this.Confirmation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox GrpBxRecordCollection;
        private TextBox TxtLastName;
        private TextBox TxtTelePhoneNumber;
        private TextBox TxtFirstName;
        private TextBox TxtBookingId;
        private Label label2;
        private Label lblMessageBookingId;
        private Button btnSearch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private GroupBox groupBox1;
        private Label LblTelephoneNumber;
        private Label LblSecondName;
        private Label LblFirstName;
        private Button BtnFrgBookingID;
        private GroupBox Confirmation;
        private Label label1;
        private Button BtnCollect;
        public DataGridView DgvBookingInfo;
    }
}
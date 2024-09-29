namespace BicycleManagementSystem
{
    partial class FrmRevenueReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmBxMonths = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGvRevenue = new System.Windows.Forms.DataGridView();
            this.btnMonth = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.YearGrpBx = new System.Windows.Forms.GroupBox();
            this.cmbBxYear = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblMonthSelect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuBtnBackRevnue = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGvRevenue)).BeginInit();
            this.YearGrpBx.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.backToolStripMenuItem.Text = "&Back";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmBxMonths);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Revenue report";
            // 
            // cmBxMonths
            // 
            this.cmBxMonths.FormattingEnabled = true;
            this.cmBxMonths.Location = new System.Drawing.Point(2, 69);
            this.cmBxMonths.Name = "cmBxMonths";
            this.cmBxMonths.Size = new System.Drawing.Size(151, 28);
            this.cmBxMonths.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please select the month to get the \r\nmonthly revenue";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(10, 198);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLease select from the following options ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(348, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 218);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DGvRevenue
            // 
            this.DGvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGvRevenue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGvRevenue.Location = new System.Drawing.Point(360, 25);
            this.DGvRevenue.Name = "DGvRevenue";
            this.DGvRevenue.RowHeadersWidth = 51;
            this.DGvRevenue.RowTemplate.Height = 29;
            this.DGvRevenue.Size = new System.Drawing.Size(534, 188);
            this.DGvRevenue.TabIndex = 0;
            this.DGvRevenue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGvRevenue_CellContentClick);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(164, 25);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(118, 29);
            this.btnMonth.TabIndex = 1;
            this.btnMonth.Text = "Submit";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YearGrpBx
            // 
            this.YearGrpBx.Controls.Add(this.label3);
            this.YearGrpBx.Controls.Add(this.cmbBxYear);
            this.YearGrpBx.Controls.Add(this.button2);
            this.YearGrpBx.Location = new System.Drawing.Point(8, 145);
            this.YearGrpBx.Name = "YearGrpBx";
            this.YearGrpBx.Size = new System.Drawing.Size(312, 151);
            this.YearGrpBx.TabIndex = 5;
            this.YearGrpBx.TabStop = false;
            this.YearGrpBx.Text = "Year";
            // 
            // cmbBxYear
            // 
            this.cmbBxYear.FormattingEnabled = true;
            this.cmbBxYear.Location = new System.Drawing.Point(0, 26);
            this.cmbBxYear.Name = "cmbBxYear";
            this.cmbBxYear.Size = new System.Drawing.Size(182, 28);
            this.cmbBxYear.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.btnMonth);
            this.groupBox3.Location = new System.Drawing.Point(8, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Month";
            // 
            // LblMonthSelect
            // 
            this.LblMonthSelect.AutoSize = true;
            this.LblMonthSelect.Location = new System.Drawing.Point(12, 25);
            this.LblMonthSelect.Name = "LblMonthSelect";
            this.LblMonthSelect.Size = new System.Drawing.Size(238, 20);
            this.LblMonthSelect.TabIndex = 7;
            this.LblMonthSelect.Text = "Please select the Month to analysis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "If you Would Like yearly analysis\r\n please select the year here.";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBtnBackRevnue});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(930, 28);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuBtnBackRevnue
            // 
            this.mnuBtnBackRevnue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem1});
            this.mnuBtnBackRevnue.Name = "mnuBtnBackRevnue";
            this.mnuBtnBackRevnue.Size = new System.Drawing.Size(46, 24);
            this.mnuBtnBackRevnue.Text = "&File";
            // 
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(123, 26);
            this.backToolStripMenuItem1.Text = "Back";
            this.backToolStripMenuItem1.Click += new System.EventHandler(this.backToolStripMenuItem1_Click);
            // 
            // FrmRevenueReport
            // 
            this.ClientSize = new System.Drawing.Size(930, 492);
            this.Controls.Add(this.LblMonthSelect);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.YearGrpBx);
            this.Controls.Add(this.DGvRevenue);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "FrmRevenueReport";
            this.Load += new System.EventHandler(this.FrmRevenueReport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGvRevenue)).EndInit();
            this.YearGrpBx.ResumeLayout(false);
            this.YearGrpBx.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSubmit;
       
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private Label label2;
        private ComboBox cmBxMonths;
        private DataGridView DGvRevenue;
        private Button btnMonth;
        private ComboBox comboBox1;
        private Button button2;
        private GroupBox YearGrpBx;
        private GroupBox groupBox3;
        private Label LblMonthSelect;
        private ComboBox cmbBxYear;
        private Label label3;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem mnuBtnBackRevnue;
        private ToolStripMenuItem backToolStripMenuItem1;
    }
}
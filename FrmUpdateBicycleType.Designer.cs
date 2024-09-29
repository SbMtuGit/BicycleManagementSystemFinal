namespace BicycleManagementSystem
{
    partial class FrmUpdateBicycleType
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBicycleType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.txtDesription = new System.Windows.Forms.TextBox();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DgGrdUpdate = new System.Windows.Forms.DataGridView();
            this.lblBtypeCode = new System.Windows.Forms.Label();
            this.cmbBxTypeCode = new System.Windows.Forms.ComboBox();
            this.frmSetBicycleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtBicycleType = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.grpBxTypeCode = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgGrdUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmSetBicycleTypeBindingSource)).BeginInit();
            this.grpBxTypeCode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1010, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
            // 
            // lblBicycleType
            // 
            this.lblBicycleType.AutoSize = true;
            this.lblBicycleType.Location = new System.Drawing.Point(7, 23);
            this.lblBicycleType.Name = "lblBicycleType";
            this.lblBicycleType.Size = new System.Drawing.Size(86, 20);
            this.lblBicycleType.TabIndex = 1;
            this.lblBicycleType.Text = "BicycleType";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblDailyRate
            // 
            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.Location = new System.Drawing.Point(7, 138);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(77, 20);
            this.lblDailyRate.TabIndex = 1;
            this.lblDailyRate.Text = "Daily Rate";
            // 
            // txtDesription
            // 
            this.txtDesription.Location = new System.Drawing.Point(97, 56);
            this.txtDesription.Multiline = true;
            this.txtDesription.Name = "txtDesription";
            this.txtDesription.Size = new System.Drawing.Size(261, 68);
            this.txtDesription.TabIndex = 2;
            // 
            // txtDailyRate
            // 
            this.txtDailyRate.Location = new System.Drawing.Point(97, 130);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(156, 27);
            this.txtDailyRate.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(0, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DgGrdUpdate
            // 
            this.DgGrdUpdate.AllowUserToAddRows = false;
            this.DgGrdUpdate.AllowUserToDeleteRows = false;
            this.DgGrdUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgGrdUpdate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgGrdUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgGrdUpdate.Location = new System.Drawing.Point(0, 327);
            this.DgGrdUpdate.Name = "DgGrdUpdate";
            this.DgGrdUpdate.RowHeadersWidth = 51;
            this.DgGrdUpdate.RowTemplate.Height = 29;
            this.DgGrdUpdate.Size = new System.Drawing.Size(998, 237);
            this.DgGrdUpdate.TabIndex = 5;
            // 
            // lblBtypeCode
            // 
            this.lblBtypeCode.AutoSize = true;
            this.lblBtypeCode.Location = new System.Drawing.Point(7, 99);
            this.lblBtypeCode.Name = "lblBtypeCode";
            this.lblBtypeCode.Size = new System.Drawing.Size(75, 20);
            this.lblBtypeCode.TabIndex = 6;
            this.lblBtypeCode.Text = "TypeCode";
            // 
            // cmbBxTypeCode
            // 
            this.cmbBxTypeCode.DataSource = this.frmSetBicycleTypeBindingSource;
            this.cmbBxTypeCode.FormattingEnabled = true;
            this.cmbBxTypeCode.Location = new System.Drawing.Point(128, 96);
            this.cmbBxTypeCode.Name = "cmbBxTypeCode";
            this.cmbBxTypeCode.Size = new System.Drawing.Size(151, 28);
            this.cmbBxTypeCode.TabIndex = 7;
            // 
            // frmSetBicycleTypeBindingSource
            // 
            this.frmSetBicycleTypeBindingSource.DataSource = typeof(BicycleManagementSystem.frmSetBicycleType);
            // 
            // TxtBicycleType
            // 
            this.TxtBicycleType.Location = new System.Drawing.Point(97, 20);
            this.TxtBicycleType.Name = "TxtBicycleType";
            this.TxtBicycleType.Size = new System.Drawing.Size(150, 27);
            this.TxtBicycleType.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 213);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(7, 176);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(49, 20);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "Status";
            // 
            // grpBxTypeCode
            // 
            this.grpBxTypeCode.Controls.Add(this.label1);
            this.grpBxTypeCode.Controls.Add(this.lblBtypeCode);
            this.grpBxTypeCode.Controls.Add(this.cmbBxTypeCode);
            this.grpBxTypeCode.Controls.Add(this.btnSearch);
            this.grpBxTypeCode.Location = new System.Drawing.Point(72, 75);
            this.grpBxTypeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBxTypeCode.Name = "grpBxTypeCode";
            this.grpBxTypeCode.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBxTypeCode.Size = new System.Drawing.Size(312, 245);
            this.grpBxTypeCode.TabIndex = 10;
            this.grpBxTypeCode.TabStop = false;
            this.grpBxTypeCode.Text = "Search by code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select the TypeCode \r\nhere to Update \r\nthe Bicycle Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbStatus);
            this.groupBox1.Controls.Add(this.lblBicycleType);
            this.groupBox1.Controls.Add(this.TxtBicycleType);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtDesription);
            this.groupBox1.Controls.Add(this.lblDailyRate);
            this.groupBox1.Controls.Add(this.LblStatus);
            this.groupBox1.Controls.Add(this.txtDailyRate);
            this.groupBox1.Location = new System.Drawing.Point(390, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 245);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update here";
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Location = new System.Drawing.Point(97, 176);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(151, 28);
            this.CmbStatus.TabIndex = 10;
            // 
            // FrmUpdateBicycleType
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBxTypeCode);
            this.Controls.Add(this.DgGrdUpdate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUpdateBicycleType";
            this.Text = "Update Bicycle Type";
            this.Load += new System.EventHandler(this.FrmUpdateBicycleType_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgGrdUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmSetBicycleTypeBindingSource)).EndInit();
            this.grpBxTypeCode.ResumeLayout(false);
            this.grpBxTypeCode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private Label lblBicycleType;
        private Label lblDescription;
        private Label lblDailyRate;
        private TextBox txtDesription;
        private TextBox txtDailyRate;
        private Button btnSearch;
        private DataGridView DgGrdUpdate;
        private Label lblBtypeCode;
        private ComboBox cmbBxTypeCode;
        private BindingSource frmSetBicycleTypeBindingSource;
        private TextBox TxtBicycleType;
        private Button btnUpdate;
        private Label LblStatus;
        private GroupBox grpBxTypeCode;
        private GroupBox groupBox1;
        private ComboBox CmbStatus;
        private Label label1;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}
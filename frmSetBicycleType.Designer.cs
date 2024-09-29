namespace BicycleManagementSystem
{
    partial class frmSetBicycleType
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
            this.mnuSetBicycles = new System.Windows.Forms.MenuStrip();
            this.MnuSetBicycleTypeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.LblBicycleType = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblDailyRate = new System.Windows.Forms.Label();
            this.TxtBicycleType = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtDailyRate = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.grpBxBicycleType = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTypeCode = new System.Windows.Forms.TextBox();
            this.cmBxTypeStatus = new System.Windows.Forms.ComboBox();
            this.LblTypeCode = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SetBicycleGrid = new System.Windows.Forms.DataGridView();
            this.mnuSetBicycles.SuspendLayout();
            this.grpBxBicycleType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetBicycleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuSetBicycles
            // 
            this.mnuSetBicycles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuSetBicycles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSetBicycleTypeFile});
            this.mnuSetBicycles.Location = new System.Drawing.Point(0, 0);
            this.mnuSetBicycles.Name = "mnuSetBicycles";
            this.mnuSetBicycles.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuSetBicycles.Size = new System.Drawing.Size(1171, 30);
            this.mnuSetBicycles.TabIndex = 0;
            this.mnuSetBicycles.Text = "menuStrip1";
            // 
            // MnuSetBicycleTypeFile
            // 
            this.MnuSetBicycleTypeFile.Name = "MnuSetBicycleTypeFile";
            this.MnuSetBicycleTypeFile.Size = new System.Drawing.Size(54, 24);
            this.MnuSetBicycleTypeFile.Text = "Back";
            this.MnuSetBicycleTypeFile.Click += new System.EventHandler(this.MnuSetBicycleTypeFile_Click);
            // 
            // LblBicycleType
            // 
            this.LblBicycleType.AutoSize = true;
            this.LblBicycleType.Location = new System.Drawing.Point(1, 168);
            this.LblBicycleType.Name = "LblBicycleType";
            this.LblBicycleType.Size = new System.Drawing.Size(86, 20);
            this.LblBicycleType.TabIndex = 1;
            this.LblBicycleType.Text = "BicycleType";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(2, 211);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(85, 20);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "Description";
            // 
            // LblDailyRate
            // 
            this.LblDailyRate.AutoSize = true;
            this.LblDailyRate.Location = new System.Drawing.Point(0, 280);
            this.LblDailyRate.Name = "LblDailyRate";
            this.LblDailyRate.Size = new System.Drawing.Size(73, 20);
            this.LblDailyRate.TabIndex = 1;
            this.LblDailyRate.Text = "DailyRate";
            // 
            // TxtBicycleType
            // 
            this.TxtBicycleType.Location = new System.Drawing.Point(115, 161);
            this.TxtBicycleType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBicycleType.Name = "TxtBicycleType";
            this.TxtBicycleType.Size = new System.Drawing.Size(192, 27);
            this.TxtBicycleType.TabIndex = 2;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(115, 211);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(192, 48);
            this.TxtDescription.TabIndex = 3;
            // 
            // TxtDailyRate
            // 
            this.TxtDailyRate.Location = new System.Drawing.Point(115, 280);
            this.TxtDailyRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDailyRate.Name = "TxtDailyRate";
            this.TxtDailyRate.Size = new System.Drawing.Size(114, 27);
            this.TxtDailyRate.TabIndex = 4;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(6, 386);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(198, 31);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Submit";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // grpBxBicycleType
            // 
            this.grpBxBicycleType.Controls.Add(this.label1);
            this.grpBxBicycleType.Controls.Add(this.TxtTypeCode);
            this.grpBxBicycleType.Controls.Add(this.cmBxTypeStatus);
            this.grpBxBicycleType.Controls.Add(this.LblTypeCode);
            this.grpBxBicycleType.Controls.Add(this.lblStatus);
            this.grpBxBicycleType.Controls.Add(this.TxtBicycleType);
            this.grpBxBicycleType.Controls.Add(this.LblBicycleType);
            this.grpBxBicycleType.Controls.Add(this.BtnSave);
            this.grpBxBicycleType.Controls.Add(this.TxtDescription);
            this.grpBxBicycleType.Controls.Add(this.LblDailyRate);
            this.grpBxBicycleType.Controls.Add(this.TxtDailyRate);
            this.grpBxBicycleType.Controls.Add(this.LblDescription);
            this.grpBxBicycleType.Location = new System.Drawing.Point(11, 33);
            this.grpBxBicycleType.Name = "grpBxBicycleType";
            this.grpBxBicycleType.Size = new System.Drawing.Size(365, 463);
            this.grpBxBicycleType.TabIndex = 7;
            this.grpBxBicycleType.TabStop = false;
            this.grpBxBicycleType.Text = "BicycleType ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 60);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please enter the details\r\n of the bicycle type\r\n you would like to Add.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTypeCode
            // 
            this.TxtTypeCode.Location = new System.Drawing.Point(115, 127);
            this.TxtTypeCode.Name = "TxtTypeCode";
            this.TxtTypeCode.ReadOnly = true;
            this.TxtTypeCode.Size = new System.Drawing.Size(125, 27);
            this.TxtTypeCode.TabIndex = 11;
            // 
            // cmBxTypeStatus
            // 
            this.cmBxTypeStatus.AllowDrop = true;
            this.cmBxTypeStatus.FormattingEnabled = true;
            this.cmBxTypeStatus.Location = new System.Drawing.Point(115, 332);
            this.cmBxTypeStatus.Name = "cmBxTypeStatus";
            this.cmBxTypeStatus.Size = new System.Drawing.Size(114, 28);
            this.cmBxTypeStatus.TabIndex = 10;
            // 
            // LblTypeCode
            // 
            this.LblTypeCode.AutoSize = true;
            this.LblTypeCode.Location = new System.Drawing.Point(6, 134);
            this.LblTypeCode.Name = "LblTypeCode";
            this.LblTypeCode.Size = new System.Drawing.Size(94, 20);
            this.LblTypeCode.TabIndex = 8;
            this.LblTypeCode.Text = "TxtTypeCode";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1, 340);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // SetBicycleGrid
            // 
            this.SetBicycleGrid.AllowUserToAddRows = false;
            this.SetBicycleGrid.AllowUserToDeleteRows = false;
            this.SetBicycleGrid.AllowUserToOrderColumns = true;
            this.SetBicycleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SetBicycleGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SetBicycleGrid.ColumnHeadersHeight = 29;
            this.SetBicycleGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SetBicycleGrid.Location = new System.Drawing.Point(418, 57);
            this.SetBicycleGrid.MaximumSize = new System.Drawing.Size(600, 600);
            this.SetBicycleGrid.MinimumSize = new System.Drawing.Size(600, 300);
            this.SetBicycleGrid.Name = "SetBicycleGrid";
            this.SetBicycleGrid.RowHeadersWidth = 51;
            this.SetBicycleGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SetBicycleGrid.RowTemplate.Height = 29;
            this.SetBicycleGrid.Size = new System.Drawing.Size(600, 300);
            this.SetBicycleGrid.TabIndex = 8;
            // 
            // frmSetBicycleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1171, 799);
            this.Controls.Add(this.SetBicycleGrid);
            this.Controls.Add(this.grpBxBicycleType);
            this.Controls.Add(this.mnuSetBicycles);
            this.MainMenuStrip = this.mnuSetBicycles;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1400, 1198);
            this.Name = "frmSetBicycleType";
            this.Text = "Bicycle Type Creation";
            this.Load += new System.EventHandler(this.frmSetBicycleType_Load);
            this.mnuSetBicycles.ResumeLayout(false);
            this.mnuSetBicycles.PerformLayout();
            this.grpBxBicycleType.ResumeLayout(false);
            this.grpBxBicycleType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetBicycleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuSetBicycles;
        private ToolStripMenuItem MnuSetBicycleTypeFile;
        private Label LblBicycleType;
        private Label LblDescription;
        private Label LblDailyRate;
        private TextBox TxtBicycleType;
        private TextBox TxtDescription;
        private TextBox TxtDailyRate;
        private Button BtnSave;
        private GroupBox grpBxBicycleType;
        private Label lblStatus;
        private DataGridView SetBicycleGrid;
        private Label LblTypeCode;
        private ComboBox cmBxTypeStatus;
        private TextBox TxtTypeCode;
        private Label label1;
    }
}
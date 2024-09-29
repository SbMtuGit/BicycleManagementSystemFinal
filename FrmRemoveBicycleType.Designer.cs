namespace BicycleManagementSystem
{
    partial class FrmRemoveBicycleType
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
            this.grpBxRmvBicycleType = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTypeCode = new System.Windows.Forms.Label();
            this.CmBBicycleTypeCode = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBicycleType = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.TxtBxDailRate = new System.Windows.Forms.TextBox();
            this.TxtBxDesc = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frmSetBicycleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DgGrdRemove = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Remove = new System.Windows.Forms.Button();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBxRmvBicycleType.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmSetBicycleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgGrdRemove)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxRmvBicycleType
            // 
            this.grpBxRmvBicycleType.Controls.Add(this.label4);
            this.grpBxRmvBicycleType.Controls.Add(this.cmbTypeCode);
            this.grpBxRmvBicycleType.Controls.Add(this.CmBBicycleTypeCode);
            this.grpBxRmvBicycleType.Controls.Add(this.btnSubmit);
            this.grpBxRmvBicycleType.Location = new System.Drawing.Point(84, 31);
            this.grpBxRmvBicycleType.Name = "grpBxRmvBicycleType";
            this.grpBxRmvBicycleType.Size = new System.Drawing.Size(401, 249);
            this.grpBxRmvBicycleType.TabIndex = 0;
            this.grpBxRmvBicycleType.TabStop = false;
            this.grpBxRmvBicycleType.Text = "Search by Typecode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 60);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select the TypeCode\r\n of the bicycle type\r\n you would like to Delete .";
            // 
            // cmbTypeCode
            // 
            this.cmbTypeCode.AutoSize = true;
            this.cmbTypeCode.Location = new System.Drawing.Point(31, 137);
            this.cmbTypeCode.Name = "cmbTypeCode";
            this.cmbTypeCode.Size = new System.Drawing.Size(75, 20);
            this.cmbTypeCode.TabIndex = 4;
            this.cmbTypeCode.Text = "TypeCode";
            // 
            // CmBBicycleTypeCode
            // 
            this.CmBBicycleTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBBicycleTypeCode.FormattingEnabled = true;
            this.CmBBicycleTypeCode.Location = new System.Drawing.Point(227, 129);
            this.CmBBicycleTypeCode.Name = "CmBBicycleTypeCode";
            this.CmBBicycleTypeCode.Size = new System.Drawing.Size(151, 28);
            this.CmBBicycleTypeCode.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(147, 214);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Search";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBicycleType
            // 
            this.txtBicycleType.Location = new System.Drawing.Point(117, 29);
            this.txtBicycleType.Name = "txtBicycleType";
            this.txtBicycleType.Size = new System.Drawing.Size(148, 27);
            this.txtBicycleType.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(117, 128);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(151, 28);
            this.cmbStatus.TabIndex = 3;
            // 
            // TxtBxDailRate
            // 
            this.TxtBxDailRate.Location = new System.Drawing.Point(117, 95);
            this.TxtBxDailRate.Name = "TxtBxDailRate";
            this.TxtBxDailRate.Size = new System.Drawing.Size(151, 27);
            this.TxtBxDailRate.TabIndex = 1;
            // 
            // TxtBxDesc
            // 
            this.TxtBxDesc.Location = new System.Drawing.Point(117, 62);
            this.TxtBxDesc.Name = "TxtBxDesc";
            this.TxtBxDesc.Size = new System.Drawing.Size(151, 27);
            this.TxtBxDesc.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 136);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Daily Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BicycleType";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmSetBicycleTypeBindingSource
            // 
            this.frmSetBicycleTypeBindingSource.DataSource = typeof(BicycleManagementSystem.frmSetBicycleType);
            // 
            // DgGrdRemove
            // 
            this.DgGrdRemove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgGrdRemove.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgGrdRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgGrdRemove.Location = new System.Drawing.Point(84, 313);
            this.DgGrdRemove.Name = "DgGrdRemove";
            this.DgGrdRemove.RowHeadersWidth = 51;
            this.DgGrdRemove.RowTemplate.Height = 29;
            this.DgGrdRemove.Size = new System.Drawing.Size(895, 461);
            this.DgGrdRemove.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Remove);
            this.groupBox1.Controls.Add(this.txtBicycleType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.TxtBxDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBxDailRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(491, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Here";
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(117, 177);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(151, 29);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // FrmRemoveBicycleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 853);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgGrdRemove);
            this.Controls.Add(this.grpBxRmvBicycleType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmRemoveBicycleType";
            this.Text = "Remove bicycle Types";
            this.Load += new System.EventHandler(this.FrmRemoveBicycleType_Load);
            this.grpBxRmvBicycleType.ResumeLayout(false);
            this.grpBxRmvBicycleType.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmSetBicycleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgGrdRemove)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpBxRmvBicycleType;
        private TextBox TxtBxDailRate;
        private TextBox TxtBxDesc;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSubmit;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private ComboBox CmBBicycleTypeCode;
        private MenuStrip menuStrip1;
        private BindingSource frmSetBicycleTypeBindingSource;
        private DataGridView DgGrdRemove;
        private TextBox txtBicycleType;
        private Label cmbTypeCode;
        private GroupBox groupBox1;
        private Button Remove;
        private Label label4;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}
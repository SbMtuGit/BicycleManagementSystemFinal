namespace BicycleManagementSystem
{
    partial class FrmRemoveBicycleInventory
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTypeCode = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.cmbBxStatus = new System.Windows.Forms.ComboBox();
            this.cmbBxGender = new System.Windows.Forms.ComboBox();
            this.cmbBxBicycleID = new System.Windows.Forms.ComboBox();
            this.txtBxModel = new System.Windows.Forms.TextBox();
            this.txtBxSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1184, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMnuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // backMnuItem
            // 
            this.backMnuItem.Name = "backMnuItem";
            this.backMnuItem.Size = new System.Drawing.Size(123, 26);
            this.backMnuItem.Text = "&Back";
            this.backMnuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtTypeCode);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.cmbBxStatus);
            this.groupBox1.Controls.Add(this.cmbBxGender);
            this.groupBox1.Controls.Add(this.cmbBxBicycleID);
            this.groupBox1.Controls.Add(this.txtBxModel);
            this.groupBox1.Controls.Add(this.txtBxSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 389);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Bicycle";
            // 
            // TxtTypeCode
            // 
            this.TxtTypeCode.Location = new System.Drawing.Point(85, 217);
            this.TxtTypeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTypeCode.Name = "TxtTypeCode";
            this.TxtTypeCode.ReadOnly = true;
            this.TxtTypeCode.Size = new System.Drawing.Size(125, 27);
            this.TxtTypeCode.TabIndex = 4;
            this.TxtTypeCode.Visible = false;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(85, 267);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(94, 29);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cmbBxStatus
            // 
            this.cmbBxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxStatus.FormattingEnabled = true;
            this.cmbBxStatus.Location = new System.Drawing.Point(85, 169);
            this.cmbBxStatus.Name = "cmbBxStatus";
            this.cmbBxStatus.Size = new System.Drawing.Size(125, 28);
            this.cmbBxStatus.TabIndex = 2;
            // 
            // cmbBxGender
            // 
            this.cmbBxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxGender.FormattingEnabled = true;
            this.cmbBxGender.Location = new System.Drawing.Point(85, 136);
            this.cmbBxGender.Name = "cmbBxGender";
            this.cmbBxGender.Size = new System.Drawing.Size(125, 28);
            this.cmbBxGender.TabIndex = 2;
            // 
            // cmbBxBicycleID
            // 
            this.cmbBxBicycleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxBicycleID.FormattingEnabled = true;
            this.cmbBxBicycleID.Location = new System.Drawing.Point(85, 32);
            this.cmbBxBicycleID.Name = "cmbBxBicycleID";
            this.cmbBxBicycleID.Size = new System.Drawing.Size(125, 28);
            this.cmbBxBicycleID.TabIndex = 2;
            // 
            // txtBxModel
            // 
            this.txtBxModel.Location = new System.Drawing.Point(85, 99);
            this.txtBxModel.Name = "txtBxModel";
            this.txtBxModel.ReadOnly = true;
            this.txtBxModel.Size = new System.Drawing.Size(125, 27);
            this.txtBxModel.TabIndex = 1;
            // 
            // txtBxSize
            // 
            this.txtBxSize.Location = new System.Drawing.Point(85, 67);
            this.txtBxSize.Name = "txtBxSize";
            this.txtBxSize.ReadOnly = true;
            this.txtBxSize.Size = new System.Drawing.Size(125, 27);
            this.txtBxSize.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BicycleID";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(382, 391);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(94, 29);
            this.BtnSubmit.TabIndex = 2;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(743, 200);
            this.dataGridView1.TabIndex = 4;
            // 
            // FrmRemoveBicycleInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmRemoveBicycleInventory";
            this.Text = "FrmRemoveBicycle";
            this.Load += new System.EventHandler(this.FrmRemoveBicycleInventory_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem backMnuItem;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnSubmit;
        private ComboBox cmbBxBicycleID;
        private TextBox txtBxModel;
        private TextBox txtBxSize;
        private ComboBox cmbBxStatus;
        private ComboBox cmbBxGender;
        private Button BtnSearch;
        private TextBox TxtTypeCode;
        private DataGridView dataGridView1;
    }
}
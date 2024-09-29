namespace BicycleManagementSystem
{
    partial class FrmAddBicycleInventory
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBicycleId = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmBGender = new System.Windows.Forms.ComboBox();
            this.txtbxBicycleID = new System.Windows.Forms.TextBox();
            this.txtBxSize = new System.Windows.Forms.TextBox();
            this.txtbxModel = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.cmbAvail = new System.Windows.Forms.ComboBox();
            this.grpBxInventory = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBicycleTypeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTypeCode = new System.Windows.Forms.ComboBox();
            this.frmSetBicycleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.grpBxInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmSetBicycleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(1390, 30);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
            // 
            // lblBicycleId
            // 
            this.lblBicycleId.AutoSize = true;
            this.lblBicycleId.Location = new System.Drawing.Point(24, 263);
            this.lblBicycleId.Name = "lblBicycleId";
            this.lblBicycleId.Size = new System.Drawing.Size(68, 20);
            this.lblBicycleId.TabIndex = 1;
            this.lblBicycleId.Text = "BicycleId";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(24, 310);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(36, 20);
            this.LblSize.TabIndex = 1;
            this.LblSize.Text = "Size";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(22, 354);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(24, 441);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 20);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender";
            // 
            // cmBGender
            // 
            this.cmBGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBGender.FormattingEnabled = true;
            this.cmBGender.Location = new System.Drawing.Point(118, 433);
            this.cmBGender.Name = "cmBGender";
            this.cmBGender.Size = new System.Drawing.Size(156, 28);
            this.cmBGender.TabIndex = 2;
            // 
            // txtbxBicycleID
            // 
            this.txtbxBicycleID.Location = new System.Drawing.Point(118, 260);
            this.txtbxBicycleID.Name = "txtbxBicycleID";
            this.txtbxBicycleID.ReadOnly = true;
            this.txtbxBicycleID.Size = new System.Drawing.Size(151, 27);
            this.txtbxBicycleID.TabIndex = 3;
            // 
            // txtBxSize
            // 
            this.txtBxSize.Location = new System.Drawing.Point(118, 307);
            this.txtBxSize.Name = "txtBxSize";
            this.txtBxSize.Size = new System.Drawing.Size(151, 27);
            this.txtBxSize.TabIndex = 3;
            // 
            // txtbxModel
            // 
            this.txtbxModel.Location = new System.Drawing.Point(118, 347);
            this.txtbxModel.Name = "txtbxModel";
            this.txtbxModel.Size = new System.Drawing.Size(151, 27);
            this.txtbxModel.TabIndex = 3;
            this.txtbxModel.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(57, 141);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(22, 395);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(83, 20);
            this.lblAvailability.TabIndex = 1;
            this.lblAvailability.Text = "Availability";
            // 
            // cmbAvail
            // 
            this.cmbAvail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvail.FormattingEnabled = true;
            this.cmbAvail.Location = new System.Drawing.Point(118, 392);
            this.cmbAvail.Name = "cmbAvail";
            this.cmbAvail.Size = new System.Drawing.Size(151, 28);
            this.cmbAvail.TabIndex = 2;
            // 
            // grpBxInventory
            // 
            this.grpBxInventory.Controls.Add(this.label3);
            this.grpBxInventory.Controls.Add(this.TxtBicycleTypeID);
            this.grpBxInventory.Controls.Add(this.label2);
            this.grpBxInventory.Controls.Add(this.label1);
            this.grpBxInventory.Controls.Add(this.CmbTypeCode);
            this.grpBxInventory.Controls.Add(this.btnSubmit);
            this.grpBxInventory.Location = new System.Drawing.Point(11, 33);
            this.grpBxInventory.Name = "grpBxInventory";
            this.grpBxInventory.Size = new System.Drawing.Size(342, 210);
            this.grpBxInventory.TabIndex = 5;
            this.grpBxInventory.TabStop = false;
            this.grpBxInventory.Text = "Inventory ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select a TypeCode to get started";
            // 
            // TxtBicycleTypeID
            // 
            this.TxtBicycleTypeID.Location = new System.Drawing.Point(173, 108);
            this.TxtBicycleTypeID.Name = "TxtBicycleTypeID";
            this.TxtBicycleTypeID.ReadOnly = true;
            this.TxtBicycleTypeID.Size = new System.Drawing.Size(147, 27);
            this.TxtBicycleTypeID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type Identifier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "TypeCode";
            // 
            // CmbTypeCode
            // 
            this.CmbTypeCode.DataSource = this.frmSetBicycleTypeBindingSource;
            this.CmbTypeCode.FormattingEnabled = true;
            this.CmbTypeCode.Location = new System.Drawing.Point(169, 63);
            this.CmbTypeCode.Name = "CmbTypeCode";
            this.CmbTypeCode.Size = new System.Drawing.Size(151, 28);
            this.CmbTypeCode.TabIndex = 5;
            // 
            // frmSetBicycleTypeBindingSource
            // 
            this.frmSetBicycleTypeBindingSource.DataSource = typeof(BicycleManagementSystem.frmSetBicycleType);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(877, 237);
            this.dataGridView1.TabIndex = 6;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(123, 479);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 29);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmAddBicycleInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpBxInventory);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.txtbxBicycleID);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.lblBicycleId);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtBxSize);
            this.Controls.Add(this.cmBGender);
            this.Controls.Add(this.LblSize);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.cmbAvail);
            this.Controls.Add(this.txtbxModel);
            this.Controls.Add(this.lblModel);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "FrmAddBicycleInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grpBxInventory.ResumeLayout(false);
            this.grpBxInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmSetBicycleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
      
       
        private MenuStrip menuStrip2;
        private Label lblBicycleId;
        private Label LblSize;
        private Label lblModel;
        private Label lblGender;
        private ComboBox cmBGender;
        private TextBox txtbxBicycleID;
        private TextBox txtBxSize;
        private TextBox txtbxModel;
        private Button btnSubmit;
        private Label lblAvailability;
        private ComboBox cmbAvail;
        private GroupBox grpBxInventory;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox CmbTypeCode;
        private Label label2;
        private BindingSource frmSetBicycleTypeBindingSource;
        private TextBox TxtBicycleTypeID;
        private Button BtnSave;
        private Label label3;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}
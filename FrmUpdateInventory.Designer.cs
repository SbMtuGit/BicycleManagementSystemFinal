namespace BicycleManagementSystem
{
    partial class FrmUpdateInventory
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
            this.mnuUpdayeBicycle = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBxUpdateInventory = new System.Windows.Forms.GroupBox();
            this.lBLdescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTypeCode = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.cmbBxGender = new System.Windows.Forms.ComboBox();
            this.CmbBicycleId = new System.Windows.Forms.ComboBox();
            this.CmbAvailable = new System.Windows.Forms.ComboBox();
            this.txtBxModel = new System.Windows.Forms.TextBox();
            this.txtBxSize = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.CmbAvail = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblBicycleID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mnuUpdayeBicycle.SuspendLayout();
            this.grpBxUpdateInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuUpdayeBicycle
            // 
            this.mnuUpdayeBicycle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuUpdayeBicycle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdayeBicycle.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdayeBicycle.Name = "mnuUpdayeBicycle";
            this.mnuUpdayeBicycle.Size = new System.Drawing.Size(1260, 28);
            this.mnuUpdayeBicycle.TabIndex = 0;
            this.mnuUpdayeBicycle.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grpBxUpdateInventory
            // 
            this.grpBxUpdateInventory.Controls.Add(this.lBLdescription);
            this.grpBxUpdateInventory.Controls.Add(this.label1);
            this.grpBxUpdateInventory.Controls.Add(this.txtTypeCode);
            this.grpBxUpdateInventory.Controls.Add(this.btnUpdate);
            this.grpBxUpdateInventory.Controls.Add(this.BtnSearch);
            this.grpBxUpdateInventory.Controls.Add(this.cmbBxGender);
            this.grpBxUpdateInventory.Controls.Add(this.CmbBicycleId);
            this.grpBxUpdateInventory.Controls.Add(this.CmbAvailable);
            this.grpBxUpdateInventory.Controls.Add(this.txtBxModel);
            this.grpBxUpdateInventory.Controls.Add(this.txtBxSize);
            this.grpBxUpdateInventory.Controls.Add(this.lblGender);
            this.grpBxUpdateInventory.Controls.Add(this.CmbAvail);
            this.grpBxUpdateInventory.Controls.Add(this.lblModel);
            this.grpBxUpdateInventory.Controls.Add(this.lblSize);
            this.grpBxUpdateInventory.Controls.Add(this.lblBicycleID);
            this.grpBxUpdateInventory.Location = new System.Drawing.Point(28, 47);
            this.grpBxUpdateInventory.Name = "grpBxUpdateInventory";
            this.grpBxUpdateInventory.Size = new System.Drawing.Size(394, 570);
            this.grpBxUpdateInventory.TabIndex = 1;
            this.grpBxUpdateInventory.TabStop = false;
            this.grpBxUpdateInventory.Text = "Inventory";
            // 
            // lBLdescription
            // 
            this.lBLdescription.AutoSize = true;
            this.lBLdescription.Location = new System.Drawing.Point(25, 63);
            this.lBLdescription.Name = "lBLdescription";
            this.lBLdescription.Size = new System.Drawing.Size(0, 20);
            this.lBLdescription.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please Select from the \r\ndrop-down menu\r\n which bicycle you would like to update";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTypeCode
            // 
            this.txtTypeCode.Location = new System.Drawing.Point(378, 148);
            this.txtTypeCode.Name = "txtTypeCode";
            this.txtTypeCode.ReadOnly = true;
            this.txtTypeCode.Size = new System.Drawing.Size(10, 27);
            this.txtTypeCode.TabIndex = 5;
            this.txtTypeCode.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(280, 482);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Submit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(280, 409);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(94, 29);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cmbBxGender
            // 
            this.cmbBxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxGender.FormattingEnabled = true;
            this.cmbBxGender.Location = new System.Drawing.Point(223, 363);
            this.cmbBxGender.Name = "cmbBxGender";
            this.cmbBxGender.Size = new System.Drawing.Size(151, 28);
            this.cmbBxGender.TabIndex = 2;
            // 
            // CmbBicycleId
            // 
            this.CmbBicycleId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBicycleId.FormattingEnabled = true;
            this.CmbBicycleId.Location = new System.Drawing.Point(223, 148);
            this.CmbBicycleId.Name = "CmbBicycleId";
            this.CmbBicycleId.Size = new System.Drawing.Size(151, 28);
            this.CmbBicycleId.TabIndex = 2;
            // 
            // CmbAvailable
            // 
            this.CmbAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAvailable.FormattingEnabled = true;
            this.CmbAvailable.Location = new System.Drawing.Point(223, 307);
            this.CmbAvailable.Name = "CmbAvailable";
            this.CmbAvailable.Size = new System.Drawing.Size(151, 28);
            this.CmbAvailable.TabIndex = 2;
            // 
            // txtBxModel
            // 
            this.txtBxModel.Location = new System.Drawing.Point(223, 262);
            this.txtBxModel.Name = "txtBxModel";
            this.txtBxModel.Size = new System.Drawing.Size(151, 27);
            this.txtBxModel.TabIndex = 1;
            // 
            // txtBxSize
            // 
            this.txtBxSize.Location = new System.Drawing.Point(223, 182);
            this.txtBxSize.Name = "txtBxSize";
            this.txtBxSize.Size = new System.Drawing.Size(151, 27);
            this.txtBxSize.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(25, 371);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 20);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // CmbAvail
            // 
            this.CmbAvail.AutoSize = true;
            this.CmbAvail.Location = new System.Drawing.Point(24, 315);
            this.CmbAvail.Name = "CmbAvail";
            this.CmbAvail.Size = new System.Drawing.Size(83, 20);
            this.CmbAvail.TabIndex = 0;
            this.CmbAvail.Text = "Availability";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(25, 269);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(25, 189);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(36, 20);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // lblBicycleID
            // 
            this.lblBicycleID.AutoSize = true;
            this.lblBicycleID.Location = new System.Drawing.Point(25, 151);
            this.lblBicycleID.Name = "lblBicycleID";
            this.lblBicycleID.Size = new System.Drawing.Size(70, 20);
            this.lblBicycleID.TabIndex = 0;
            this.lblBicycleID.Text = "BicycleID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(773, 296);
            this.dataGridView1.TabIndex = 4;
            // 
            // FrmUpdateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 629);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpBxUpdateInventory);
            this.Controls.Add(this.mnuUpdayeBicycle);
            this.MainMenuStrip = this.mnuUpdayeBicycle;
            this.Name = "FrmUpdateInventory";
            this.Text = "FrmUpdateInventory";
            this.Load += new System.EventHandler(this.FrmUpdateInventory_Load);
            this.mnuUpdayeBicycle.ResumeLayout(false);
            this.mnuUpdayeBicycle.PerformLayout();
            this.grpBxUpdateInventory.ResumeLayout(false);
            this.grpBxUpdateInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuUpdayeBicycle;
        private ToolStripMenuItem backToolStripMenuItem;
        private GroupBox grpBxUpdateInventory;
        private ComboBox CmbAvailable;
        private TextBox txtBxModel;
        private TextBox txtBxSize;
        private Label CmbAvail;
        private Label lblModel;
        private Label lblSize;
        private Label lblBicycleID;
        private Button btnUpdate;
        private ComboBox cmbBxGender;
        private Label lblGender;
        private ComboBox CmbBicycleId;
        private Button BtnSearch;
        private TextBox txtTypeCode;
        internal DataGridView dataGridView1;
        private Label lBLdescription;
        private Label label1;
    }
}
namespace BicycleManagementSystem
{
    partial class FrmBooking
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
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBicycleType = new System.Windows.Forms.Label();
            this.LblCollectionDate = new System.Windows.Forms.Label();
            this.btnAddBicycleorder = new System.Windows.Forms.Button();
            this.lblRetrunDate = new System.Windows.Forms.Label();
            this.dtCollectionTime = new System.Windows.Forms.DateTimePicker();
            this.lblBasket = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxSecondName = new System.Windows.Forms.TextBox();
            this.txtBxTelephone = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblTelePhone = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbBicycleType = new System.Windows.Forms.ComboBox();
            this.grpBxCustDetails = new System.Windows.Forms.GroupBox();
            this.BtnEmpty = new System.Windows.Forms.Button();
            this.BtnCheckout = new System.Windows.Forms.Button();
            this.GrpBxBicycles = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.cmBxTime = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.BicycleGrid = new System.Windows.Forms.DataGridView();
            this.DgvBasket = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpBxCustDetails.SuspendLayout();
            this.GrpBxBicycles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BicycleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1841, 30);
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
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // lblBicycleType
            // 
            this.lblBicycleType.AutoSize = true;
            this.lblBicycleType.Location = new System.Drawing.Point(14, 216);
            this.lblBicycleType.Name = "lblBicycleType";
            this.lblBicycleType.Size = new System.Drawing.Size(86, 20);
            this.lblBicycleType.TabIndex = 1;
            this.lblBicycleType.Text = "BicycleType";
            // 
            // LblCollectionDate
            // 
            this.LblCollectionDate.AutoSize = true;
            this.LblCollectionDate.Location = new System.Drawing.Point(6, 91);
            this.LblCollectionDate.Name = "LblCollectionDate";
            this.LblCollectionDate.Size = new System.Drawing.Size(112, 20);
            this.LblCollectionDate.TabIndex = 1;
            this.LblCollectionDate.Text = "Collection Date";
            // 
            // btnAddBicycleorder
            // 
            this.btnAddBicycleorder.Location = new System.Drawing.Point(273, 382);
            this.btnAddBicycleorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBicycleorder.Name = "btnAddBicycleorder";
            this.btnAddBicycleorder.Size = new System.Drawing.Size(103, 31);
            this.btnAddBicycleorder.TabIndex = 3;
            this.btnAddBicycleorder.Text = "add to Cart";
            this.btnAddBicycleorder.UseVisualStyleBackColor = true;
            this.btnAddBicycleorder.Click += new System.EventHandler(this.btnAddBicycleord_Click);
            // 
            // lblRetrunDate
            // 
            this.lblRetrunDate.AutoSize = true;
            this.lblRetrunDate.Location = new System.Drawing.Point(6, 162);
            this.lblRetrunDate.Name = "lblRetrunDate";
            this.lblRetrunDate.Size = new System.Drawing.Size(88, 20);
            this.lblRetrunDate.TabIndex = 1;
            this.lblRetrunDate.Text = "Return Date";
            // 
            // dtCollectionTime
            // 
            this.dtCollectionTime.CustomFormat = "dd/mm/yy";
            this.dtCollectionTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCollectionTime.Location = new System.Drawing.Point(141, 86);
            this.dtCollectionTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtCollectionTime.MinDate = new System.DateTime(2024, 4, 16, 17, 51, 6, 0);
            this.dtCollectionTime.Name = "dtCollectionTime";
            this.dtCollectionTime.Size = new System.Drawing.Size(235, 27);
            this.dtCollectionTime.TabIndex = 5;
            this.dtCollectionTime.Value = new System.DateTime(2024, 4, 16, 17, 51, 6, 0);
            this.dtCollectionTime.ValueChanged += new System.EventHandler(this.dtCollectionTime_ValueChanged);
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.Location = new System.Drawing.Point(741, 99);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(104, 20);
            this.lblBasket.TabIndex = 7;
            this.lblBasket.Text = "Current Basket";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(144, 27);
            this.txtBxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(114, 27);
            this.txtBxFirstName.TabIndex = 2;
            // 
            // txtBxSecondName
            // 
            this.txtBxSecondName.Location = new System.Drawing.Point(144, 68);
            this.txtBxSecondName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxSecondName.Name = "txtBxSecondName";
            this.txtBxSecondName.Size = new System.Drawing.Size(114, 27);
            this.txtBxSecondName.TabIndex = 2;
            // 
            // txtBxTelephone
            // 
            this.txtBxTelephone.Location = new System.Drawing.Point(144, 111);
            this.txtBxTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxTelephone.Name = "txtBxTelephone";
            this.txtBxTelephone.Size = new System.Drawing.Size(114, 27);
            this.txtBxTelephone.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(6, 68);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(102, 20);
            this.lblSecondName.TabIndex = 1;
            this.lblSecondName.Text = "Second Name";
            // 
            // lblTelePhone
            // 
            this.lblTelePhone.AutoSize = true;
            this.lblTelePhone.Location = new System.Drawing.Point(6, 107);
            this.lblTelePhone.Name = "lblTelePhone";
            this.lblTelePhone.Size = new System.Drawing.Size(78, 20);
            this.lblTelePhone.TabIndex = 1;
            this.lblTelePhone.Text = "Telephone";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(141, 242);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(235, 28);
            this.cmbGender.TabIndex = 8;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(14, 250);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 20);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Gender ";
            // 
            // cmbBicycleType
            // 
            this.cmbBicycleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBicycleType.FormattingEnabled = true;
            this.cmbBicycleType.Location = new System.Drawing.Point(141, 208);
            this.cmbBicycleType.Name = "cmbBicycleType";
            this.cmbBicycleType.Size = new System.Drawing.Size(235, 28);
            this.cmbBicycleType.TabIndex = 8;
            // 
            // grpBxCustDetails
            // 
            this.grpBxCustDetails.Controls.Add(this.lblFirstName);
            this.grpBxCustDetails.Controls.Add(this.txtBxFirstName);
            this.grpBxCustDetails.Controls.Add(this.lblSecondName);
            this.grpBxCustDetails.Controls.Add(this.BtnEmpty);
            this.grpBxCustDetails.Controls.Add(this.txtBxSecondName);
            this.grpBxCustDetails.Controls.Add(this.BtnCheckout);
            this.grpBxCustDetails.Controls.Add(this.lblTelePhone);
            this.grpBxCustDetails.Controls.Add(this.txtBxTelephone);
            this.grpBxCustDetails.Location = new System.Drawing.Point(741, 377);
            this.grpBxCustDetails.Name = "grpBxCustDetails";
            this.grpBxCustDetails.Size = new System.Drawing.Size(371, 326);
            this.grpBxCustDetails.TabIndex = 10;
            this.grpBxCustDetails.TabStop = false;
            this.grpBxCustDetails.Text = "CustomerDetails";
            // 
            // BtnEmpty
            // 
            this.BtnEmpty.Location = new System.Drawing.Point(14, 165);
            this.BtnEmpty.Name = "BtnEmpty";
            this.BtnEmpty.Size = new System.Drawing.Size(94, 29);
            this.BtnEmpty.TabIndex = 14;
            this.BtnEmpty.Text = "Empty Basket";
            this.BtnEmpty.UseVisualStyleBackColor = true;
            this.BtnEmpty.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.CausesValidation = false;
            this.BtnCheckout.Location = new System.Drawing.Point(164, 161);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.Size = new System.Drawing.Size(94, 29);
            this.BtnCheckout.TabIndex = 13;
            this.BtnCheckout.Text = "CheckOut";
            this.BtnCheckout.UseVisualStyleBackColor = true;
            this.BtnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // GrpBxBicycles
            // 
            this.GrpBxBicycles.Controls.Add(this.groupBox1);
            this.GrpBxBicycles.Controls.Add(this.BicycleGrid);
            this.GrpBxBicycles.Location = new System.Drawing.Point(12, 109);
            this.GrpBxBicycles.Name = "GrpBxBicycles";
            this.GrpBxBicycles.Size = new System.Drawing.Size(723, 841);
            this.GrpBxBicycles.TabIndex = 11;
            this.GrpBxBicycles.TabStop = false;
            this.GrpBxBicycles.Text = "Bicycles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblCollectionDate);
            this.groupBox1.Controls.Add(this.LblTime);
            this.groupBox1.Controls.Add(this.cmBxTime);
            this.groupBox1.Controls.Add(this.btnAddBicycleorder);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblRetrunDate);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.dtReturnDate);
            this.groupBox1.Controls.Add(this.lblBicycleType);
            this.groupBox1.Controls.Add(this.cmbBicycleType);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.dtCollectionTime);
            this.groupBox1.Location = new System.Drawing.Point(6, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 423);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking-Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 60);
            this.label3.TabIndex = 20;
            this.label3.Text = "Press Search To Continue \r\nOnce you have decided on a bicycle please\r\nSelect the " +
    "row in the Grid Before Adding to Cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Please fill in The details below Bicycles \r\nwill be shown once a bicyle type is c" +
    "hosen";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(6, 130);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(113, 20);
            this.LblTime.TabIndex = 17;
            this.LblTime.Text = "Collection Time";
            // 
            // cmBxTime
            // 
            this.cmBxTime.FormattingEnabled = true;
            this.cmBxTime.Location = new System.Drawing.Point(141, 120);
            this.cmBxTime.Name = "cmBxTime";
            this.cmBxTime.Size = new System.Drawing.Size(235, 28);
            this.cmBxTime.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(282, 276);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.CustomFormat = "dd/MM/yyyy";
            this.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReturnDate.Location = new System.Drawing.Point(141, 162);
            this.dtReturnDate.MinDate = new System.DateTime(2024, 4, 16, 0, 0, 0, 0);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(235, 27);
            this.dtReturnDate.TabIndex = 16;
            this.dtReturnDate.Value = new System.DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // BicycleGrid
            // 
            this.BicycleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BicycleGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BicycleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BicycleGrid.Location = new System.Drawing.Point(6, 23);
            this.BicycleGrid.Name = "BicycleGrid";
            this.BicycleGrid.RowHeadersWidth = 51;
            this.BicycleGrid.RowTemplate.Height = 29;
            this.BicycleGrid.Size = new System.Drawing.Size(695, 188);
            this.BicycleGrid.TabIndex = 19;
            // 
            // DgvBasket
            // 
            this.DgvBasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBasket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBasket.Location = new System.Drawing.Point(741, 132);
            this.DgvBasket.Name = "DgvBasket";
            this.DgvBasket.RowHeadersWidth = 51;
            this.DgvBasket.RowTemplate.Height = 29;
            this.DgvBasket.Size = new System.Drawing.Size(962, 188);
            this.DgvBasket.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome Please enter your booking details below to start adding bicycles to your " +
    "basket";
            // 
            // FrmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 953);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvBasket);
            this.Controls.Add(this.grpBxCustDetails);
            this.Controls.Add(this.GrpBxBicycles);
            this.Controls.Add(this.lblBasket);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBooking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.FrmBooking_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBxCustDetails.ResumeLayout(false);
            this.grpBxCustDetails.PerformLayout();
            this.GrpBxBicycles.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BicycleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private Label lblBicycleType;
        private Label LblCollectionDate;
        private Button btnAddBicycleorder;
        private Label lblRetrunDate;
        private DateTimePicker dtCollectionTime;
        private DateTimePicker dateTimePicker2;
        private Label lblBasket;
        private TextBox txtBxFirstName;
        private TextBox txtBxSecondName;
        private TextBox txtBxTelephone;
        private Label lblFirstName;
        private Label lblSecondName;
        private Label lblTelePhone;
        private ColorDialog colorDialog1;
        private ComboBox cmbGender;
        private Label lblGender;
        private ComboBox cmbBicycleType;
        private GroupBox grpBxCustDetails;
        private GroupBox GrpBxBicycles;
        private Button btnSearch;
        private Button BtnCheckout;
        private DateTimePicker dtReturnDate;
        private ComboBox cmBxTime;
        private Label LblTime;
        private DataGridView BicycleGrid;
        private Button BtnEmpty;
        private DataGridView DgvBasket;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
    }
}
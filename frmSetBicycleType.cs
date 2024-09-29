namespace BicycleManagementSystem
{
    public partial class frmSetBicycleType : Form
    {
        Bicycle_type bicycle_type = new Bicycle_type();

        public frmSetBicycleType()
        {

            InitializeComponent();

        }
        private void backSetmnu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int typeCode;
            Decimal DailyRate;
            string[] fields = { TxtTypeCode.Text, TxtBicycleType.Text, TxtDescription.Text, TxtDailyRate.Text, cmBxTypeStatus.Text };
            string[] fieldNames = { "TypeCode", "Bicycle Type", "Description", "Daily_Rate", "Status" };
            String ErrorMessageEmpty = Utility.GetEmptyFieldMessage(fields, fieldNames);
            if (ErrorMessageEmpty != null)
            {
                MessageBox.Show(ErrorMessageEmpty);
                return;

            }

            if (!int.TryParse(TxtTypeCode.Text, out typeCode))
            {
                MessageBox.Show("Please enter a valid integer for the type code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Utility.ContainsNumber(TxtBicycleType.Text) || Utility.ContainsSpecial(TxtBicycleType.Text))
            {
                MessageBox.Show("A bicycle type may not contain any numbers or special characters please try again");
                return;
            }

            string validTypeMessage = Utility.ValidateTypeCode(typeCode);
            if (validTypeMessage != null)
            {
                MessageBox.Show(validTypeMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Decimal.TryParse(TxtDailyRate.Text, out DailyRate))
            {
                MessageBox.Show("Please enter a valid decimal number for the daily rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("This bicycle type has now been added to the stores inventory please add another");
            Bicycle_type bicycleType = new Bicycle_type(Convert.ToInt32(TxtTypeCode.Text.TrimEnd()), TxtBicycleType.Text.ToUpper().Trim(), TxtDescription.Text.ToLower().TrimEnd(), Convert.ToDecimal(TxtDailyRate.Text.TrimEnd()), cmBxTypeStatus.Text.TrimEnd());
            bicycleType.addBicycle_type();
            TxtTypeCode.Text = Bicycle_type.getNextBicycle_typeCode().ToString();
            Bicycle_type.DisplayBicycleTypesOnGrid(SetBicycleGrid);
            TxtBicycleType.Clear();
            TxtDescription.Clear();
            TxtDailyRate.Clear();
            cmBxTypeStatus.Items.Clear();
        }

        private void frmSetBicycleType_Load(object sender, EventArgs e)
        {

            cmBxTypeStatus.Items.Add("A");
            cmBxTypeStatus.Items.Add("NA");
            TxtTypeCode.Text = Bicycle_type.getNextBicycle_typeCode().ToString();
            Bicycle_type.DisplayBicycleTypesOnGrid(SetBicycleGrid);

        }

        private void MnuSetBicycleTypeFile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



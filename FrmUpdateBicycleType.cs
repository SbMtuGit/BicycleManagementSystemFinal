using System.Data;

namespace BicycleManagementSystem
{

    public partial class FrmUpdateBicycleType : Form
    {

        Bicycle_type BicycleType = new Bicycle_type();
        public FrmUpdateBicycleType()
        {

            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUpdateBicycleType_Load(object sender, EventArgs e)
        {
            CmbStatus.Items.Add("A");
            CmbStatus.Items.Add("NA");
            cmbBxTypeCode.DataSource = Bicycle_type.gettypeCodes();
            Bicycle_type.DisplayBicycleTypesOnGrid(DgGrdUpdate);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int selectedTypeCode = (int)cmbBxTypeCode.SelectedValue;

            DataSet result = Bicycle_type.FindTypes(selectedTypeCode);
            if (result.Tables["types"].Rows.Count > 0)
            {

                TxtBicycleType.Text = result.Tables["types"].Rows[0]["Bicycle_type"].ToString();
                txtDesription.Text = result.Tables["types"].Rows[0]["Description"].ToString();
                txtDailyRate.Text = result.Tables["types"].Rows[0]["DailyRate"].ToString();
                CmbStatus.Text = result.Tables["types"].Rows[0]["Status"].ToString();
            }
            else
            {
                TxtBicycleType.Text = "";
                txtDesription.Text = "";
                txtDailyRate.Text = "";
                CmbStatus.Text = "";
                MessageBox.Show("No data found for the selected type code.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Decimal DailyRate = Convert.ToDecimal(txtDailyRate.Text);
            string[] fields = { TxtBicycleType.Text, txtDesription.Text, txtDailyRate.Text, CmbStatus.Text };
            String[] fieldName = { "BicycleTypes", "Description", "Daily_rate", "Status" };
            String ErrorMessageEmpty = Utility.GetEmptyFieldMessage(fields, fieldName);
            if (ErrorMessageEmpty != null)
            {
                MessageBox.Show(ErrorMessageEmpty);
                return;
            }
            if (Utility.ContainsNumber(TxtBicycleType.Text))
            {
                MessageBox.Show("The bicycle type must not contain any numbers please try something more meaningful");
                return;
            }

            if (!Decimal.TryParse(txtDailyRate.Text, out DailyRate))
            {
                MessageBox.Show("Please enter a valid decimal number for the daily rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Bicycle_type UpatedBicycle = new Bicycle_type(Convert.ToInt32(cmbBxTypeCode.Text.TrimEnd()), TxtBicycleType.Text.TrimEnd(), txtDesription.Text.TrimEnd(), Convert.ToDecimal(txtDailyRate.Text.TrimEnd()), CmbStatus.Text.TrimEnd());
            UpatedBicycle.UpdateBicycle_type();
            MessageBox.Show("This bicycle has now been updated please select another bicycle type to update");
            Bicycle_type.DisplayBicycleTypesOnGrid(DgGrdUpdate);


        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}







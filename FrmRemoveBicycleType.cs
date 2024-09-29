using System.Data;

namespace BicycleManagementSystem
{
    public partial class FrmRemoveBicycleType : Form
    {
        public FrmRemoveBicycleType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedTypeCode = (int)CmBBicycleTypeCode.SelectedValue;

            DataSet result = Bicycle_type.FindTypes(selectedTypeCode);
            if (result.Tables["types"].Rows.Count > 0)
            {

                txtBicycleType.Text = result.Tables["types"].Rows[0]["Bicycle_type"].ToString();
                TxtBxDesc.Text = result.Tables["types"].Rows[0]["Description"].ToString();
                TxtBxDailRate.Text = result.Tables["types"].Rows[0]["DailyRate"].ToString();
                cmbStatus.Text = result.Tables["types"].Rows[0]["Status"].ToString();
                txtBicycleType.ReadOnly = true;
            }
            else
            {
                txtBicycleType.Text = "";
                TxtBxDesc.Text = "";
                TxtBxDailRate.Text = "";
                cmbStatus.Text = "";
                MessageBox.Show("No data found for the selected type code.");
            }
        }


        private void FrmRemoveBicycleType_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("A");
            cmbStatus.Items.Add("NA");
            CmBBicycleTypeCode.DataSource = Bicycle_type.gettypeCodes();
            Bicycle_type.DisplayBicycleTypesOnGrid(DgGrdRemove);

        }
        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void Remove_Click(object sender, EventArgs e)
        {
            Decimal DailyRate;
            string[] fields = { txtBicycleType.Text, TxtBxDesc.Text, TxtBxDailRate.Text, cmbStatus.Text };
            string[] fieldNames = { "TypeCode", "Bicycle Type", "Description", "Daily_Rate", "Status" };
            String ErrorMessageEmpty = Utility.GetEmptyFieldMessage(fields, fieldNames);
            if (ErrorMessageEmpty != null)
            {
                MessageBox.Show(ErrorMessageEmpty);
                return;
            }

            if (!Decimal.TryParse(TxtBxDailRate.Text, out DailyRate))
            {
                MessageBox.Show("Please enter a valid decimal number for the daily rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Status for this bicycle type ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Bicycle_type UpatedBicycle = new Bicycle_type(Convert.ToInt32(CmBBicycleTypeCode.Text.TrimEnd()), txtBicycleType.Text.TrimEnd(), TxtBxDesc.Text.TrimEnd(), Convert.ToDecimal(TxtBxDailRate.Text.TrimEnd()), cmbStatus.Text.TrimEnd());
            UpatedBicycle.RemoveBicycle_Type();
            MessageBox.Show("The Availabilty of this bicycle type has been changed");
            Bicycle_type.DisplayBicycleTypesOnGrid(DgGrdRemove);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


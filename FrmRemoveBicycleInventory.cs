using System.Data;

namespace BicycleManagementSystem
{
    public partial class FrmRemoveBicycleInventory : Form
    {
        public FrmRemoveBicycleInventory()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRemoveBicycleInventory_Load(object sender, EventArgs e)
        {

            cmbBxStatus.Items.Add("A");
            cmbBxStatus.Items.Add("NA");
            cmbBxGender.Items.Add("M");
            cmbBxGender.Items.Add("F");
            cmbBxGender.Items.Add("UNI");
            cmbBxBicycleID.DataSource = Bicycles.getBicycleIDS();
            Bicycles.displayBicycleOnGrid(dataGridView1);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String typeCode = cmbBxBicycleID.Text;
            DataSet result = Bicycles.FindTypes(typeCode);
            if (result.Tables["types"].Rows.Count > 0)
            {
                txtBxModel.Text = result.Tables["types"].Rows[0]["Bmodel"].ToString();
                txtBxSize.Text = result.Tables["types"].Rows[0]["Bsize"].ToString();
                cmbBxGender.Text = result.Tables["types"].Rows[0]["Gender"].ToString();
                cmbBxStatus.SelectedValue = result.Tables["types"].Rows[0]["Status"].ToString();
                TxtTypeCode.Text = result.Tables["types"].Rows[0]["Bicycle_TypeCode"].ToString();
            }
            else
            {
                MessageBox.Show("No data found for the selected BicycleId.");
            }
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int Size = 0;
            string[] fields = { cmbBxBicycleID.Text, (txtBxSize.Text).ToString(), txtBxModel.Text, cmbBxStatus.Text, cmbBxGender.Text, TxtTypeCode.Text };
            string[] fieldNames = { "BicycleID", "Size", "Model", "Availability", "Gender", "TypeCode" };
            String errorMessage = Utility.GetEmptyFieldMessage(fields, fieldNames);
            try
            {
                if (errorMessage != null)
                {
                    throw new FormatException(errorMessage);

                }
                if (!int.TryParse(txtBxSize.Text, out Size) || Size <= 0)
                {
                    throw new FormatException("Please enter a valid size in Inchs");
                }
                int typeCode;
                if (!int.TryParse(TxtTypeCode.Text, out typeCode))
                {
                    throw new FormatException("Please input a Valid Unique TypeCode");
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Bicycles RemovedBicycle = new Bicycles(cmbBxBicycleID.Text, cmbBxGender.Text, Size, txtBxModel.Text, cmbBxStatus.Text, Convert.ToInt32(TxtTypeCode.Text));
            RemovedBicycle.RemoveBicycle();
            Bicycles.displayBicycleOnGrid(dataGridView1);
        }
    }
}

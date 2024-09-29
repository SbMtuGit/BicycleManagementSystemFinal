using System.Data;

namespace BicycleManagementSystem
{
    public partial class FrmUpdateInventory : Form
    {


        public FrmUpdateInventory()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FrmUpdateInventory_Load(object sender, EventArgs e)
        {
            cmbBxGender.Items.Add("M");
            cmbBxGender.Items.Add("F");
            cmbBxGender.Items.Add("UNI");
            CmbAvailable.Items.Add("A");
            CmbAvailable.Items.Add("NA");
            CmbBicycleId.DataSource = Bicycles.getBicycleIDS();
            Bicycles.displayBicycleOnGrid(dataGridView1);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String typeCode = CmbBicycleId.Text;
            DataSet result = Bicycles.FindTypes(typeCode);
            if (result.Tables["types"].Rows.Count > 0)
            {

                txtBxModel.Text = result.Tables["types"].Rows[0]["Bmodel"].ToString();
                txtBxSize.Text = result.Tables["types"].Rows[0]["Bsize"].ToString();
                txtTypeCode.Text = result.Tables["types"].Rows[0]["Bicycle_typeCode"].ToString();
                cmbBxGender.Text = result.Tables["types"].Rows[0]["Gender"].ToString();
                CmbAvailable.SelectedValue = result.Tables["types"].Rows[0]["Status"].ToString();

            }
            else
            {
                MessageBox.Show("No data found for the selected BicycleId.");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int Size = 0;
            int typeCode = 0;
            string[] fields = { CmbBicycleId.Text, (txtBxSize.Text).ToString(), txtBxModel.Text, CmbAvailable.Text, cmbBxGender.Text };
            string[] fieldNames = { "BicycleID", "Size", "Model", "Availability", "Gender" };
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
                if (!int.TryParse(txtTypeCode.Text, out typeCode) || typeCode <= 0)
                {
                    throw new FormatException("Please input a Valid Unique TypeCode");
                    return;
                }
                if (Utility.ContainsNumber(txtBxModel.Text))
                {
                    throw new FormatException("The model of a bicycle cannot contain any numbers ");

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bicycles UpdatedBicycle = new Bicycles(CmbBicycleId.Text, cmbBxGender.Text.TrimEnd(), Size, txtBxModel.Text.TrimEnd(), CmbAvailable.Text.TrimEnd(), Convert.ToInt32(txtTypeCode.Text.TrimEnd()));
            UpdatedBicycle.UpdateBicycle();
            Bicycles.displayBicycleOnGrid(dataGridView1);
            ;
        }

    }
}


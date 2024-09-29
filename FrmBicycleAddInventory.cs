using System.Data;

namespace BicycleManagementSystem
{
    public partial class FrmAddBicycleInventory : Form
    {

        public FrmAddBicycleInventory()
        {
            InitializeComponent();

        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            CmbTypeCode.DataSource = Bicycle_type.gettypeCodes();
            cmbAvail.Items.Add("A");
            cmbAvail.Items.Add("NA");
            cmBGender.Items.Add("M");
            cmBGender.Items.Add("F");
            cmBGender.Items.Add("UNI");

            Bicycles.displayBicycleOnGrid(dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String TypeID= TxtBicycleTypeID.Text;
            int selectedTypeCode = (int)CmbTypeCode.SelectedValue;
            if (Bicycles.IsValidForAdding(selectedTypeCode))
            {
                String GeneratedId = Bicycles.GenerateBicycleID(selectedTypeCode.ToString(),TypeID);
                txtbxBicycleID.Text = GeneratedId;
                DataSet result = Bicycle_type.FindTypes(selectedTypeCode);
                if (result.Tables["types"].Rows.Count > 0)
                {
                    TxtBicycleTypeID.Text = result.Tables["types"].Rows[0]["Bicycle_type"].ToString();
                    txtbxBicycleID.Text = GeneratedId;
                }
            }
            else
                MessageBox.Show("Sorry This Bicycle Type is Currently Unavailable");




        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
            ;
            int Size;
            string[] fields = { CmbTypeCode.SelectedIndex.ToString(), txtbxBicycleID.Text, txtBxSize.Text, txtbxModel.Text, cmbAvail.Text, cmBGender.Text };
            string[] fieldNames = { "TypeCode", "BicycleID", "Size", "Model", "Availability", "Gender" };
            string ErrorMessageEmpty = Utility.GetEmptyFieldMessage(fields, fieldNames);

            if (ErrorMessageEmpty != null)
            {
                MessageBox.Show(ErrorMessageEmpty);
                return;
            }
            if (cmbAvail.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid status for this bicycle");
                return;
            }
            if (cmBGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Gender for this bicycle");
                return;
            }


            if (!int.TryParse(txtBxSize.Text, out Size) || Size <= 0)
            {
                MessageBox.Show("Please enter a valid positive whole number for the size in inches", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {

                Bicycles Bicycle = new Bicycles(txtbxBicycleID.Text.TrimEnd(), cmBGender.Text.TrimEnd(), Size, txtbxModel.Text.TrimEnd(), cmbAvail.Text.TrimEnd(), Convert.ToInt32(CmbTypeCode.Text.Trim()));
                Bicycle.addBicycle();
                Bicycles.displayBicycleOnGrid(dataGridView1);
                txtbxBicycleID.Clear();
                MessageBox.Show("This bicycle has been added to the inventory try adding another");
            }


        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }
    }


}




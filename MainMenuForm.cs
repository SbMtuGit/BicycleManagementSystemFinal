namespace BicycleManagementSystem
{
    public partial class mnuMainMenu : Form
    {

        public mnuMainMenu()
        {
            InitializeComponent();
        }

        private void testDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            testDB nextform = new testDB();
            nextform.ShowDialog();
            this.Show();
        }

        private void setBicycleMnu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSetBicycleType nextForm = new frmSetBicycleType();
            nextForm.ShowDialog();
            this.Show();
        }

        private void UpdateMnuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUpdateBicycleType nextform = new FrmUpdateBicycleType();
            nextform.ShowDialog();
            this.Show();
        }

        private void RemoveMnuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRemoveBicycleType nextform = new FrmRemoveBicycleType();
            nextform.ShowDialog();
            this.Show();
        }

        private void addBiMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmAddBicycleInventory nextform = new FrmAddBicycleInventory();
            nextform.ShowDialog();
            this.Show();
        }

        private void updateBicMnuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUpdateInventory nextform = new FrmUpdateInventory();
            nextform.ShowDialog();
            this.Show();
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmBooking nextform = new FrmBooking();
            nextform.ShowDialog();
            this.Show();
        }

        private void makeBookingMnuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBooking nextform = new FrmBooking();
            nextform.ShowDialog();
            this.Show();
        }

        private void cancelBookingMnuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCancelBooking nextform = new FrmCancelBooking();
            nextform.ShowDialog();
            this.Show();


        }

        private void bicycleReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmRevenueReport nextform = new FrmRevenueReport();
            nextform.ShowDialog();
            this.Show();
        }

        private void removeBicycleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmRemoveBicycleInventory nextform = new FrmRemoveBicycleInventory();
            nextform.ShowDialog();
            this.Show();

        }

        private void revenueReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmRevenueReport nextform = new FrmRevenueReport();
            nextform.ShowDialog();
            this.Show();
        }

        private void collectBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Record_Collection nextform = new Frm_Record_Collection();
            nextform.ShowDialog();
            this.Show();
        }

        private void returnBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRecord_Return nextform = new FrmRecord_Return();
            nextform.ShowDialog();
            this.Show();


        }

        private void mnuMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

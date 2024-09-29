using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Globalization;

namespace BicycleManagementSystem
{



    public partial class FrmBooking : Form
    {
        Bicycles Bicycle = new Bicycles();

        Basket Basket = new Basket();
        Booking booking = new Booking();
        public FrmBooking()
        {
            InitializeComponent();

        }
        private void FrmBooking_Load(object sender, EventArgs e)
        {

            cmbBicycleType.DataSource = Booking.getBicycleIDS();
            cmbGender.DataSource = Booking.GetAllGenders();
            cmBxTime.Items.Add("10.15");
            cmBxTime.Items.Add("10.30");
            cmBxTime.Items.Add("10.45");
            cmBxTime.Items.Add("11.00");
            cmBxTime.Items.Add("11.15");
            cmBxTime.Items.Add("11.30");
            cmBxTime.Items.Add("11.45");
            cmBxTime.Items.Add("12.00");
            cmBxTime.Items.Add("12.15");
            cmBxTime.Items.Add("12.30");
            cmBxTime.Items.Add("12.45");
            cmBxTime.Items.Add("13.00");
            cmBxTime.Items.Add("13.15");
            cmBxTime.Items.Add("13.30");
            cmBxTime.Items.Add("13.45");
            cmBxTime.Items.Add("14.00");
            cmBxTime.Items.Add("14.15");
            cmBxTime.Items.Add("14.30");
            cmBxTime.Items.Add("14.45");
            cmBxTime.Items.Add("15.00");
            cmBxTime.Items.Add("15.15");
            cmBxTime.Items.Add("15.30");
            cmBxTime.Items.Add("15.45");
            cmBxTime.Items.Add("16.00");
            cmBxTime.Items.Add("16.15");
            cmBxTime.Items.Add("16.30");
            cmBxTime.Items.Add("16.45");
            cmBxTime.Items.Add("17.00");
            cmBxTime.Items.Add("17.15");
            cmBxTime.Items.Add("17.30");
            cmBxTime.Items.Add("17.45");
            cmBxTime.Items.Add("18.00");

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int BookingID = Booking.GetNextBookingID();

        private void btnAddBicycleord_Click(object sender, EventArgs e)
        {

            if (BicycleGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bicycle from the list.");
                return;
            }


            DataGridViewRow selectedRow = BicycleGrid.SelectedRows[0];
            string bicycleId = selectedRow.Cells["BicycleId"].Value.ToString();
            string bicycleType = selectedRow.Cells["BicycleType"].Value.ToString();
            string gender = selectedRow.Cells["Gender"].Value.ToString();
            string selectedTimeString = cmBxTime.SelectedItem.ToString();
            decimal bookingTime = Convert.ToDecimal(selectedTimeString);
            decimal dailyRate = Convert.ToDecimal(selectedRow.Cells["DailyRate"].Value);
            TimeSpan rentalDuration = dtReturnDate.Value - dtCollectionTime.Value;
            int rentalDays = (int)rentalDuration.TotalDays;
            if (rentalDuration.TotalDays < 1)
            {
                rentalDays = 1;
            }
            else
            {
                rentalDays = (int)rentalDuration.TotalDays;
            }
            decimal calculatedPrice = Basket.CalculateItemPrice(dailyRate, rentalDays);
            BasketItems newItem = new BasketItems(bicycleId, bicycleType, dailyRate, bookingTime, dtCollectionTime.Value, dtReturnDate.Value, calculatedPrice);
            if (string.IsNullOrWhiteSpace(bicycleType) || string.IsNullOrWhiteSpace(bicycleId) || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please select a valid bicycle from the list.");
                return;
            }
            if (String.IsNullOrEmpty(cmBxTime.Text))
            {
                MessageBox.Show("Please select a time you you like to collect your Booking ");
            }
            if (dtCollectionTime.Value == dtReturnDate.Value)
            {
                MessageBox.Show("The Collection Date and the return date must not be the same.");
                return;
            }

            if (Basket.BicycleIdExistsInBasket(newItem.BicycleID))
            {
                MessageBox.Show("This bicycle is already in the basket.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                Basket.items.Add(newItem);
                DgvBasket.DataSource = null;
                DgvBasket.DataSource = Basket.items;
                MessageBox.Show("Bicycle added to the basket successfully!");
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)

        {

            String selectedType = (String)cmbBicycleType.SelectedValue;
            DataSet result = Booking.FindTypes(selectedType);
            Booking.displayBicycleOnGrid(BicycleGrid, cmbBicycleType.Text, cmbGender.Text);
        }

        private void dtCollectionTime_ValueChanged(object sender, EventArgs e)
        {
            dtCollectionTime.MinDate = DateTime.Today;
            dtReturnDate.MinDate = DateTime.Today;
            dtCollectionTime.CustomFormat = "MM/dd/yyyy";
            dtCollectionTime.CustomFormat = "MM/dd/yyyy";
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            if (DgvBasket.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bicycle from the basket.");
                return;
            }

            DataGridViewRow DifferentRow = BicycleGrid.SelectedRows[0];
            DataGridViewRow selectedRow = DgvBasket.SelectedRows[0];
            string ID = selectedRow.Cells["BicycleId"].Value.ToString();
            decimal dailyRate = Convert.ToDecimal(DifferentRow.Cells["DailyRate"].Value);
            decimal bookingTime = Convert.ToDecimal(cmBxTime.SelectedItem.ToString(), CultureInfo.InvariantCulture);
            TimeSpan rentalDuration = dtReturnDate.Value - dtCollectionTime.Value;
            string firstName = txtBxFirstName.Text;
            string secondName = txtBxSecondName.Text;
            string telephone = txtBxTelephone.Text;
            decimal calculatedPrice = 0;
            foreach (var item in Basket.items)
            {
                calculatedPrice += item.calculatedPrice;
            }


            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                conn.Open();
                OracleTransaction transaction = conn.BeginTransaction();

                try
                {
                    Booking.AddBooking(BookingID, dtCollectionTime.Value, dtReturnDate.Value, Basket.GetItemCount(), "AWAITING", calculatedPrice, ID, firstName, secondName, telephone, bookingTime);
                    Basket.AddBasketToRentedBicycles(BookingID, Basket);
                    transaction.Commit();
                    MessageBox.Show("Booking successful!");
                    MessageBox.Show("Thank you for Booking with us! Please feel free to make another booking.");
                    DgvBasket.Refresh();
                }
                catch (OracleException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error during booking The Bicycle " + ID + " Is not available on your chosen dates ");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DgvBasket.SelectedRows.Count > 0)
            {

                BasketItems selectedItem = DgvBasket.SelectedRows[0].DataBoundItem as BasketItems;

                Basket.RemoveItem(selectedItem);
                DgvBasket.DataSource = null;
                DgvBasket.DataSource = Basket.items;
                DgvBasket.Refresh();
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the basket.");
            }



        }

    
    }

}








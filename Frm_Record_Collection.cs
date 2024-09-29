namespace BicycleManagementSystem
{
    public partial class Frm_Record_Collection : Form
    {
        int BookingId;
        String FirstName;
        String LastName;
        String TelephoneNUmber;
        Booking Collect = new Booking();
        public Frm_Record_Collection()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (!int.TryParse(TxtBookingId.Text, out BookingId))
            {
                MessageBox.Show("Booking ID must be a whole number.");
                isValid = false;
            }

            Booking.getBookingInfoByID(DgvBookingInfo, BookingId);


        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnFrgBookingID_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            String FirstName = TxtFirstName.Text;
            String LastName = TxtLastName.Text;
            String TelephoneNUmber = TxtTelePhoneNumber.Text;



            if (FirstName.Any(char.IsDigit))
            {
                MessageBox.Show("First name must not contain any digits.");
                isValid = false;
            }

            if (LastName.Any(char.IsDigit))
            {
                MessageBox.Show("Last name must not contain any digits.");
                isValid = false;
            }

            if (TelephoneNUmber.Length > 10)
            {
                MessageBox.Show("Telephone number should not be greater than ten.");
                isValid = false;
            }

            if (isValid)
            {
                Booking.getBookingInfo(DgvBookingInfo, FirstName, LastName, TelephoneNUmber);
            }
        }

        private void BtnCollect_Click(object sender, EventArgs e)
        {
            if (DgvBookingInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bicycle from the list.");
                return;
            }
            int bookingId = Convert.ToInt32(DgvBookingInfo.SelectedRows[0].Cells["Booking_ID"].Value);
            if (Collect.IsBookingCollected(bookingId))
            {
                MessageBox.Show("This booking has already been collected.");
                return; 
            }
            MessageBox.Show("Your Booking " + TxtBookingId.Text + "has now been marked as collected thank you for cycling with us");
            DataGridViewRow selectedRow = DgvBookingInfo.SelectedRows[0];
            string BookingId = selectedRow.Cells["Booking_ID"].Value.ToString();
            Booking.Collect_booking(Convert.ToInt32(BookingId));
        }
    }
}

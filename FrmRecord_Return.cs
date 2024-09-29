namespace BicycleManagementSystem
{
    public partial class FrmRecord_Return : Form
    {
        Booking Return = new Booking();
        public FrmRecord_Return()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int BookingId;
            bool isValid = true;
            if (!int.TryParse(txtBookingId.Text, out BookingId))
            {
                MessageBox.Show("Booking ID must be a whole number.");
                isValid = false;
            }
            Booking.getBookingInfoByID(DGvReturnInfo, BookingId);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text;
            String LastName = txtSecondName.Text;
            String TelePhoneNumber = txtTelePhone.Text;

            bool isValid = true;
            if (FirstName.Any(char.IsDigit))
            {
                MessageBox.Show("First name must not contain any digits.");
                isValid = false;
                return;
            }

            if (LastName.Any(char.IsDigit))
            {
                MessageBox.Show("Last name must not contain any digits.");
                isValid = false;
                return;
            }

            if (TelePhoneNumber.Length > 10)
            {
                MessageBox.Show("Telephone number should not be greater than ten.");
                isValid = false;
                return;
            }

      
            if (isValid)
            {
                Booking.getBookingInfo(DGvReturnInfo, FirstName, LastName, TelePhoneNumber);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int BookingId;
            bool isValid = true;
            if (!int.TryParse(txtBookingId.Text, out BookingId))
            {
                MessageBox.Show("Booking ID must be a whole number. If you have searched for you booking by name and number please enter the booking Id above to continue ");
                isValid = false;

            }
            if(Booking.isLate(BookingId))
            {
                MessageBox.Show("This booking has been returned late Please return the the kiosk to pay for late fee");
            }
            Booking.Return_Booking(BookingId);
            MessageBox.Show("Thank you for Returing Your Booking");
        }
    }
}


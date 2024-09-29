namespace BicycleManagementSystem
{

    public partial class FrmCancelBooking : Form
    {
        Booking Cancellation = new Booking();
        public FrmCancelBooking()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCancelBooking_Load(object sender, EventArgs e)
        {


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int BookingId = Convert.ToInt32(txtBoxBicycleID.Text);
            Cancellation.GetbookingForCancellation(BookingId, dGvBookings);



        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int BookingId = Convert.ToInt32(txtBoxBicycleID.Text);
            Booking.CancelBooking(BookingId);

            MessageBox.Show("Your Booking" + BookingId + "has been cancelled thank you.");
        }

    }

}



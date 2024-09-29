namespace BicycleManagementSystem
{
    internal class RentedBicycles
    {
        public string BicycleId { get; set; }
        public int BookingId { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public char Status { get; set; }


        public RentedBicycles()
        {

            BicycleId = string.Empty;
            BookingId = 0;
            CollectionDate = DateTime.MinValue;
            ReturnDate = DateTime.MinValue;
            Status = '\0';
        }


        public RentedBicycles(string bicycleId, int bookingId, DateTime collectionDate, DateTime returnDate, char status)
        {

            BicycleId = bicycleId;
            BookingId = bookingId;
            CollectionDate = collectionDate;
            ReturnDate = returnDate;
            Status = status;
        }

    }
}

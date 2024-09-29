
using Oracle.ManagedDataAccess.Client;

namespace BicycleManagementSystem
{
    public class Basket
    {
        public List<BasketItems> items { get; set; } = new List<BasketItems>();

        public bool BicycleIdExistsInBasket(string bicycleId)
        {
            return items.Any(item => string.Equals(item.BicycleID, bicycleId));
        }
        public void AddBasketToRentedBicycles(int bookingId, Basket basket)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                conn.Open();

                foreach (var item in basket.items)
                {
                    string Status = "AWAITING";
                    string sqlQuery = "INSERT INTO RentedBicycles (Bicycle_ID, Booking_ID, Collection_Dates, Return_Date, Status) "+
                               " VALUES (:BicycleId, :BookingId, :Collection_Date, :Due_Date, :Status)";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(":BicycleId", OracleDbType.Varchar2).Value = item.BicycleID;
                        cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                        cmd.Parameters.Add(":Collection_Date", OracleDbType.Date).Value = item.CollectionDate;
                        cmd.Parameters.Add(":DueDate", OracleDbType.Date).Value = item.due_Date;
                        cmd.Parameters.Add(":Status", OracleDbType.Varchar2).Value = Status;

                        cmd.ExecuteNonQuery();
                    }


                }
            }
        }

        public decimal CalculateItemPrice(decimal dailyRate, int rentalDays)
        {

            return dailyRate * rentalDays;
        }

        public int GetItemCount()
        {
            return items.Count;
        }

        public void RemoveItem(BasketItems newItem)
        {
            if (!BicycleIdExistsInBasket(newItem.BicycleID))
            {
                MessageBox.Show("This Bicycle is Not present in your current Basekt", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                items.Remove(newItem);
        }
    }
}




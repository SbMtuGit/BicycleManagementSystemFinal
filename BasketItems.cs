namespace BicycleManagementSystem
{
    public class BasketItems
    {
        public string BicycleID { get; set; }
        public string BicycleType { get; set; }
        public decimal DailyRate { get; set; }
        public decimal collectiontime { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime due_Date { get; set; }
        public decimal calculatedPrice { get; set; }

        public BasketItems(string bicycleId, string bicycleType, decimal dailyRate, decimal collectionTime, DateTime collectionDate, DateTime dueDate, decimal calculatedP)
        {
            BicycleID = bicycleId;
            BicycleType = bicycleType;
            DailyRate = dailyRate;
            collectiontime = collectionTime;
            CollectionDate = collectionDate;
            due_Date = dueDate;
            calculatedPrice = calculatedP;

        }
    }
}












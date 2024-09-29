using Microsoft.VisualBasic;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BicycleManagementSystem
{

    public class Booking
    {
        private int bookingID;
        private DateTime collectionDate;
        private DateTime dueDate;
        private int quantity;
        private string bookingStatus;
        private string paymentStatus;
        private decimal paidAmount;
        private String firstname;
        private String lastname;
        private String telephoneNumber;
        public Booking()
        {

        }
        public Booking(int bookingID, DateTime collectionDate, DateTime dueDate, int quantity, string bookingStatus, string paymentStatus, decimal paidAmount, string bicycleId, string firstName, string lastName, String telephoneNumber)

        {
            this.bookingID = bookingID;
            this.collectionDate = collectionDate;
            this.dueDate = dueDate;
            this.quantity = quantity;
            this.bookingStatus = bookingStatus;
            this.paymentStatus = paymentStatus;
            this.paidAmount = paidAmount;
            this.firstname = firstName;
            this.lastname = lastName;
            this.telephoneNumber = telephoneNumber;
        }

        public int getBookingID() { return this.bookingID; }
        public DateTime getCollectionDate() { return this.collectionDate; }
        public DateTime getDueDate() { return this.dueDate; }
        public int getQuanityt() { return this.quantity; }
        public string getBookingStatus() { return this.bookingStatus; }

        public String getPaymentStatus() { return this.paymentStatus; }
        public decimal getPaidAmount() { return this.paidAmount; }


        public void setBookingID(int bookingID) { this.bookingID = bookingID; }
        public void setCollectionDate(DateTime collectionDate) { this.collectionDate = collectionDate; }
        public void setDueDate(DateTime DueDate) { this.dueDate = DueDate; }
        public void setQuanity(int quantity) { this.quantity = quantity; }
        public void setPaymentStatus(string paymentStatus) { this.paymentStatus = paymentStatus; }
        public void setPaidAmount(decimal PaidAmount) { this.paidAmount = PaidAmount; }

        public static void getBicycleTypes()
        {
            OracleConnection conn = new OracleConnection(Utility.oraDB);
            string SQLQuery = "SELECT * FROM Bicycle_Types WHERE Bicycle_TypeCode = Bicycle_TypeCode ";
            OracleCommand cmd = new OracleCommand(SQLQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
        }
        public static string[] getBicycleIDS()
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
              
                string sqlQuery = "SELECT DISTINCT Bicycle_type FROM bicycle_Types ORDER BY Bicycle_type";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();

                    List<string> Types = new List<string>();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string DBType = reader.GetString(0);
                            Types.Add(DBType);
                        }
                    }

                    return Types.ToArray();
                }
            }
        }
        public static DataSet GetAllBicycles()
        {
            OracleConnection conn = new OracleConnection(Utility.oraDB);

            string sqlQuery = "SELECT BicycleId, Gender, Bsize, Bmodel, Status, Bicycle_typeCode FROM Bicycles ORDER BY BicycleId";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "bicycles");
            conn.Close();
            return ds;
        }
        public static string[] GetAllGenders()
        {
            DataSet bicyclesDataSet = GetAllBicycles();
            DataTable bicyclesTable = bicyclesDataSet.Tables["bicycles"];
            string[] genders = new string[3];
            int index = 0;
            foreach (DataRow row in bicyclesTable.Rows)
            {
                string gender = row["Gender"].ToString();
                if (Array.IndexOf(genders, gender, 0, index) == -1)
                {
                    genders[index++] = gender;
                }
            }
            return genders;
        }
        public static void AddBooking(int bookingId, DateTime collectionDate, DateTime dueDate, int quantity, string bookingStatus, decimal paidAmount, string bicycleId, string firstName, string lastName, string telephoneNumber, decimal booktime)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                conn.Open();


                string availabilityCheckQuery = @"SELECT * 
                                          FROM RentedBicycles rb
                                          JOIN Bookings b ON rb.Booking_ID = b.BookingId
                                          WHERE Bicycle_ID = :bicycleId
                                            AND ( (:collectionDate BETWEEN b.Collection_Date AND b.Due_Date) 
                                            OR (:dueDate BETWEEN b.Collection_Date AND b.Due_Date) 
                                            OR (b.Collection_Date BETWEEN :collectionDate AND :dueDate))";
                using (var availabilityCmd = new OracleCommand(availabilityCheckQuery, conn))
                {
                    availabilityCmd.Parameters.Add(":bicycleId", OracleDbType.Varchar2).Value = bicycleId;
                    availabilityCmd.Parameters.Add(":collectionDate", OracleDbType.Date).Value = collectionDate;
                    availabilityCmd.Parameters.Add(":dueDate", OracleDbType.Date).Value = dueDate;

                    var reader = availabilityCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return;
                    }
                }
                string insertQuery = @"INSERT INTO Bookings (BookingId, Collection_Date, Due_Date, Quantity, Booking_Status, PaidAmount, BookingTime, BicycleID, FirstName, LastName, TelephoneNumber) 
                               VALUES (:BookingId, TO_DATE(:CollectionDate, 'MM/dd/yyyy'), TO_DATE(:DueDate, 'MM/dd/yyyy'), :Quantity, :BookingStatus, :PaidAmount, :BookingTime, :BicycleID, :FirstName, :LastName, :TelephoneNumber)";

                using (var insertCmd = new OracleCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                    insertCmd.Parameters.Add(":CollectionDate", OracleDbType.Varchar2).Value = collectionDate.ToString("MM/dd/yyyy");
                    insertCmd.Parameters.Add(":DueDate", OracleDbType.Varchar2).Value = dueDate.ToString("MM/dd/yyyy");
                    insertCmd.Parameters.Add(":Quantity", OracleDbType.Int32).Value = quantity;
                    insertCmd.Parameters.Add(":BookingStatus", OracleDbType.Varchar2).Value = bookingStatus;
                    insertCmd.Parameters.Add(":PaidAmount", OracleDbType.Decimal).Value = paidAmount;
                    insertCmd.Parameters.Add(":BookingTime", OracleDbType.Decimal).Value = booktime;
                    insertCmd.Parameters.Add(":BicycleID", OracleDbType.Varchar2).Value = bicycleId;
                    insertCmd.Parameters.Add(":FirstName", OracleDbType.Varchar2).Value = firstName;
                    insertCmd.Parameters.Add(":LastName", OracleDbType.Varchar2).Value = lastName;

                    insertCmd.Parameters.Add(":TelephoneNumber", OracleDbType.Varchar2).Value = telephoneNumber;



                    insertCmd.ExecuteNonQuery();
                }


                string updateBicycleQuery = @"UPDATE Bicycles 
                                      SET Status = 'BOOKED'
                                      WHERE BicycleId = :bicycleId";
                using (var updateBicycleCmd = new OracleCommand(updateBicycleQuery, conn))
                {
                    updateBicycleCmd.Parameters.Add(":bicycleId", OracleDbType.Varchar2).Value = bicycleId;
                    updateBicycleCmd.ExecuteNonQuery();
                }
            }
        }

        public void GetbookingForCancellation(int BookingId, DataGridView dg)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                String sqlQuery = "SELECT firstName, LastName, TelephoneNumber, PaidAmount ,BicycleId,Collection_Date,BookingTime " +
                                  "FROM Bookings " +
                                  "WHERE BookingId = :BookingId";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = BookingId;
                    conn.Open();

                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        if (dg.Columns.Count == 0)
                        {

                            dg.Columns.Add("FirstName", "First Name");
                            dg.Columns.Add("LastName", "Last Name");
                            dg.Columns.Add("TelephoneNumber", "Telephone Number");
                            dg.Columns.Add("BicycleId", "BicycleID");
                            dg.Columns.Add("Collection_Date", "Collection_Date");
                            dg.Columns.Add("BookingTime", "BookTime");
                            dg.Columns.Add("PaidAmount", "Paid Amount");
                        }

                        dg.Rows.Clear();

                        while (dr.Read())
                        {

                            dg.Rows.Add(dr["firstName"].ToString(),
                                        dr["LastName"].ToString(),
                                        dr["TelephoneNumber"].ToString(),
                                        dr["BicycleId"].ToString(),
                                        dr["Collection_Date"].ToString(),
                                        dr["BookingTime"].ToString(),
                                        dr["PaidAmount"].ToString());
                        }
                    }
                }
            }
        }

        public static DataSet FindTypes(String type)
        {
            OracleConnection conn = new OracleConnection(Utility.oraDB);
            String sqlQuery = "SELECT BICYCLE_TYPES.Description, BICYCLE_TYPES.DailyRate, BICYCLES.BicycleId, BICYCLES.Gender " +
                        "FROM BICYCLE_TYPES " +
                        "JOIN BICYCLES ON BICYCLE_TYPES.Bicycle_typeCode = BICYCLES.Bicycle_typeCode " +
                        "WHERE BICYCLE_TYPES.Bicycle_type LIKE '%" + type + "%' " +
                        "ORDER BY DBMS_RANDOM.VALUE";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "types");
            conn.Close();
            return ds;
        }
        public static int GetNextBookingID()
        {
            int nextId = 0000;

            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                string sqlQuery = "SELECT MAX(BookingID) FROM Bookings";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();

                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read() && !dr.IsDBNull(0))
                        {
                            nextId = dr.GetInt32(0) + 1;
                        }
                        else
                        {
                            nextId++;
                        }
                    }
                }
            }

            return nextId;
        }
        public static void CancelBooking(int bookingId)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                conn.Open();

                string SqlQuery = @"UPDATE Bookings 
                                   SET Booking_Status = 'CANCELLED', 
                                    Refunded_Amt = PaidAmount
                                    WHERE BookingId = :BookingId";
                ;

                using (OracleCommand cmd = new OracleCommand(SqlQuery, conn))
                {
                    cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                    cmd.ExecuteNonQuery();
                }

                string Sqlquery = @"UPDATE Bicycles
                                   SET Status = 'A'
                                   WHERE BicycleId IN (SELECT Bicycle_ID 
                                   FROM RentedBicycles
                                   WHERE Booking_ID = :BookingId)";

                using (OracleCommand cmd = new OracleCommand(Sqlquery, conn))
                {
                    cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                    cmd.ExecuteNonQuery();
                }
                string sqlQuery = @"UPDATE RentedBicycles
                                  SET Status = 'CANCELLED'
                                  WHERE Booking_ID = :BookingId";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                    cmd.ExecuteNonQuery();
                }


            }

        }
        public bool IsBookingCollected(int bookingId)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                conn.Open();

                string sqlQuery = @"SELECT Booking_Status FROM Bookings WHERE BookingId = :bookingId";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":bookingId", OracleDbType.Int32).Value = bookingId;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string status = reader.GetString(reader.GetOrdinal("Booking_Status"));
                            return status == "COLLECTD";
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
   public static bool isLate(int bookingId)
        {
                using (OracleConnection conn = new OracleConnection(Utility.oraDB))
                {
                    conn.Open();

                    string sqlQuery = @"SELECT Booking_Status, Due_Date FROM Bookings WHERE BookingId = :bookingId";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(":bookingId", OracleDbType.Int32).Value = bookingId;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string status = reader.GetString(reader.GetOrdinal("Booking_Status"));
                                DateTime dueDate = reader.GetDateTime(reader.GetOrdinal("Due_Date"));

                                if (status == "LATE")
                                {
                                    return true; 
                                }
                                else if (DateTime.Now > dueDate)
                                {
                                    return true;  
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false; 
                            }
                        }
                    }
                }
            }

        

        public static void Return_Booking(int bookingId)
        {

            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                conn.Open();

                string sqlQuery = @"UPDATE Bookings 
                            SET Booking_Status = 
                            CASE 
                            WHEN CURRENT_DATE >= Due_Date THEN 'LATE' 
                            ELSE 'RETURNED' 
                            END
                            WHERE BookingID = :BookingId";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                    cmd.ExecuteNonQuery();

                    {
                        string Sqlquery = @"UPDATE Bicycles
                                  SET Status = 'A'
                                  WHERE BicycleId IN (SELECT Bicycle_ID 
                                  FROM RentedBicycles
                                  WHERE Booking_ID = :BookingId)";

                        using (OracleCommand Cmd = new OracleCommand(Sqlquery, conn))
                        {
                            Cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                            Cmd.ExecuteNonQuery();
                        }
                        string sqlquery = @"UPDATE RentedBicycles
                                SET Status = 'RETURNED'
                                WHERE Booking_ID = :BookingId 
                                                            ";

                        using (OracleCommand Cmd = new OracleCommand(sqlquery, conn))
                        {
                            Cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                            Cmd.ExecuteNonQuery();
                        }
                    }

                }
            }
        }
    


        
        public static void Collect_booking(int bookingId)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                conn.Open();

                string SqlQuery = @"UPDATE Bookings 
                                  SET Booking_Status = 'COLLECTD'
                                  WHERE BookingID = :BookingId";

                using (OracleCommand cmd = new OracleCommand(SqlQuery, conn))
                {
                    cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                    cmd.ExecuteNonQuery();
                }


                string Sqlquery = @"UPDATE Bicycles
                                   SET Status = 'NA'
                                   WHERE BicycleId IN (SELECT Bicycle_ID 
                                   FROM RentedBicycles
                                   WHERE Booking_ID = :BookingId)";

                using (OracleCommand cmd = new OracleCommand(Sqlquery, conn))
                {
                    cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                    cmd.ExecuteNonQuery();
                }
                string sqlQuery = @"UPDATE RentedBicycles
                                SET Status = 'ACTIVE'
                                WHERE Booking_ID = :BookingId 
                                                            ";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":BookingId", OracleDbType.Int32).Value = bookingId;
                    cmd.ExecuteNonQuery();
                }


            }

        }

        public static void displayBicycleOnGrid(DataGridView dg, string selectedType, string selectedGender)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                string sqlQuery = @"SELECT B.BicycleId, B.Gender, B.BSize, B.BModel, B.Status,  BT.Bicycle_Type, BT.DailyRate
                            FROM Bicycles B
                            INNER JOIN Bicycle_Types BT ON B.Bicycle_TypeCode = BT.Bicycle_TypeCode
                            WHERE BT.Bicycle_Type = :selectedType AND B.Gender = :selectedGender ";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":selectedType", OracleDbType.Varchar2).Value = selectedType;
                    cmd.Parameters.Add(":selectedGender", OracleDbType.Varchar2).Value = selectedGender;

                    conn.Open();

                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        if (dg.Columns.Count == 0)
                        {
                            dg.Columns.Add("BicycleId", "Bicycle Id");
                            dg.Columns.Add("Gender", "Gender");
                            dg.Columns.Add("Size", "Size");
                            dg.Columns.Add("Model", "Model");
                            dg.Columns.Add("Status", "Status");
                            dg.Columns.Add("BicycleType", "Bicycle Type");
                            dg.Columns.Add("DailyRate", "DailyRate");
                        }

                        dg.Rows.Clear();

                        while (dr.Read())
                        {
                            dg.Rows.Add(dr["BicycleId"], dr["Gender"], dr["BSize"], dr["BModel"], dr["Status"], dr["Bicycle_Type"], dr["DailyRate"]);


                        }
                    }
                }
            }




        }
        public static void getBookingInfo(DataGridView dg, String FirstName, String LastName, String TelephoneNumber)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                conn.Open();

                string sqlBookingQuery = @"SELECT * FROM Bookings WHERE FirstName = :firstName AND LastName = :lastName AND TelephoneNumber = :telephoneNumber";

                using (OracleCommand bookingCmd = new OracleCommand(sqlBookingQuery, conn))
                {
                    bookingCmd.Parameters.Add(":firstName", OracleDbType.Varchar2).Value = FirstName;
                    bookingCmd.Parameters.Add(":lastName", OracleDbType.Varchar2).Value = LastName;
                    bookingCmd.Parameters.Add(":telephoneNumber", OracleDbType.Varchar2).Value = TelephoneNumber;

                    using (OracleDataReader bookingReader = bookingCmd.ExecuteReader())
                    {
                        if (bookingReader.Read())
                        {
                            int bookingID = bookingReader.GetInt32(bookingReader.GetOrdinal("BookingId"));
                            DateTime collectionDate = bookingReader.GetDateTime(bookingReader.GetOrdinal("Collection_Date"));

                            string sqlBicyclesQuery = @"SELECT RB.Bicycle_ID, B.Gender, B.BSize, B.BModel, BT.Bicycle_Type, BK.PaidAmount,BK Quantity
                                                FROM RentedBicycles RB
                                                INNER JOIN Bicycles B ON RB.Bicycle_ID = B.BicycleId
                                                INNER JOIN Bicycle_Types BT ON B.Bicycle_TypeCode = BT.Bicycle_typeCode
                                                INNER JOIN Bookings BK ON RB.Booking_ID = BK.BookingId
                                                WHERE BK.FirstName = :firstName AND BK.LastName = :lastName AND BK.TelephoneNumber = :telephoneNumber";

                            using (OracleCommand bicyclesCmd = new OracleCommand(sqlBicyclesQuery, conn))
                            {
                                bicyclesCmd.Parameters.Add(":firstName", OracleDbType.Varchar2).Value = FirstName;
                                bicyclesCmd.Parameters.Add(":lastName", OracleDbType.Varchar2).Value = LastName;
                                bicyclesCmd.Parameters.Add(":telephoneNumber", OracleDbType.Varchar2).Value = TelephoneNumber;

                                using (OracleDataReader bicyclesReader = bicyclesCmd.ExecuteReader())
                                {
                                    if (dg.Columns.Count == 0)
                                    {
                                        dg.Columns.Add("Booking_ID", "Booking ID");
                                        dg.Columns.Add("Collection_Date", "Collection Date");
                                        dg.Columns.Add("Bicycle_ID", "Bicycle ID");
                                        dg.Columns.Add("Gender", "Gender");
                                        dg.Columns.Add("BSize", "Size");
                                        dg.Columns.Add("BModel", "Model");
                                        dg.Columns.Add("Bicycle_Type", "Bicycle Type");
                                        dg.Columns.Add("PaidAmount", "Total Paid");
                                    }

                                    dg.Rows.Clear();

                                    while (bicyclesReader.Read())
                                    {
                                        dg.Rows.Add(
                                            bookingID,
                                            collectionDate,
                                            bicyclesReader["Bicycle_ID"],
                                            bicyclesReader["Gender"],
                                            bicyclesReader["BSize"],
                                            bicyclesReader["BModel"],
                                            bicyclesReader["Bicycle_Type"],
                                            bicyclesReader["PaidAmount"]
                                        );
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Booking not found.");
                        }
                    }
                }
            }
        }

        public static void getBookingInfoByID(DataGridView dg, int BookingID)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                conn.Open();

                string sqlBookingQuery = @"SELECT * FROM Bookings WHERE BookingId = :bookingId";

                using (OracleCommand bookingCmd = new OracleCommand(sqlBookingQuery, conn))
                {
                    bookingCmd.Parameters.Add(":bookingId", OracleDbType.Int32).Value = BookingID;

                    using (OracleDataReader bookingReader = bookingCmd.ExecuteReader())
                    {
                        if (bookingReader.Read())
                        {
                            DateTime collectionDate = bookingReader.GetDateTime(bookingReader.GetOrdinal("Collection_Date"));

                            string sqlBicyclesQuery = @"SELECT RB.Bicycle_ID, B.Gender, B.BSize, B.BModel, BT.Bicycle_Type, BK.PaidAmount
                                                FROM RentedBicycles RB
                                                INNER JOIN Bicycles B ON RB.Bicycle_ID = B.BicycleId
                                                INNER JOIN Bicycle_Types BT ON B.Bicycle_TypeCode = BT.Bicycle_typeCode
                                                INNER JOIN Bookings BK ON RB.Booking_ID = BK.BookingId
                                                WHERE RB.Booking_ID = :bookingId";

                            using (OracleCommand bicyclesCmd = new OracleCommand(sqlBicyclesQuery, conn))
                            {
                                bicyclesCmd.Parameters.Add(":bookingId", OracleDbType.Int32).Value = BookingID;

                                using (OracleDataReader bicyclesReader = bicyclesCmd.ExecuteReader())
                                {
                                    if (dg.Columns.Count == 0)
                                    {
                                        dg.Columns.Add("Booking_ID", "Booking ID");
                                        dg.Columns.Add("Collection_Date", "Collection Date");
                                        dg.Columns.Add("Bicycle_ID", "Bicycle ID");
                                        dg.Columns.Add("Gender", "Gender");
                                        dg.Columns.Add("BSize", "Size");
                                        dg.Columns.Add("BModel", "Model");
                                        dg.Columns.Add("Bicycle_Type", "Bicycle Type");
                                        dg.Columns.Add("PaidAmount", "Total Paid");
                                    }

                                    dg.Rows.Clear();

                                    while (bicyclesReader.Read())
                                    {
                                        dg.Rows.Add(
                                            BookingID,
                                            collectionDate,
                                            bicyclesReader["Bicycle_ID"],
                                            bicyclesReader["Gender"],
                                            bicyclesReader["BSize"],
                                            bicyclesReader["BModel"],
                                            bicyclesReader["Bicycle_Type"],
                                            bicyclesReader["PaidAmount"]
                                        );
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Booking not found.");
                        }
                    }
                }
            }
        }

    }
}


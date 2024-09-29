using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BicycleManagementSystem
{
    class Bicycle_type
    {
        private int Bicycle_typeCode;
        private String Bicycle_Type;
        private String Description;
        private Decimal Daily_rate;
        private String Status;


        public Bicycle_type()
        {
            this.Bicycle_typeCode = 0;
            this.Bicycle_Type = "";
            this.Description = "";
            this.Daily_rate = 0;
            this.Status = "";
        }

        public Bicycle_type(int Bicycle_TypeCode, String Bicycle_Type, String Description, Decimal Daily_rate, String Status)
        {
            this.Bicycle_typeCode = Bicycle_TypeCode;
            this.Bicycle_Type = Bicycle_Type;
            this.Description = Description;
            this.Daily_rate = Daily_rate;
            this.Status = Status;
        }

        public int GetBicycle_TypeCode() { return this.Bicycle_typeCode; }
        public String getBicycle_Type() { return this.Bicycle_Type; }
        public String getDescription() { return this.Description; }
        public decimal getDaily_rate() { return this.Daily_rate; }
        public String getStatus() { return this.Status; }

        public int getBicycle_TypeCode() { return this.Bicycle_typeCode; }
        public void setBicycle_Type(String Bicycle_type) { this.Bicycle_Type = Bicycle_type; }
        public void setDescription(String Description) { this.Description = Description; }
        public void setDaily_Rate(Decimal Daily_rate) { this.Daily_rate = Daily_rate; }
        public void setStatus(String Status) { this.Status = Status; }

        public void getBicycleTypes(int TypeCode)
        {
            OracleConnection conn = new OracleConnection(Utility.oraDB);
            string SQLQuery = "SELECT * FROM Bicycle_Types WHERE Bicycle_TypeCode = " + TypeCode;
            OracleCommand cmd = new OracleCommand(SQLQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
        }
        public void addBicycle_type()
        {
            OracleConnection conn = new OracleConnection(Utility.oraDB);
            String sqlQuery = "INSERT INTO BICYCLE_TYPES (Bicycle_TypeCode, Bicycle_Type, Description, DailyRate, Status) " +
           "VALUES (:bicycleTypeCode, :bicycleType, :description, :dailyRate, :status)";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(":bicycleTypeCode", OracleDbType.Int32).Value = this.Bicycle_typeCode;
            cmd.Parameters.Add(":bicycleType", OracleDbType.Varchar2).Value = this.Bicycle_Type;
            cmd.Parameters.Add(":description", OracleDbType.Varchar2).Value = this.Description;
            cmd.Parameters.Add(":dailyRate", OracleDbType.Decimal).Value = this.Daily_rate;
            cmd.Parameters.Add(":status", OracleDbType.Varchar2).Value = this.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void UpdateBicycle_type()
        {
            OracleConnection conn = new OracleConnection(Utility.oraDB);
            String sqlQuery = "UPDATE BICYCLE_TYPES SET " +
                              "BICYCLE_TYPE = '" + this.Bicycle_Type + "'," +
                               "Description = '" + this.Description + "'," +
                                "DailyRate = " + this.Daily_rate + "," +
                                "Status  = '" + this.Status + "' " +
                                "WHERE Bicycle_TypeCode = " + this.GetBicycle_TypeCode();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void RemoveBicycle_Type()
        {
            OracleConnection conn = new OracleConnection(Utility.oraDB);


            String sqlQuery = "UPDATE BICYCLE_TYPES SET " +
                                 "Status  = '" + this.Status + "' " +
                                     "WHERE Bicycle_TypeCode = " + this.GetBicycle_TypeCode();
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public static void DisplayBicycleTypesOnGrid(DataGridView dg)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                String sqlQuery = "SELECT  Bicycle_TypeCode, BICYCLE_TYPE, Description, DailyRate, Status " +
                                  "FROM Bicycle_Types " +
                                  "ORDER BY BICYCLE_TYPE";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();

                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        if (dg.Columns.Count == 0)
                        {

                            dg.Columns.Add("Bicycle_Code", "Bicycle_TypeCode");
                            dg.Columns.Add("BICYCLE_TYPE", "Bicycle Type");
                            dg.Columns.Add("Description", "Description");
                            dg.Columns.Add("Daily_rate", "Daily Rate");
                            dg.Columns.Add("Status", "Status");
                        }

                        dg.Rows.Clear();
                        while (dr.Read())
                        {
                            dg.Rows.Add(dr["Bicycle_TypeCode"].ToString(), dr["BICYCLE_TYPE"].ToString(), dr["Description"].ToString(), dr["DailyRate"].ToString(), dr["Status"].ToString());
                        }
                    }
                }
            }
        }
        public static int getNextBicycle_typeCode()
        {
            int nextId = 0000;

            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {

                string sqlQuery = "SELECT MAX(Bicycle_typeCode) FROM Bicycle_types";

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
            Console.WriteLine("Next Bicycle Type Code: " + nextId);
            return nextId;
        }
        public static int[] gettypeCodes()
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                String sqlQuery = "SELECT bicycle_TypeCode FROM bicycle_types";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();

                    List<int> TypeCode = new List<int>();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int DBTypes = reader.GetInt32(0);
                            TypeCode.Add(DBTypes);
                        }
                    }

                    conn.Close();

                    return TypeCode.ToArray();
                }
            }
        }
        public static DataSet FindTypes(int typeCode)
        {

            OracleConnection conn = new OracleConnection(Utility.oraDB);

            String sqlQuery = "SELECT Bicycle_TypeCode, Bicycle_type, Description, DailyRate, Status FROM Bicycle_types " +
          " Where Bicycle_TypeCode LIKE '%" + typeCode + "%' ORDER BY Bicycle_type";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "types");
            conn.Close();
            return ds;
        }

    }
}







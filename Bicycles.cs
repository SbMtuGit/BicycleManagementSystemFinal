using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BicycleManagementSystem
{
    class Bicycles
    {
        private string BicycleID;
        private string Gender;
        private int Size;
        private string Model;
        private string Status;
        private int TypeCode;

        public Bicycles()
        {

        }
        public Bicycles(string bicycleID, string gender, int size, string model, string status, int typeCode)
        {
            this.BicycleID = bicycleID;
            this.Gender = gender;
            this.Size = size;
            this.Model = model;
            this.Status = status;
            this.TypeCode = typeCode;
        }

        public string getBicycleID() { return this.BicycleID; }
        public string getGender() { return this.Gender; }
        public int getSize() { return this.Size; }
        public string getModel() { return this.Model; }
        public string getStatus() { return this.Status; }
        public int getTypeCode() { return this.TypeCode; }

        public void setBicycleID(string bicycleID) { this.BicycleID = bicycleID; }
        public void setGender(string gender) { this.Gender = gender; }
        public void setSize(int size) { this.Size = size; }
        public void setModel(string model) { this.Model = model; }
        public void setStatus(string status) { this.Status = status; }
        public void setTypeCode(int typeCode) { this.TypeCode = typeCode; }


       
            public static string GenerateBicycleID(string typeCode, string bicycleTypeName)
            {
            int fixedLength = 7;
            char[] chars = new char[fixedLength];
            string allowedChars = "0123456789";
            Random random = new Random();
            string shortTypeName = bicycleTypeName.Replace(" ", " : :");
            shortTypeName = shortTypeName.Substring(0, Math.Min(3, shortTypeName.Length)).ToUpper();
            shortTypeName = bicycleTypeName.Substring(0, Math.Min(3, bicycleTypeName.Length)).ToUpper();

                for (int i = 0; i < fixedLength - shortTypeName.Length; i++)
                {
                    chars[i] = allowedChars[random.Next(0, allowedChars.Length)];
                }
                for (int i = 0; i < shortTypeName.Length; i++)
                {
                    chars[fixedLength - shortTypeName.Length + i] = shortTypeName[i];
                }

                return new string(chars) + typeCode;
            }

        
        public void RemoveBicycle()
        {

            {
                using (OracleConnection conn = new OracleConnection(Utility.oraDB))
                {
                    conn.Open();

                    string sqlQuery = "UPDATE Bicycles SET Status = :status WHERE BicycleId = :bicycleId";
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(":status", this.Status);
                        cmd.Parameters.Add(":bicycleId", this.getBicycleID());

                        cmd.ExecuteNonQuery();
                    }
                }
            }


        }
        public void addBicycle()
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                string sqlQuery = "INSERT INTO BICYCLES (BicycleID, Gender, Bsize, Bmodel, Status, Bicycle_typeCode) " +
                                 "VALUES (:BicycleID, :Gender, :Bsize, :Bmodel, :Status, :Bicycle_typeCode)";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":BicycleID", OracleDbType.Varchar2).Value = this.BicycleID;
                    cmd.Parameters.Add(":Gender", OracleDbType.Varchar2).Value = this.Gender;
                    cmd.Parameters.Add(":Bsize", OracleDbType.Int32).Value = this.Size;
                    cmd.Parameters.Add(":Bmodel", OracleDbType.Varchar2).Value = this.Model;
                    cmd.Parameters.Add(":Status", OracleDbType.Varchar2).Value = this.Status;
                    cmd.Parameters.Add(":Bicycle_typeCode", OracleDbType.Int32).Value = this.TypeCode;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static string[] getBicycleIDS()
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                string sqlQuery = "SELECT BicycleID FROM bicycles";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();


                    int count = 0;
                    using (OracleDataReader countReader = cmd.ExecuteReader())
                    {
                        while (countReader.Read())
                        {
                            count++;
                        }
                    }

                    string[] typeCodes = new string[count];
                    int index = 0;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dbTypes = reader.GetString(0);
                            typeCodes[index] = dbTypes;
                            index++;
                        }
                    }

                    conn.Close();
                    return typeCodes;
                }
            }
        }

        public static DataSet FindTypes(String typeCode)
        {

            OracleConnection conn = new OracleConnection(Utility.oraDB);

            String sqlQuery = "SELECT BicycleId, Gender, Bsize, Bmodel, Status,Bicycle_typeCode FROM Bicycles " +
          " Where BicycleId LIKE '%" + typeCode + "%' ORDER BY BicycleId";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "types");
            conn.Close();
            return ds;
        }


        public void UpdateBicycle()
        {
            OracleConnection conn = new OracleConnection(Utility.oraDB);

            String sqlQuery = "UPDATE BICYCLES SET " +
                              "Gender = :Gender, " +
                              "Bsize = :Bsize, " +
                              "BModel = :BModel, " +
                              "Status = :Status " +
                              "WHERE BicycleId = :BicycleId";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);



            cmd.Parameters.Add(":Gender", this.Gender);
            cmd.Parameters.Add(":Bsize", this.Size);
            cmd.Parameters.Add(":BModel", this.Model);
            cmd.Parameters.Add(":Status", this.Status);
            cmd.Parameters.Add(":BicycleId", OracleDbType.Varchar2).Value = this.BicycleID;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public static bool IsValidForAdding(int typeCode)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                string sqlQuery = "SELECT Bicycle_typeCode FROM Bicycle_types WHERE Status = :status AND Bicycle_typeCode = :typeCode"; ;


                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add(":status", "NA");
                    cmd.Parameters.Add(":typeCode", typeCode);
                    OracleDataReader reader = cmd.ExecuteReader();
                    return !reader.HasRows;
                    conn.Close();
                }
            }

        }

        public static void displayBicycleOnGrid(DataGridView dg)
        {
            {
                using (OracleConnection conn = new OracleConnection(Utility.oraDB))
                {
                    String sqlQuery = "SELECT  BicycleId,Gender, BSize, BModel,Status,Bicycle_TypeCode " +
                                      "FROM Bicycles " +
                                      "ORDER BY BicycleId";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        conn.Open();

                        using (OracleDataReader dr = cmd.ExecuteReader())
                        {
                            if (dg.Columns.Count == 0)
                            {

                                dg.Columns.Add("BicycleId", "Bicycle Id");
                                dg.Columns.Add("Bicycle_TypeCode", "Bicycle type");
                                dg.Columns.Add("Gender", "Gender");
                                dg.Columns.Add("Size", "Size");
                                dg.Columns.Add("Model", "Model");
                                dg.Columns.Add("Status", "Availability");

                            }
                            dg.Rows.Clear();
                            while (dr.Read())
                            {
                                dg.Rows.Add(dr["BicycleId"].ToString(), dr["Bicycle_TypeCode"].ToString(), dr["Gender"].ToString(), dr["BSize"].ToString(), dr["BModel"].ToString(), dr["Status"].ToString());
                            }
                        }
                    }
                }
            }
        }
    }
}




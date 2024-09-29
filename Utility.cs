using Oracle.ManagedDataAccess.Client;

namespace BicycleManagementSystem
{
    class Utility
    {

        // public const String oraDB = "Data Source = oracle/orcl; User ID = t00226841; Password = iwi39i7Hp7g?;";
     public const String oraDB = "Data Source = localhost:1521/orcl; User ID = c##User1; Password = 123456;";

        public static string ValidateTypeCode(int typeCode)
        {
            using (OracleConnection conn = new OracleConnection(Utility.oraDB))
            {
                String sqlQuery = "SELECT bicycle_TypeCode FROM bicycle_types";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int DBTypes = reader.GetInt32(0);
                            if (typeCode == DBTypes)
                            {
                                return "This bicycle already exists in the database please choose another number.";
                            }
                        }

                    }
                }
                return null;
            }
        }

        public static bool ContainsNumber(string input)
        {
            return input.Any(char.IsDigit);
        }
        public static bool ContainsSpecial(string input)
        {
            return input.Any(char.IsPunctuation);
        }
        public static string GetEmptyFieldMessage(string[] fields, string[] fieldNames)
        {
            for (int i = 0; i < fields.Length; i++)
            {
                if (string.IsNullOrEmpty(fields[i]))
                {
                    return $"Please fill in the required field: {fieldNames[i]}";
                }
            }


            return null;
        }


    }


}









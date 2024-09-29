using Oracle.ManagedDataAccess.Client;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace BicycleManagementSystem
{
    public partial class FrmRevenueReport : Form
    {
        public FrmRevenueReport()
        {
            InitializeComponent();
        }

        private void FrmRevenueReport_Load(object sender, EventArgs e)
        {

            int selectedMonthASint = comboBox1.SelectedIndex;

            string selectedMonth = getMonth(selectedMonthASint + 1);
            for (int i = 1; i <= 12; i++)
            {
                comboBox1.Items.Add(getMonth(i));
            }
            for (int year = 2019; year <= 2025; year++)
            {
                cmbBxYear.Items.Add(year);
            }

        }
        public String getMonth(int month)
            {
                switch (month)
                {
                    case 1: return "JAN";
                    case 2: return "FEB";
                    case 3: return "MAR";
                    case 4: return "APR";
                    case 5: return "MAY";
                    case 6: return "JUN";
                    case 7: return "JUL";
                    case 8: return "AUG";
                    case 9: return "SEP";
                    case 10: return "OCT";
                    case 11: return "NOV";
                    case 12: return "DEC";
                 
                default: return "OTH";
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedMonthASint = comboBox1.SelectedIndex;

            string selectedMonth = getMonth(selectedMonthASint + 1);

            string sqlQuery = @"SELECT SUM(PaidAmount) AS TotalRevenue,
                       TO_CHAR(Collection_Date, 'MM') AS Month,
                       COUNT(BookingId) AS BookingsInMonth
                   FROM Bookings
                   WHERE TO_CHAR(Collection_Date, 'MON') = '" + selectedMonth + @"'
                   GROUP BY TO_CHAR(Collection_Date, 'MM')
                   ORDER BY TO_NUMBER(TO_CHAR(Collection_Date, 'MM'))";


            DataTable dt = new DataTable();
            OracleConnection myConn = new OracleConnection(Utility.oraDB);
            OracleCommand cmd = new OracleCommand(sqlQuery, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            myConn.Close();

            string[] Months = new string[12];
            decimal[] Amounts = new decimal[12];

            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(i + 1); 
                Amounts[i] = 0;
            }


            for (int j = 0; j < dt.Rows.Count; j++)
            {
                int monthIndex = Convert.ToInt32(dt.Rows[j][1]) - 1;
                Amounts[monthIndex] = Convert.ToDecimal(dt.Rows[j][0]);
            }
            Console.WriteLine(cmd.CommandText);
            DGvRevenue.DataSource = dt; 
            DGvRevenue.Columns[1].HeaderText = "Month";
            DGvRevenue.Columns[0].HeaderText = "Total Income";
            DGvRevenue.Columns[2].HeaderText = "Bookings in Month";
            DGvRevenue.Columns[1].DefaultCellStyle.Format = "C";
        }

        private void DGvRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Color[] columnColors = { Color.Green, Color.Blue, Color.Red, Color.Yellow };

            if (e.ColumnIndex >= 1 && e.ColumnIndex <= columnColors.Length)
            {
                for (int i = 0; i < DGvRevenue.Rows.Count; i++)
                {
                    DGvRevenue.Rows[i].Cells[e.ColumnIndex].Style.BackColor = columnColors[e.ColumnIndex -1];
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string selectedYear = cmbBxYear.SelectedItem.ToString();

            string sqlQuery = @"SELECT 
                        EXTRACT(YEAR FROM Collection_Date) AS Year,
                        SUM(PaidAmount) AS TotalRevenue,
                        MAX(PaidAmount) AS HighestMonthlyRevenue,
                        MIN(PaidAmount) AS LowestMonthlyRevenue,
                        COUNT(BookingId) AS TotalBookings
                    FROM 
                        Bookings
                    WHERE 
                        EXTRACT(YEAR FROM Collection_Date) = :selectedYear
                    GROUP BY 
                        EXTRACT(YEAR FROM Collection_Date)
                    ORDER BY 
                        EXTRACT(YEAR FROM Collection_Date)";

            
            using (OracleConnection myConn = new OracleConnection(Utility.oraDB))
            {
                OracleCommand cmd = new OracleCommand(sqlQuery, myConn);
                cmd.Parameters.Add(":selectedYear", OracleDbType.Varchar2).Value = selectedYear;

                DataTable dt = new DataTable();
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                DGvRevenue.DataSource = dt;
                DGvRevenue.Columns["Year"].HeaderText = "Year";
                DGvRevenue.Columns["TotalRevenue"].HeaderText = "Total Revenue";
                DGvRevenue.Columns["HighestMonthlyRevenue"].HeaderText = "Highest Monthly Revenue";
                DGvRevenue.Columns["LowestMonthlyRevenue"].HeaderText = "Lowest Monthly Revenue";
                DGvRevenue.Columns["TotalBookings"].HeaderText = "Total Bookings";
            }


        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
    }
    



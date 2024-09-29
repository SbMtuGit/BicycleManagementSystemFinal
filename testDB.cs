using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BicycleManagementSystem
{
    public partial class testDB : Form
    {
        OracleConnection conn = new OracleConnection(Utility.oraDB);
        public testDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                label1.Text = "CLOSED";
                label1.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                conn.Open();
                label1.Text = "OPEN";
                label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}

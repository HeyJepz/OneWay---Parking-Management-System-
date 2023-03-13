using OneWayUI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Baby_Thesis_Test
{
    class SQLControl
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader SQLReader;
        private SqlDataAdapter da;

        public BindingSource bindingSource;
        private string btnName;

        public SQLControl()
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Downloads\OneWay Jep ver\OneWay1\OneWay1\DriversDB.mdf;Integrated Security=True";
            con = new SqlConnection(conString);
            bindingSource = new BindingSource();
        }

        public void InsertSQL(string name, string lot, string plate, string purpose, string timeIn)
        {
            string query = "INSERT INTO Drivers VALUES ((SELECT ISNULL(MAX(Id)+1,1) FROM Drivers), @Name, @ParkingLot, @PlateNo, @Purpose, @TimeIn, null)";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@ParkingLot", lot);
            cmd.Parameters.AddWithValue("@PlateNo", plate);
            cmd.Parameters.AddWithValue("@Purpose", purpose);
            cmd.Parameters.AddWithValue("@TimeIn", timeIn); // ayusin ung format ng date time sa database

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateSQL(string timeIn)
        {
            con.Open();

            // selects the Time equal to its time in
            cmd = new SqlCommand("UPDATE Drivers SET TimeOut = @TimeOut WHERE TimeIn =@TimeIn", con);
            cmd.Parameters.AddWithValue("@TimeOut", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
            cmd.Parameters.AddWithValue("@TimeIn", timeIn);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public bool DisplaySQL()
        {
            string query = "SELECT * FROM Drivers";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            bindingSource.DataSource = dt;
            return true;
        }

        public void loadButtons(Button butt)
        {
            if (butt.Name.Length == 6)
            {
                btnName = butt.Name.Substring(butt.Name.Length - 3);

            }
            else if (butt.Name.Length == 5)
            {
                btnName = butt.Name.Substring(butt.Name.Length - 2);
            }
            cmd = new SqlCommand("SELECT * FROM Drivers ", con);
            con.Open();
            SQLReader = cmd.ExecuteReader();
            while (SQLReader.Read())
            {
                // check if any buttons has not exited yet.
                // Console.WriteLine(SQLReader["TimeOut"]);
                if(SQLReader["LotNo"].ToString() == btnName)
                {
                    if (SQLReader["TimeOut"].ToString() == "")
                    {
                        butt.BackColor = Color.Red;
                        butt.Text = SQLReader["TimeIn"].ToString();
                        butt.ForeColor = Color.White;
                    }               
                }
            }
            con.Close();
        }
    }
}

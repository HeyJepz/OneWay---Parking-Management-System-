using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWay_STI
{
    public partial class FrmParkingInfo : Form
    {
        public FrmParkingInfo()
        {
            InitializeComponent();
        }

        private void FrmParkingInfo_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM STI_OneWay";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0HQ6VFP6;Initial Catalog=OneWayDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
        }
    }
}

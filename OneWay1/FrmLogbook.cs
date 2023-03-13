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
using Baby_Thesis_Test;

namespace OneWay1
{
    public partial class FrmLogbook : Form
    {
        public static FrmLogbook Instance;
        SQLControl sql;
        public FrmLogbook()
        {
            InitializeComponent();
            Instance = this;
            sql = new SQLControl();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshQuery();
        }

        public void refreshQuery()
        {
            sql.DisplaySQL();
            dataGridView1.DataSource = sql.bindingSource;
        }

        private void FrmLogbook_Load(object sender, EventArgs e)
        {
            refreshQuery();
        }
    }
}

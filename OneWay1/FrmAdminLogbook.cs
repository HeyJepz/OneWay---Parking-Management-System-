﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWay1
{
    public partial class FrmAdminLogbook : Form
    {
        public FrmAdminLogbook()
        {
            InitializeComponent();
        }

        private void FrmAdminLogbook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAccountsDatabaseDataSet2.tblAdminLogbook' table. You can move, or remove it, as needed.
            this.tblAdminLogbookTableAdapter.Fill(this.dbAccountsDatabaseDataSet2.tblAdminLogbook);

        }
    }
}

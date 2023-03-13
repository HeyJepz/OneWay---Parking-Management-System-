using OneWayUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using OneWay_STI;

namespace Baby_Thesis_Test
{   
    public partial class InputInfo : Form
    {
        public TextBox parkSpace;
        SQLControl sql;
        public InputInfo()
        {
            InitializeComponent();

            parkSpace = txtLot;
            this.ControlBox = false;
        }

        private void inputInfo_Load(object sender, EventArgs e)
        {
            txtTimeIn.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            txtPlateNo.Text = "";
            txtName.Text = "";
        }

        private void btnOccupy_Click(object sender, EventArgs e)
        {
            // input to form 1 label variable'
            //Instance.parkSpace.Text = txtLot.Text + ": " + txtPlateNo.Text;
            //Instance.Enabled = true;
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPlateNo.Text) || cbPurpose.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all the forms");
            }
            else
            {
                sql = new SQLControl();
                sql.InsertSQL(txtName.Text, txtLot.Text, txtPlateNo.Text, cbPurpose.Text.ToString(), txtTimeIn.Text);

                MessageBox.Show("Successfully inserted into the OneWay Database!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            //So user cannot escape with inputting the data, it will only minimize the tab
            //this.FormClosed += (_s, _e) => this.Enabled = true;
            //this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

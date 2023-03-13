using System;
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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }
        dbControls dbControl = new dbControls();
        //VALIDATES THE LOGIN INFORMATION FROM THE FORM WITH THE DATA FROM THE SQL SERVER
        public bool Login()
        {
            //Param for data from the Login form
            dbControl.Param("@username", txUserName.Text);
            dbControl.Param("@password", txPass.Text);
            //gives the query to find the data from the table with the parameters above
            dbControl.Query("select count (*) from tblAdminAccount where username=@username and password=@password");
            //Return true if data is found 
            if ((int)dbControl.dTable.Rows[0][0] == 1)
            {
                return true;
            }
            MessageBox.Show("Invalid Username or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login() == true)
            {
                frmAdminMain testfrom = new frmAdminMain();
                this.Hide();
                testfrom.Show();
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txPass.UseSystemPasswordChar = false;
            }
            else txPass.UseSystemPasswordChar = true;
        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmOfficerLogin FormLogin = new FrmOfficerLogin();
            this.Hide();
            FormLogin.Show();
        }
    } 
}

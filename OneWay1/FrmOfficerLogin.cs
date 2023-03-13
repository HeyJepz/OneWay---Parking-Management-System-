using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Baby_Thesis_Test;

namespace OneWay1
{
    public partial class FrmOfficerLogin : Form
    {
        public FrmOfficerLogin()
        {
            InitializeComponent();
            
            dtpLogin.Visible = false;
        }
       
        dbControls dbControl = new dbControls();
        //VALIDATES THE LOGIN INFORMATION FROM THE FORM WITH THE DATA FROM THE SQL SERVER
        public bool Login()
        {
            //Param for data from the Login form
            dbControl.Param("@username", txUserName.Text);
            dbControl.Param("@password", txPass.Text);
            //gives the query to find the data from the table with the parameters above
            dbControl.Query("select count (*) from tblOfficerAccount where username=@username and password=@password");
            //Return true if data is found 
            if ((int)dbControl.dTable.Rows[0][0] == 1)
            {
                return true;
            }
            MessageBox.Show("Invalid Username or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;


        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txPass.UseSystemPasswordChar= false;
            }
            else txPass.UseSystemPasswordChar= true;
        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmOfficerLogin_Load(object sender, EventArgs e)
        {
       
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Login()==true)
            {
                //TEST FORM IS MAIN FORM NILA BUDAK!!!!!
                FrmHome testfrom = new FrmHome();
                LogbookData();
                this.Hide();
                testfrom.Show();
            }
        }

        private void dtpLogin_ValueChanged(object sender, EventArgs e)
        {

        }
     
      //Inputs Data to the Admin logbook
        public void LogbookData()
        {
           
            dbControl.Param("@DateTime",GetCurrentTime());
            dbControl.Param("@Name", txUserName.Text);
            dbControl.Query("insert into tblAdminLogbook (LoginTime, Name) values (@DateTime,@Name)");
       
           
          

            if (dbControl.Check4Error(true))
            {
                return;
            }
            MessageBox.Show("Logged in!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
           string GetCurrentTime()
        {
            dtpLogin.Format = DateTimePickerFormat.Custom;
            dtpLogin.CustomFormat = "MM/dd/yyyy hh:mm";
            dtpLogin.Text = DateTime.Now.ToString(); 
            return dtpLogin.Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmAdminLogin FrmAdmin = new FrmAdminLogin();
            this.Hide();
            FrmAdmin.Show();
            
          
        }
    }
}

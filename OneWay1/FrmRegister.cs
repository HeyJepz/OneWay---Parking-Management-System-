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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        dbControls dbControl= new dbControls();
        
        //inserts the given value from the forms to the table
        void register()
        {

            dbControl.Param("@username", txUserName.Text);
            dbControl.Param("@password", txPass.Text);
            dbControl.Query("insert into tblOfficerAccount (username, password) values (@username,@password)");

            if (dbControl.Check4Error(true))
            {
                return;
            }
            MessageBox.Show("Registered!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
           //Shows and unshows password
            if (cbShowPass.Checked)
            {
                txPass.UseSystemPasswordChar = false;
                txConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txPass.UseSystemPasswordChar = true;
                txConfirm.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmLogbook LogBook = new FrmLogbook();
            //confirms the password
            if (txPass.Text==txConfirm.Text)
            {
                register();
       
            }
            else
            {
                MessageBox.Show("Please make sure that both password are the same.", "Different Password.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

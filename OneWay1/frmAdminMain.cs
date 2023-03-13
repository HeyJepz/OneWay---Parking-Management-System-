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
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
         
        }
      

       private void pnlLogbook_Paint(object sender, PaintEventArgs e)
        {
           FrmAdminLogbook frm = new FrmAdminLogbook();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            pnlLogbook.HorizontalScroll.Visible = false;
            pnlLogbook.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {
            FrmRegister reg = new FrmRegister();
            reg.TopLevel = false;
            reg.AutoScroll = false;
            pnlRegister.HorizontalScroll.Visible = false;
            pnlRegister.Controls.Add(reg);
            reg.FormBorderStyle = FormBorderStyle.None;
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOfficerLogin frm = new FrmOfficerLogin();
            this.Hide();
            frm.Show();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
        }
    }
}

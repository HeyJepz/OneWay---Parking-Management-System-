using Baby_Thesis_Test;
using OneWay;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWayUI
{
    class ButtonBehaviour
    {
        //FrmFullScale frmFullScale = new FrmFullScale();
        private Button tempButt;
        InputInfo input;
        SQLControl sql;

        public string time;
        string btnName;
        public void buttonStatus(Button butt)
        {
            time = butt.Text;
            if (butt.Name.Length == 6)
            {
                btnName = butt.Name.Substring(butt.Name.Length - 3); 

            }
            else if (butt.Name.Length == 5)
            {
                btnName = butt.Name.Substring(butt.Name.Length - 2); 
            }

            if (butt.BackColor == Color.FromArgb(255, 193, 94))
            {
                tempButt = butt;
                input = new InputInfo();

                time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
                input.btnOccupy.Click += BtnBack_Click;
                input.parkSpace.Text = btnName;

                input.ShowDialog();
            }           
            else if(butt.BackColor == Color.Red)
            {
                sql = new SQLControl();
                sql.UpdateSQL(time);

                butt.BackColor = Color.FromArgb(255, 193, 94);
                butt.Text = "available";
                butt.ForeColor = Color.FromArgb(16, 52, 84);
                // + Environment.NewLine + input.parkSpace.Text
                MessageBox.Show("Cleared Space!");
            }
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (input.btnOccupy.Enabled)
            {
                tempButt.BackColor = Color.Red;
                tempButt.Text = time;
                tempButt.ForeColor = Color.White;
            }          
        }
    }
}

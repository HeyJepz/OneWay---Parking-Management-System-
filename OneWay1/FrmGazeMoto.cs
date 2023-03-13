using OneWay;
using OneWayUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baby_Thesis_Test
{
    public partial class FrmGazeMoto : Form
    {
        public static FrmGazeMoto Instance;
        SQLControl sql;
        ButtonBehaviour buttStatus = new ButtonBehaviour();
        int occupiedMotorLot;
        int occupiedGazeboLot;
        public FrmGazeMoto()
        {
            InitializeComponent();
            Instance = this;
            sql = new SQLControl();

            foreach (Button btn in pnlGazebo.Controls.OfType<Button>())
            {
                sql.loadButtons(btn);
                btn.Click += Btn_Click;
            }

            foreach (Button btn in pnlMotor.Controls.OfType<Button>())
            {
                sql.loadButtons(btn);
                btn.Click += Btn_Click;
            }

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                buttStatus.buttonStatus(btn);
            }
        }
        public int countMotorOccupied()
        {
            occupiedMotorLot = 0;
            foreach (Button btn in pnlMotor.Controls.OfType<Button>())
            {
                if (btn.BackColor == Color.Red)
                {
                    occupiedMotorLot++;
                }
            }
            return occupiedMotorLot;
        }

        public int countGazeboOccupied()
        {
            occupiedGazeboLot = 0;
            foreach (Button btn in pnlGazebo.Controls.OfType<Button>())
            {
                if (btn.BackColor == Color.Red)
                {
                    occupiedGazeboLot++;
                }
            }
            return occupiedGazeboLot;
        }
    }
}

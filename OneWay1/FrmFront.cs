using Baby_Thesis_Test;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace OneWayUI
{
    public partial class FrmFront : Form
    {
        public static FrmFront Instance;
        SQLControl sql;
        ButtonBehaviour buttStatus = new ButtonBehaviour();
        int occupiedFrontLot;
        int occupiedBikeLot;
        // balak ko kunin ung label sa full scale at baguhin kada click sa button para dumagdag ung "space occupied"
        public FrmFront()
        {
            InitializeComponent();
            Instance = this;
            sql = new SQLControl();

            foreach (Button btn in pnlFront.Controls.OfType<Button>())
            {
                sql.loadButtons(btn);
                btn.Click += Btn_Click;
            }

            foreach (Button btn in pnlFront_bikes.Controls.OfType<Button>())
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

        public int CountFrontOccupied()
        {
            occupiedFrontLot = 0;
            foreach (Button btn in pnlFront.Controls.OfType<Button>())
            {
                if (btn.BackColor == Color.Red)
                {
                    occupiedFrontLot++;
                }
            }
            return occupiedFrontLot;
        }

        public int CountBikeOccupied()
        {
            occupiedBikeLot = 0;
            foreach (Button btn in pnlFront_bikes.Controls.OfType<Button>())
            {
                if (btn.BackColor == Color.Red)
                {
                    occupiedBikeLot++;
                }
            }
            return occupiedBikeLot;
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using Baby_Thesis_Test;
using System.Drawing;


namespace OneWayUI
{
    public partial class FrmBack : Form
    {
        public static FrmBack Instance;
        SQLControl sql;
        ButtonBehaviour buttStatus = new ButtonBehaviour();
        int occupiedLot;
        public FrmBack()
        {
            InitializeComponent();
            Instance = this;
            sql = new SQLControl();

            foreach (Button btn in pnlFront.Controls.OfType<Button>())
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
        public int countOccupied()
        {
            occupiedLot = 0;
            foreach (Button btn in pnlFront.Controls.OfType<Button>())
            {
                if (btn.BackColor == Color.Red)
                {
                    occupiedLot++;
                }
            }
            return occupiedLot;
        }
    }
}

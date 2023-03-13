using Baby_Thesis_Test;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OneWayUI
{
    public partial class FrmSide : Form
    {
        
        public static FrmSide Instance;
        SQLControl sql;
        ButtonBehaviour buttStatus = new ButtonBehaviour();
        public static int occupiedLot; // test lang to
        public FrmSide()
        {
            InitializeComponent();
            Instance = this;
            sql = new SQLControl();
            foreach (Button btn in pnlSide.Controls.OfType<Button>())
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
        
        // trying to dynamically count the occupied lots and reflect on the full scale form
        public int countOccupied()
        {
            occupiedLot = 0;
            foreach (Button btn in pnlSide.Controls.OfType<Button>())
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

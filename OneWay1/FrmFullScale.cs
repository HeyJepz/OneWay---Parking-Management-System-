using Baby_Thesis_Test;
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

namespace OneWay
{
    public partial class FrmFullScale : Form
    {
        public static FrmFullScale Instance;
        //FrmSide side;
        public FrmFullScale()
        {
            InitializeComponent();
            Instance = this;
        }

        private void FrmFullScale_Load(object sender, EventArgs e)
        {
            updateForm();
        }

        public void updateForm()
        {
            // the problem is that this is a static form, meaning it wont instantiate a new one therefore it won't update

            // but if i make it new frmFullScale then it will keep eating memory when i open this form.

            // solution: gumawa ng refresh button para dito xd 
            Console.WriteLine(FrmSide.occupiedLot);
            lblSide.Text = "SIDE\n" + FrmSide.Instance.countOccupied() + " / 8";
            lblBack.Text = "BACK OF STI\n" + FrmBack.Instance.countOccupied() + " / 18";
            lblGazebo.Text = "BESIDE GAZEBO\n" + FrmGazeMoto.Instance.countGazeboOccupied() + " / 33";
            lblMotor.Text = "MOTORCYCLES\n" + FrmGazeMoto.Instance.countMotorOccupied() + " / 33";
            lblFront.Text = "FRONT\n" + FrmFront.Instance.CountFrontOccupied() + " / 11";
            lblBikes.Text = "BIKES\n" + FrmFront.Instance.CountBikeOccupied() + " / 10";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateForm();
        }
    }
}

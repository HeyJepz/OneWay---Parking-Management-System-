using OneWay;
using OneWay_STI;
using OneWay1;
using OneWayUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baby_Thesis_Test
{
    public partial class FrmHome : Form
    {
        private Form activeForm;
        private Button activeButton;
        private List<Button> buttonList = new List<Button>();
        public static FrmHome Instance;

        public FrmHome()
        {
            InitializeComponent();
            inactiveButts();
            Instance = this;
        }

        public void openChildForm(Form childForm, object buttonSender)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            activeButton = (Button)buttonSender;
            foreach (Button btn in buttonList)
            {
                if (btn == buttonSender)
                {
                    activeButton.BackColor = Color.FromArgb(103, 142, 184);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(16, 52, 84);
                }
            }
        }
        private void inactiveButts()
        {
            buttonList.AddRange(new Button[]
            {
                btnP_FullScale, btnP_Front, btnP_Side, btnP_GazeMoto, btnP_Back
            });
        }

        private void btnP_FullScale_Click_1(object sender, EventArgs e)
        {
            openChildForm(FrmFullScale.Instance, sender);
        }

        private void btnP_Front_Click_1(object sender, EventArgs e)
        {
            openChildForm(FrmFront.Instance, sender);
        }

        private void btnP_Side_Click_1(object sender, EventArgs e)
        {
            openChildForm(FrmSide.Instance, sender);
        }

        private void btnP_Back_Click_1(object sender, EventArgs e)
        {
            openChildForm(FrmBack.Instance, sender);
        }

        private void btnP_GazeMoto_Click(object sender, EventArgs e)
        {
            openChildForm(FrmGazeMoto.Instance, sender);
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            openChildForm(FrmFullScale.Instance, btnP_FullScale);
        }

        private void btnLogBook_Click(object sender, EventArgs e)
        {
            openChildForm(FrmLogbook.Instance, btnLogBook);
        }
    }
}

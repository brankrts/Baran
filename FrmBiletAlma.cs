using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controls.Database.DbConnect;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls;
using Guna.UI2.WinForms;


namespace WindowsFormsApp1.ChildForms
{
    public partial class FrmBiletAlma : Form
    {
        int Koltukno;
        Ucuslar ucus = Ucuslar.Instance;
        CurrentValues Current = CurrentValues.Instance;
        OpenChildForms open = new OpenChildForms();
        KoltukProvider koltuklar = new KoltukProvider();
        

        public FrmBiletAlma()
        {
            InitializeComponent();
        }

        private void SetLabelValues() {

            lblFirma.Text = ucus.SirketAdi;
            lblNereden.Text = ucus.SehirAdiNereden;
            lblNereye.Text = ucus.SehirAdiNereye;
            lblTarih.Text = ucus.Tarih.ToLongDateString();
            lblSaat.Text = ucus.Saat;
            btnSatıinAl0.Enabled = false;
  

        }
        private void SetKoltukNO(Guna2CircleButton Button) {
            foreach (Control x in pnlBiletAl.Controls)
            {
                if (x is Guna2CircleButton)
                {
                    

                        ((Guna2CircleButton)x).FillColor = System.Drawing.Color.LightGray;
                  
                }
            }
            Koltukno = Convert.ToInt32(Button.Text);
            Current.KoltukNO = Koltukno;
            Button.FillColor = System.Drawing.Color.Green;
            btnSatıinAl0.Enabled = true;
        
        }
        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn4);
        }

        private void FrmBiletAlma_Load(object sender, EventArgs e)
        {
            SetLabelValues();
            
            foreach (Control x in pnlBiletAl.Controls)
            {
                if (x is Guna2CircleButton)
                {

                    
                    koltuklar.KoltukRenkListele(((Guna2CircleButton)x),pnlBiletAl,Current.UcusID);
                }
            }
            
            

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn3);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn11);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            SetKoltukNO(btn12);
        }

        private void btnSatıinAl0_Click(object sender, EventArgs e)
        {
            open.OpenChildForm(new ChildForms.Odeme(), pnlBiletAl);
        }
    }
}

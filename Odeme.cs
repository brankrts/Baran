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
    public partial class Odeme : Form
    {
        Ucuslar ucus = Ucuslar.Instance;
        CurrentValues Current = CurrentValues.Instance;
        BiletlerProvider biletler = new BiletlerProvider();
        KoltukProvider koltuklar = new KoltukProvider();
        public Odeme()
        {
            InitializeComponent();
        }
        private void  SetLabelValues(){
            lblFiyat.Text = ucus.Fiyat.ToString();
            lblNereden.Text = ucus.SehirAdiNereden;
            lblNereye.Text = ucus.SehirAdiNereye;
            lblTarih.Text = ucus.Tarih.ToLongDateString();
            lblTarih1.Text = ucus.Tarih.ToLongDateString();
            lblSaat.Text = ucus.Saat;
            lblKoltukNo.Text = Current.KoltukNO.ToString();
            lblSirketAdi.Text = ucus.SirketAdi;
        
        
        
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
           
            koltuklar.KoltukEkle(Current.UcusID,Current.MusteriID,Current.KoltukNO);
            koltuklar.GetID(Current.KoltukNO);
            biletler.BiletEkle(Current.UcusID,Current.MusteriID,Current.KoltukID);
            lblBasari.Text = "İşlem Başarıyla Sonuçlandı.";
            btnBiletAl.Enabled = false;

        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            lblBasari.Text = "";
            btnBiletAl.Enabled = true; 
            SetLabelValues();
        }
    }
}

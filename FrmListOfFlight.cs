using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controls.Database.DbConnect;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls;

namespace WindowsFormsApp1.ChildForms
{
    public partial class FrmListOfFlight : Form
    {
        UcusProvider Flights = new UcusProvider();
        Ucuslar ucus = Ucuslar.Instance;
        OpenChildForms open = new OpenChildForms();
        CurrentValues Current = CurrentValues.Instance;
        
       
        string komut = "SELECT Ucuslar.UcusID,Sirketler.SirketAdi,s1.SehirAdi,s2.SehirAdi,Ucuslar.Tarih,Ucuslar.Saat,Ucuslar.Fiyat FROM Ucuslar INNER JOIN Sirketler ON Ucuslar.SirketID = Sirketler.SirketID INNER JOIN Sehirler as s1 ON @Nereden = s1.SehirID INNER JOIN Sehirler as s2 ON @Nereye = s2.SehirID WHERE ucuslar.Tarih = @Tarih";

        private void SetCurrentValues() {

            Current.UcusID = Convert.ToInt32(gridmaster.CurrentRow.Cells[0].Value);
            ucus.SirketAdi = gridmaster.CurrentRow.Cells[1].Value.ToString();
            ucus.SehirAdiNereden = gridmaster.CurrentRow.Cells[2].Value.ToString();
            ucus.SehirAdiNereye = gridmaster.CurrentRow.Cells[3].Value.ToString();
            ucus.Tarih = DateTime.Parse(gridmaster.CurrentRow.Cells[4].Value.ToString());
            ucus.Saat = gridmaster.CurrentRow.Cells[5].Value.ToString();
            ucus.Fiyat = Convert.ToInt32(gridmaster.CurrentRow.Cells[6].Value);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        public FrmListOfFlight( )
            
        {

            InitializeComponent();
        }

       

        

        private void FrmListOfFlight_Load(object sender, EventArgs e)
        {

           
           Flights.ListFlight(ucus.Nereden,ucus.Nereye,ucus.Tarih,gridmaster,komut);
            
        }

        private void xuıButton1_Click(object sender, EventArgs e)
        {
            
        }

       

       

       

        private void gridListofFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void pnlListOfFlights_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            SetCurrentValues();
            open.OpenChildForm(new ChildForms.FrmBiletAlma(), pnlListOfFlights);

        }
    }
}

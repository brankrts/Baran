using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controls;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;


namespace WindowsFormsApp1.ChildForms
{
    public partial class FrmSearchFlight : Form
    {
        SehirlerProvider Sehirler = new SehirlerProvider();
        OpenChildForms open = new OpenChildForms();
        Ucuslar ucus = Ucuslar.Instance;
        
        
        
       
        private void GetValues() {

            int NeredenID = Sehirler.GetID(cmbNereden.SelectedItem.ToString());
            int NereyeID = Sehirler.GetID(cmbNereye.SelectedItem.ToString());
            DateTime Tarih = cmbTarih.Value;


            ucus.Nereden = NeredenID;
            ucus.Nereye = NereyeID;
            ucus.Tarih = Tarih;
            open.OpenChildForm(new ChildForms.FrmListOfFlight(),pnlUcusAra);
            



        }

        public FrmSearchFlight()
        {
            InitializeComponent();
        }

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            GetValues(); 
        }

        private void FrmSearchFlight_Load(object sender, EventArgs e)
        {
            Sehirler.ListOfSehirler(cmbNereden);
            Sehirler.ListOfSehirler(cmbNereye);
            

        }

        private void pnlUcusAra_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

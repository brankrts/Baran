using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Database
{
    public class Ucuslar
    {


        static Ucuslar instance;



        public static Ucuslar Instance
        {
            get
            {
                if (instance == null)
                    instance = new Ucuslar();
                return instance;
            }
        }

        public Ucuslar() { }

        int _UcusID;
        public int UcusID
        {
            get { return _UcusID; }
            set { _UcusID = value; }
        }


        int _SirketID;
        public int SirketID
        {
            get { return _SirketID; }
            set { _SirketID = value; }
        }
        int _Nereden;
        public int Nereden
        {
            get { return _Nereden; }
            set { _Nereden = value; }
        }
        int _Nereye;
        public int Nereye
        {
            get { return _Nereye; }
            set { _Nereye = value; }
        }
        DateTime _Tarih;
        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }
        string _Saat;
        public string Saat
        {
            get { return _Saat; }
            set { _Saat = value; }
        }
        int _Fiyat;
        public int Fiyat
        {
            get { return _Fiyat; }
            set { _Fiyat = value; }
        }
        string _SehirAdiNereden;
        public string SehirAdiNereden
        {
            get { return _SehirAdiNereden; }
            set { _SehirAdiNereden = value; }
        } 

        string _SehirAdiNereye;
        public string SehirAdiNereye
        {
            get { return _SehirAdiNereye; }
            set { _SehirAdiNereye = value; }
        }
        string _SirketAdi;
        public string SirketAdi
        {
            get { return _SirketAdi; }
            set { _SirketAdi = value; }
        }


    }

}

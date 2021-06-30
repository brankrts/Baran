using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1.Controls.Database.DbConnect
{
    class UcusProvider
    {
        Ucuslar k;
        DbConnector dbcon = new DbConnector();
        Ucuslar Current1 = Ucuslar.Instance;
        CurrentValues current = CurrentValues.Instance;
        SqlDataReader reader;
        public UcusProvider() {
            dbcon.Baglan();

        }
        public List<Ucuslar> Listele()
        {

            try
            {
                List<Ucuslar> UcusListesi = new List<Ucuslar>();
                dbcon.cmd.CommandText = "Select *From Ucuslar";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                SqlDataReader reader = dbcon.cmd.ExecuteReader();
                while (reader.Read())
                {
                    k = new Ucuslar();
                    k.UcusID = Convert.ToInt32(reader[0].ToString());
                    k.SirketID = Convert.ToInt32(reader[1].ToString());
                    k.Nereden = Convert.ToInt32(reader[2].ToString());
                    k.Nereye = Convert.ToInt32(reader[3].ToString());
                    k.Tarih = DateTime.Parse(reader[4].ToString());
                    k.Fiyat = Convert.ToInt32(reader[5].ToString());
                    UcusListesi.Add(k);
                }

                return UcusListesi;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }
        }
        public void ListFlight(int Nereden, int Nereye, DateTime Tarih, Bunifu.Framework.UI.BunifuCustomDataGrid Gridview, string komut)
        {
            DataSet ds;
            SqlDataAdapter da;
            try
            {


                //MessageBox.Show(Current.Nereden.ToString()+Current.Nereye.ToString()+Tarih);
                da = new SqlDataAdapter(komut, dbcon.con);
                da.SelectCommand.Parameters.AddWithValue("@Nereden", Nereden);
                da.SelectCommand.Parameters.AddWithValue("@Nereye", Nereye);
                da.SelectCommand.Parameters.AddWithValue("@Tarih", Tarih);
                ds = new DataSet();
                da.Fill(ds);

                Gridview.DataSource = ds.Tables[0];






            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }


        public void ListOfBiletler(int MusteriID, Bunifu.Framework.UI.BunifuCustomDataGrid Gridview)
        {

            string komut1 = "SELECT Sirketler.SirketAdi,s1.SehirAdi,s2.SehirAdi,Ucuslar.Tarih,Ucuslar.Saat,Ucuslar.Fiyat " +
            "FROM Biletler " +
            "INNER JOIN Musteriler ON Biletler.MusteriID = Musteriler.MusteriID " +
            "INNER JOIN Ucuslar ON Biletler.UcusID = Ucuslar.UcusID " +
            "INNER JOIN Sirketler ON Ucuslar.SirketID = Sirketler.SirketID " +
            "INNER JOIN Sehirler as s1 ON Ucuslar.Nereden = s1.SehirID " +
            "INNER JOIN Sehirler as s2 ON Ucuslar.Nereye = s2.SehirID " +
            "where Musteriler.MusteriID = @MusteriID";
            DataSet ds;
            SqlDataAdapter da;
            try
            {



                da = new SqlDataAdapter(komut1, dbcon.con);
                da.SelectCommand.Parameters.AddWithValue("@MusteriID", MusteriID);

                ds = new DataSet();
                da.Fill(ds);

                Gridview.DataSource = ds.Tables[0];






            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }
        public void ListOfCharts(Chart chart, int Nereden, int Nereye, Label lblNereden, Label lblNereye)
        {
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }

            try
            {
                string komut = "SELECT Sirketler.SirketAdi ,s1.SehirAdi,s2.SehirAdi,Ucuslar.Fiyat,Ucuslar.Tarih " +
                                "from Ucuslar " +
                                "inner join Sirketler on Ucuslar.SirketID = Sirketler.SirketID " +
                                "inner join Sehirler s1 on Ucuslar.Nereden = s1.SehirID " +
                                "inner join Sehirler s2 on Ucuslar.Nereye = s2.SehirID " +
                                "where Ucuslar.Nereden =@Nereden and Ucuslar.Nereye =@Nereye";



                dbcon.cmd = new SqlCommand(komut, dbcon.con);
                dbcon.cmd.Parameters.AddWithValue("@Nereden", Nereden);
                dbcon.cmd.Parameters.AddWithValue("@Nereye", Nereye);
                dbcon.con.Open();
                reader = dbcon.cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime tarih = DateTime.Parse(reader["Tarih"].ToString());
                    
                    

                    chart.Series[reader["SirketAdi"].ToString()].Points.AddXY(tarih.ToLongDateString(), reader["Fiyat"].ToString());
                    lblNereden.Text = reader["SehirAdi"].ToString();
                    lblNereye.Text = reader[2].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }
        public void ListOfBildirimlerAddGrid(Bunifu.Framework.UI.BunifuCustomDataGrid Gridview)
        {
            DataSet ds;
            SqlDataAdapter da;
            string komut = "SELECT *FROM Bildirimler";
            try
            {


                ;
                da = new SqlDataAdapter(komut, dbcon.con);
                ds = new DataSet();
                da.Fill(ds);
                current.RowCount = ds.Tables[0].Rows.Count;
                Gridview.DataSource = ds.Tables[0];
                





            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }
        public void ListOfBildirimler()
        {
            DataSet ds;
            SqlDataAdapter da;
            string komut = "SELECT *FROM Bildirimler";
            try
            {


                ;
                da = new SqlDataAdapter(komut, dbcon.con);
                ds = new DataSet();
                da.Fill(ds);
                current.RowCount = ds.Tables[0].Rows.Count;
                






            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }
        public void ListFlightMaster( Bunifu.Framework.UI.BunifuCustomDataGrid Gridview, string komut)
        {
            DataSet ds;
            SqlDataAdapter da;
            try
            {


                ;
                da = new SqlDataAdapter(komut, dbcon.con);
                ds = new DataSet();
                da.Fill(ds);

                Gridview.DataSource = ds.Tables[0];






            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }
        public void ListOfBiletlerMaster(Bunifu.Framework.UI.BunifuCustomDataGrid Gridview)
        {
            DataSet ds;
            SqlDataAdapter da;
            string komut = "select m.MusteriTC,s1.SehirAdi,s2.SehirAdi,k.KoltukNo,u.Tarih " +
           "from Biletler b " +
           "inner join Musteriler as m on b.MusteriID = m.MusteriID " +

           "inner join Ucuslar as u on b.UcusID = u.UcusID " +

           "inner join Koltuklar as k on b.KoltukID = k.KoltukID " +

           "inner join Sehirler as s1 on u.Nereden = s1.SehirID " +

           "inner join Sehirler as s2 on u.Nereye = s2.SehirID ";
            


            try
            {


                ;
                da = new SqlDataAdapter(komut, dbcon.con);
                ds = new DataSet();
                da.Fill(ds);

                Gridview.DataSource = ds.Tables[0];






            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }
        public void AddFlight(int SirketID, int Nereden, int Nereye, DateTime picker, string saat, int Fiyat)
        {
            try
            {

                dbcon.cmd = new SqlCommand("INSERT INTO [Ucuslar] (SirketID,Nereden,Nereye,Tarih,Saat,Fiyat) values (@SirketID,@Nereden,@Nereye,@Tarih,@Saat,@Fiyat)", dbcon.con);


                dbcon.cmd.Parameters.AddWithValue("@SirketID", SirketID);
                dbcon.cmd.Parameters.AddWithValue("@Nereden", Nereden);
                dbcon.cmd.Parameters.AddWithValue("@Nereye", Nereye);
                dbcon.cmd.Parameters.AddWithValue("@Tarih", picker);
                dbcon.cmd.Parameters.AddWithValue("@Saat", saat);
                dbcon.cmd.Parameters.AddWithValue("@Fiyat", Fiyat);
                dbcon.con.Open();
                dbcon.cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }
        public void Ekle(int SirketID,int Nereden,int Nereye,DateTime Tarih,int Fiyat)
        {
            try
            {
                dbcon.cmd.CommandText = "Insert Into Ucuslar (SirketID,Nereden,Nereye,Tarih,Fiyat) Values (" + SirketID + ",'" + Nereden + "','" + Nereye + "','" + Tarih + "','" + Fiyat + "')";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                dbcon.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }

        public void Guncelle(Ucuslar MevcutUcus, int SirketID, int Nereden, int Nereye, DateTime Tarih, int Fiyat)
        {
            try
            {
                dbcon.cmd.CommandText = "Update Ucuslar SET SirketID='" + SirketID + "',Nereden='" + Nereden + "',Nereye='" + Nereye + "',Tarih='" + Tarih + "',Fiyat='" + Fiyat + "' Where UcusID=" + MevcutUcus.UcusID + "";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                dbcon.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }

        public void Sil(Ucuslar k)
        {
            try
            {
                dbcon.cmd.CommandText = "Delete From Ucuslar Where UcusID=" + k.UcusID + "";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                dbcon.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }
        }






    }
}

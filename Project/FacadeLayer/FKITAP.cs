using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using EntityLayer;

namespace FacadeLayer
{
    public class FKITAP
    {
        public static int Insert(EKITAP item)
        {
            int etkilenen = 0;
            try
            {
                OleDbCommand com = new OleDbCommand("INSERT INTO KITAP (ADI, YAZAR, SAYFASAYISI) Values(@ADI, @YAZAR,@SAYFASAYISI)", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ADI", item.ADI);
                com.Parameters.AddWithValue("YAZAR", item.YAZAR);
                com.Parameters.AddWithValue("SAYFASAYISI", item.SAYFASAYISI);
                etkilenen = com.ExecuteNonQuery();
            }
            catch
            {
                etkilenen = -1;
            }
            return etkilenen;
        }

        public static bool Update(EKITAP item)
        {
            bool sonuc = false;
            try
            {
                OleDbCommand coma = new OleDbCommand("UPDATE KITAP SET ADI = @ADI, YAZAR = @YAZAR, SAYFASAYISI = @SAYFASAYISI WHERE ID = @ID", BAGLANTI.Con);
                if (coma.Connection.State != ConnectionState.Open)
                {
                    coma.Connection.Open();
                }
                coma.Parameters.AddWithValue("ADI", item.ADI);
                coma.Parameters.AddWithValue("YAZAR", item.YAZAR);
                coma.Parameters.AddWithValue("SAYFASAYISI", item.SAYFASAYISI);
                coma.Parameters.AddWithValue("ID", item.ID);
                sonuc = coma.ExecuteNonQuery() > 0;
            }
            catch
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static bool Delete(int _ID)
        {
            bool sonuc = false;
            try
            {
                OleDbCommand com = new OleDbCommand("DELETE FROM KITAP WHERE ID=@ID", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ID", _ID);
                sonuc = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static EKITAP Select(int _ID)
        {
            EKITAP item = null;
            try
            {
                OleDbCommand com = new OleDbCommand("SELECT * FROM KITAP WHERE ID=@ID", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ID", _ID);

                OleDbDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EKITAP();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.ADI = rdr["ADI"].ToString();
                        item.YAZAR = rdr["YAZAR"].ToString();
                        item.SAYFASAYISI = Convert.ToInt32(rdr["SAYFASAYISI"]);
                    }
                }
                rdr.Close();
            }
            catch
            {
                item = null;
            }
            return item;
        }

        public static List<EKITAP> SelectList()
        {
            List<EKITAP> itemList = new List<EKITAP>();
            try
            {
                OleDbCommand com = new OleDbCommand("SELECT * FROM KITAP", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                OleDbDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EKITAP>();
                    while (rdr.Read())
                    {
                        EKITAP item = new EKITAP();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.ADI = rdr["ADI"].ToString();
                        item.YAZAR = rdr["YAZAR"].ToString();
                        item.SAYFASAYISI = Convert.ToInt32(rdr["SAYFASAYISI"]);
                        itemList.Add(item);
                    }
                }
                rdr.Close();
            }
            catch
            {
                itemList = null;
            }
            return itemList;
        }

    }
}

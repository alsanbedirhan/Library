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
    public class FOGRENCI
    {
        public static int Insert(EOGRENCI item)
        {
            int etkilenen = 0;
            try
            {
                OleDbCommand com = new OleDbCommand("INSERT INTO OGRENCI (ADI, SOYADI,NUMARA) Values(@ADI, @SOYADI,@NUMARA)", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ADI", item.ADI);
                com.Parameters.AddWithValue("SOYADI", item.SOYADI);
                com.Parameters.AddWithValue("NUMARA", item.NUMARA);
                etkilenen = com.ExecuteNonQuery();
            }
            catch
            {
                etkilenen = -1;
            }
            return etkilenen;
        }

        public static bool Update(EOGRENCI item)
        {
            bool sonuc = false;
            try
            {
                OleDbCommand com = new OleDbCommand("UPDATE OGRENCI SET ADI=@ADI, SOYADI=@SOYADI, NUMARA=@NUMARA WHERE ID=@ID", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ADI", item.ADI);
                com.Parameters.AddWithValue("SOYADI", item.SOYADI);
                com.Parameters.AddWithValue("NUMARA", item.NUMARA);
                com.Parameters.AddWithValue("ID", item.ID);
                sonuc = com.ExecuteNonQuery() > 0;
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
                OleDbCommand com = new OleDbCommand("DELETE FROM OGRENCI WHERE ID=@ID", BAGLANTI.Con);
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

        public static EOGRENCI Select(int _ID)
        {
            EOGRENCI item = null;
            try
            {
                OleDbCommand com = new OleDbCommand("SELECT * FROM OGRENCI WHERE ID=@ID", BAGLANTI.Con);
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
                        item = new EOGRENCI();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.ADI = rdr["ADI"].ToString();
                        item.SOYADI = rdr["SOYADI"].ToString();
                        item.NUMARA = Convert.ToInt32(rdr["NUMARA"]);
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

        public static List<EOGRENCI> SelectList()
        {
            List<EOGRENCI> itemList = new List<EOGRENCI>();
            try
            {
                OleDbCommand com = new OleDbCommand("SELECT * FROM OGRENCI", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                OleDbDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EOGRENCI>();
                    while (rdr.Read())
                    {
                        EOGRENCI item = new EOGRENCI();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.ADI = rdr["ADI"].ToString();
                        item.SOYADI = rdr["SOYADI"].ToString();
                        item.NUMARA = Convert.ToInt32(rdr["NUMARA"]);
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

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
    public class FISLEMLER
    {
        public static int Insert(EISLEMLER item)
        {
            int etkilenen = 0;
            try//try catch kullanarak programın patlamasını önlüyorum
            {
                OleDbCommand com = new OleDbCommand("INSERT INTO ISLEMLER (KITAPID, OGRENCIID,GMT,SONGMT,GETGMT) Values(@KITAPID, @OGRENCIID,@GMT,@SONGMT,@GETGMT)", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("KITAPID", item.KITAPID);
                com.Parameters.AddWithValue("OGRENCIID", item.OGRENCIID);
                com.Parameters.AddWithValue("GMT", item.GMT);
                com.Parameters.AddWithValue("SONGMT", item.SONGMT);
                com.Parameters.AddWithValue("GETGMT", item.GETGMT);
                etkilenen = com.ExecuteNonQuery();
            }
            catch
            {
                etkilenen = -1;
            }
            return etkilenen;
        }

        public static bool Update(EISLEMLER item)
        {
            bool sonuc = false;
            try//try catch kullanarak programın patlamasını önlüyorum
            {
                OleDbCommand com = new OleDbCommand("UPDATE ISLEMLER SET GETGMT=@GETGMT WHERE ID=@ID", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }                
                com.Parameters.AddWithValue("GETGMT", item.GETGMT);
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
            try//try catch kullanarak programın patlamasını önlüyorum
            {
                OleDbCommand com = new OleDbCommand("DELETE FROM ISLEMLER WHERE ID=@ID", BAGLANTI.Con);
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

        public static EISLEMLER Select(int _ID)
        {
            EISLEMLER item = null;
            try//try catch kullanarak programın patlamasını önlüyorum
            {
                OleDbCommand com = new OleDbCommand("SELECT * FROM ISLEMLER WHERE KITAPID=@ID", BAGLANTI.Con);
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
                        item = new EISLEMLER();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.KITAPID = Convert.ToInt32(rdr["KITAPID"]);
                        item.OGRENCIID = Convert.ToInt32(rdr["OGRENCIID"]);
                        item.GMT = Convert.ToDateTime(rdr["GMT"]);
                        item.SONGMT = Convert.ToDateTime(rdr["SONGMT"]);
                        item.GETGMT = Convert.ToDateTime(rdr["GETGMT"]);                                              
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

        public static List<EISLEMLER> Select2(int _ID)
        {
            List<EISLEMLER> itemList = new List<EISLEMLER>();
            try//try catch kullanarak programın patlamasını önlüyorum
            {
                OleDbCommand com = new OleDbCommand("SELECT ISLEMLER.ID,ISLEMLER.GMT,ISLEMLER.SONGMT,ISLEMLER.GETGMT,KITAP.ADI,OGRENCI.NUMARA FROM ((ISLEMLER INNER JOIN KITAP ON ISLEMLER.KITAPID=KITAP.ID) INNER JOIN OGRENCI ON ISLEMLER.OGRENCIID=OGRENCI.ID) WHERE OGRENCIID=@ID", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ID", _ID);
                OleDbDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EISLEMLER>();
                    while (rdr.Read())
                    {
                        EISLEMLER item = new EISLEMLER();
                        item.ID = Convert.ToInt32(rdr["ID"]);                       
                        item.GMT = Convert.ToDateTime(rdr["GMT"]);
                        item.SONGMT = Convert.ToDateTime(rdr["SONGMT"]);
                        item.GETGMT = Convert.ToDateTime(rdr["GETGMT"]);                      
                        item.KITAPADI = rdr["ADI"].ToString();
                        item.OGRENCINUMARA = Convert.ToInt32(rdr["NUMARA"]);
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
        public static List<EISLEMLER> Select3(int _ID)
        {
            List<EISLEMLER> itemList = new List<EISLEMLER>();
            try//try catch kullanarak programın patlamasını önlüyorum
            {
                OleDbCommand com = new OleDbCommand("SELECT ISLEMLER.ID,ISLEMLER.GMT,ISLEMLER.SONGMT,ISLEMLER.GETGMT,KITAP.ADI,OGRENCI.NUMARA FROM ((ISLEMLER INNER JOIN KITAP ON ISLEMLER.KITAPID=KITAP.ID) INNER JOIN OGRENCI ON ISLEMLER.OGRENCIID=OGRENCI.ID) WHERE KITAPID=@ID", BAGLANTI.Con);
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ID", _ID);
                OleDbDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EISLEMLER>();
                    while (rdr.Read())
                    {
                        EISLEMLER item = new EISLEMLER();
                        item.ID = Convert.ToInt32(rdr["ID"]);                       
                        item.GMT = Convert.ToDateTime(rdr["GMT"]);
                        item.SONGMT = Convert.ToDateTime(rdr["SONGMT"]);
                        item.GETGMT = Convert.ToDateTime(rdr["GETGMT"]);                       
                        item.KITAPADI = rdr["ADI"].ToString();
                        item.OGRENCINUMARA = Convert.ToInt32(rdr["NUMARA"]);
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

        public static List<EISLEMLER> SelectList()
        {
            List<EISLEMLER> itemList = new List<EISLEMLER>();
            try//try catch kullanarak programın patlamasını önlüyorum
            {                                          
                OleDbCommand com = new OleDbCommand("SELECT ISLEMLER.ID,ISLEMLER.GMT,ISLEMLER.SONGMT,ISLEMLER.GETGMT,KITAP.ADI,OGRENCI.NUMARA FROM ((ISLEMLER INNER JOIN KITAP ON ISLEMLER.KITAPID=KITAP.ID) INNER JOIN OGRENCI ON ISLEMLER.OGRENCIID=OGRENCI.ID)", BAGLANTI.Con);            
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                OleDbDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EISLEMLER>();
                    while (rdr.Read())
                    {
                        EISLEMLER item = new EISLEMLER();                                              
                        item.ID = Convert.ToInt32(rdr["ID"]);                        
                        item.GMT = Convert.ToDateTime(rdr["GMT"]);
                        item.SONGMT = Convert.ToDateTime(rdr["SONGMT"]);
                        item.GETGMT = Convert.ToDateTime(rdr["GETGMT"]);                        
                        item.KITAPADI = rdr["ADI"].ToString();
                        item.OGRENCINUMARA = Convert.ToInt32(rdr["NUMARA"]);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLOGRENCI
    {
        public static int Insert(EOGRENCI item)
        {
            if (item.ADI != null && item.ADI.Trim().Length > 0 && item.SOYADI != null && item.SOYADI.Trim().Length > 0 && item.NUMARA > 0)//gelen değerleri kontrol ediyorum
            {
                return FOGRENCI.Insert(item);
            }
            return -1;
        }

        public static bool Update(EOGRENCI item)
        {
            if (item.ID > 0 && item.ADI != null && item.ADI.Trim().Length > 0 && item.SOYADI != null && item.SOYADI.Trim().Length > 0 && item.NUMARA > 0)//gelen değerleri kontrol ediyorum
            {
                return FOGRENCI.Update(item);
            }
            return false;
        }

        public static bool Delete(int _ID)
        {
            if (_ID > 0)//gelen değerleri kontrol ediyorum
            {
                return FOGRENCI.Delete(_ID);
            }
            return false;
        }

        public static EOGRENCI Select(int _ID)
        {
            if (_ID > 0)//gelen değerleri kontrol ediyorum
            {
                return FOGRENCI.Select(_ID);
            }
            return null;
        }

        public static List<EOGRENCI> SelectList()
        {
            return FOGRENCI.SelectList();
        }
    }
}

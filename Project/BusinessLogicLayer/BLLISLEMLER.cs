using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLISLEMLER
    {
        public static int Insert(EISLEMLER item)
        {
            if (item.KITAPID > 0 && item.OGRENCIID > 0)//gelen değerleri kontrol ediyorum
            {
                return FISLEMLER.Insert(item);
            }
            return -1;
        }

        public static bool Update(EISLEMLER item)
        {
            if (item.ID > 0)//gelen değerleri kontrol ediyorum
            {
                return FISLEMLER.Update(item);
            }
            return false;
        }       

        public static bool Delete(int _ID)
        {
            if (_ID > 0)//gelen değerleri kontrol ediyorum
            {
                return FISLEMLER.Delete(_ID);
            }
            return false;
        }

        public static EISLEMLER Select(int _ID)
        {
            if (_ID > 0)//gelen değerleri kontrol ediyorum
            {
                return FISLEMLER.Select(_ID);
            }
            return null;
        }
        public static List<EISLEMLER> Select2(int _ID)
        {
            if (_ID > 0)//gelen değerleri kontrol ediyorum
            {
                return FISLEMLER.Select2(_ID);
            }
            return null;
        }
        public static List<EISLEMLER> Select3(int _ID)
        {
            if (_ID > 0)//gelen değerleri kontrol ediyorum
            {
                return FISLEMLER.Select3(_ID);
            }
            return null;
        }

        public static List<EISLEMLER> SelectList()
        {
            return FISLEMLER.SelectList();
        }
    }
}

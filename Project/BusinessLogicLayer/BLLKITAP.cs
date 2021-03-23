using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLKITAP
    {
        public static int Insert(EKITAP item)
        {
            if (item.ADI != null && item.ADI.Trim().Length > 0 && item.YAZAR != null && item.YAZAR.Trim().Length > 0 && item.SAYFASAYISI > 0)//gelen değerleri kontrol ediyorum
            {
                return FKITAP.Insert(item);
            }
            return -1;
        }

        public static bool Update(EKITAP item)
        {
            if (item.ID > 0 && item.ADI != null && item.ADI.Trim().Length > 0 && item.YAZAR != null && item.YAZAR.Trim().Length > 0 && item.SAYFASAYISI > 0)//gelen değerleri kontrol ediyorum
            {
                return FKITAP.Update(item);
            }
            return false;
        }

        public static bool Delete(int _ID)//gelen değerleri kontrol ediyorum
        {
            if (_ID > 0)
            {
                return FKITAP.Delete(_ID);
            }
            return false;
        }

        public static EKITAP Select(int _ID)//gelen değerleri kontrol ediyorum
        {
            if (_ID > 0)
            {
                return FKITAP.Select(_ID);
            }
            return null;
        }

        public static List<EKITAP> SelectList()
        {
            return FKITAP.SelectList();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EISLEMLER
    {
        private int _ID;
        public int ID
        {
            get => _ID;
            set => _ID = value;
        }

        private int _KITAPID;
        public int KITAPID
        {
            get => _KITAPID;
            set => _KITAPID = value;
        }     

        private int _OGRENCIID;
        public int OGRENCIID
        {
            get => _OGRENCIID;
            set => _OGRENCIID = value;
        }

        private DateTime _GMT;
        public DateTime GMT
        {
            get => _GMT;
            set => _GMT = value;
        }

        private DateTime _SONGMT;
        public DateTime SONGMT
        {
            get => _SONGMT;
            set => _SONGMT = value;
        }

        private DateTime _GETGMT;
        public DateTime GETGMT
        {
            get => _GETGMT;
            set => _GETGMT = value;
        }
        private string _KITAPADI;
        public string KITAPADI
        {
            get => _KITAPADI;
            set => _KITAPADI = value;
        }

        private int _OGRENCINUMARA;
        public int OGRENCINUMARA
        {
            get => _OGRENCINUMARA;
            set => _OGRENCINUMARA = value;
        }         
    }
}

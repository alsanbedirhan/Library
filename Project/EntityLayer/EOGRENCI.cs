using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EOGRENCI
    {
        private int _ID;
        public int ID
        {
            get => _ID;
            set => _ID = value;
        }

        private string _ADI;
        public string ADI
        {
            get => _ADI;
            set => _ADI = value;
        }

        private string _SOYADI;
        public string SOYADI
        {
            get => _SOYADI;
            set => _SOYADI = value;
        }

        private int _NUMARA;
        public int NUMARA
        { 
            get => _NUMARA; 
            set => _NUMARA = value; 
        }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EKITAP
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
        private string _YAZAR;
        public string YAZAR
        {
            get => _YAZAR;
            set => _YAZAR = value;
        }
        private int _SAYFASAYISI;
        public int SAYFASAYISI
        {
            get => _SAYFASAYISI;
            set => _SAYFASAYISI = value;
        }
    }
}

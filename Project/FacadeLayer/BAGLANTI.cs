using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace FacadeLayer
{
    class BAGLANTI
    {
        public static OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=proje.mdb");
    }
}

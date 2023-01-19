using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Context
{
    internal class Urun
    {

        public int UrunID { get; set; }
        public string UrunAdı { get; set; }
        public int BarkodNo { get; set; }
        public int StokMiktar { get; set; }
        public decimal SatisFiyati { get; set; }
        public int Kar { get; set; }

    }
}

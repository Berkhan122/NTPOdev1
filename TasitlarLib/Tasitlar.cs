using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasitlarLib
{
    public class Tasitlar
    {
        private string marka;
        private string model;
        private string yolcukapasitesi;
        private string motorgucu;
        private string uretimyili;
        private string renk;
        private string sonhiz;

        public string Marka { get => marka; set => marka = value.ToUpper(); }
        public string Model { get => model; set => model = value; }
        public string Yolcukapasitesi { get => yolcukapasitesi; set => yolcukapasitesi = value + " kişi"; }
        public string Motorgucu { get => motorgucu; set => motorgucu = value + " hp"; }
        public string Uretimyili { get => uretimyili; set => uretimyili = value; }
        public string Renk { get => renk; set => renk = value; }
        public string Sonhiz { get => sonhiz; set => sonhiz = value; }
    }
}

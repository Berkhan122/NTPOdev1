using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasitlarLib
{
    public class Araba : Tasitlar
    {
        private string kapisayisi;
        private string segment;
        private string jantcapi;
        private string motorturu;//dizel/benzin/gaz
        private string sifiryuz;


        public string Txt(string kapisayisi, string segment, string jantcapi, string motorturu, string sifiryuz, string marka, string model, string yolcukapasitesi, string motorgucu, string uretimyili, string renk, string sonhiz)
        {
            this.Kapisayisi = kapisayisi;
            this.Segment = segment;
            this.Jantcapi = jantcapi;
            this.Motorturu = motorturu;
            this.Sifiryuz = sifiryuz;
            this.Marka = marka;
            this.Model = model;
            this.Yolcukapasitesi = yolcukapasitesi;
            this.Motorturu = motorturu;
            this.Motorgucu = motorgucu;
            this.Renk = renk;
            this.Sonhiz = sonhiz;
            this.Uretimyili = uretimyili;


            /*
             arac.Txt(arac.Marka, arac.Model, arac.Renk, arac.Kapisayisi, arac.Segment, arac.Uretimyili
                        , arac.Sonhiz, arac.Yolcukapasitesi, arac.Motorturu, arac.Motorgucu, arac.Jantcapi, arac.Sifiryuz);
            */

            return marka + " " + model + " " + renk + " " + kapisayisi + " " + segment + " " + uretimyili + " " + sonhiz + " " + yolcukapasitesi + " " + motorturu + " " + motorgucu + " " + jantcapi + " " + sifiryuz;
        }

        public string Kapisayisi { get => kapisayisi; set => kapisayisi = value; }
        public string Segment { get => segment; set => segment = value; }
        public string Jantcapi { get => jantcapi; set => jantcapi = value + " '"; }
        public string Motorturu { get => motorturu; set => motorturu = value; }
        public string Sifiryuz { get => sifiryuz; set => sifiryuz = value + " sn"; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasitlarLib;
using System.IO;
namespace NTPOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Araba arac = new Araba();

            byte aracsayisi = 0;
            Console.Write("Giriş yapacağınız araç sayısını giriniz:");
            aracsayisi = byte.Parse(Console.ReadLine());
            string[] tasit = new string[aracsayisi];



            if (aracsayisi > 0)
            {
                for (int i = 0; i < aracsayisi; i++)
                {
                    Console.Write("Aracın Markasını Giriniz: ");
                    arac.Marka = Console.ReadLine();
                    Console.Write("Aracın Modelini Giriniz: ");
                    arac.Model = Console.ReadLine();
                    Console.Write("Aracın Rengini Giriniz: ");
                    arac.Renk = Console.ReadLine();
                    Console.Write("Aracın Kapı Sayısını Giriniz: ");
                    arac.Kapisayisi = Console.ReadLine();
                    Console.Write("Aracın Segmentini Giriniz: ");
                    arac.Segment = Console.ReadLine();
                    Console.Write("Aracın Üretim Yılını Giriniz: ");
                    arac.Uretimyili = Console.ReadLine();
                    Console.Write("Aracın Son Hızını Giriniz: ");
                    arac.Sonhiz = Console.ReadLine();
                    Console.Write("Aracın Yolcu Kapasitesini Giriniz: ");
                    arac.Yolcukapasitesi = Console.ReadLine();
                    Console.Write("Aracın Motor Türünü Giriniz: ");
                    arac.Motorturu = Console.ReadLine();
                    Console.Write("Aracın Motor Gücünü Giriniz: ");
                    arac.Motorgucu = Console.ReadLine();
                    Console.Write("Aracın Jant Çapını Giriniz: ");
                    arac.Jantcapi = Console.ReadLine();
                    Console.Write("Aracın Sıfır-Yüz Değerini Giriniz: ");
                    arac.Sifiryuz = Console.ReadLine();

                    tasit[i] = arac.Txt(arac.Marka, arac.Model, arac.Renk, arac.Kapisayisi, arac.Segment, arac.Uretimyili
                        , arac.Sonhiz, arac.Yolcukapasitesi, arac.Motorturu, arac.Motorgucu, arac.Jantcapi, arac.Sifiryuz);
                    DosyaYazdir(tasit);
                }
            }
            else
            {
                Console.WriteLine("Lütfen 0'dan farklı ve 0'dan büyük bir sayı giriniz.");
            }

            Console.ReadKey();
        }

        

        static void DosyaYazdir(string[] deger)
        {
            FileStream f = new FileStream("araclar.txt", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(f);

            for (int i = 0; i < deger.Length; i++)
            {
                s.Write(deger[i]+"\n");
            }
            s.Close();
            f.Close();
            Console.WriteLine("Dosya yazımı gerçekleşti..");
            Console.ReadKey();
        }
    }
}

/***********************************************************************************************************************************
 SAKARYA ÜNİVERSİTESİ
 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 NESNEYE DAYALI PROGRAMLAMA DERSİ
 2019-2020 BAHAR DÖNEMİ
 ADI:ZEHRA BEGÜM  SOYADI:AKTOLGA   NUMARASI:B191210062   GRUP:1C GRUBU 1.ÖĞRETİM
/***********************************************************************************************************************************/
using System;
namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            //DOSYAYI AÇMAYI SAĞLAR.
            /* string dosya_adi = "sınıf.txt";
           string dosya_yolu1 = @"c:\sınıf";
           string hedefyol = System.IO.Path.Combine(dosya_yolu1, dosya_adi);
           System.IO.File.Create(hedefyol);
           Console.ReadKey();*/
            //SINIF DOSYASINDA BULUNAN sınıf.txt METNİNDEN BİLGİLERE ULAŞMAYI SAĞLAR.
            string[] satirlar = System.IO.File.ReadAllLines(@"C:\sınıf\sınıf.txt");
            string[] bılgıler = new string[7];
            double[] notlar = new double[4];
            string[] isimler = new string[7];
            double[] Ortalamalar = new double[satirlar.Length];
            string[] not = new string[satirlar.Length];
            double[] Yüzde = new double[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string[] yüzdeler = new string[9];
            // DÖNGÜ SATIR UZUNLUĞUNA GÖRE ORTALAMALARIN,İSİMLERİN,NOTLARIN,NUMARALARIN OKUNMASINI VE EKRANA YAZDIRILMASINI SAĞLAR.
            for (int i = 0; i < satirlar.Length; i++)
            {
                bılgıler = satirlar[i].Split(' ');//BOŞLUKLARI AYIRMAYI SAĞLAR.
                for (int j = 0; j < 4; j++)
                {
                    notlar[j] = Convert.ToDouble((bılgıler[j + 3]));
                }
                for (int n = 0; n < 7; n++)
                {
                    isimler[n] = (bılgıler[n]);
                    Console.Write(isimler[n]); Console.Write(" ");
                }
                Ortalamalar[i] = notlar[0] * 0.1 + notlar[1] * 0.1 + notlar[2] * 0.3 + notlar[3] * 0.5;
                Console.WriteLine(" ");
                Console.WriteLine("Ortalaması:{0}", Ortalamalar[i]);
                //BU DÖNGÜ HARF NOTLARININ BELİRLENMESİNİ VE HANGİ HARF NOTUNDAN KAÇ ADET OLDUĞUNU BULMAYI SAĞLAR.
                if (90 <= Ortalamalar[i] && Ortalamalar[i] <= 100)
                {
                    Console.WriteLine("HARF NOTU:AA");
                    ++Yüzde[0];
                }
                else if (85 <= Ortalamalar[i] && Ortalamalar[i] <= 89.99)
                {
                    Console.WriteLine("HARF NOTU:BA");
                    ++Yüzde[1];
                }
                else if (80 <= Ortalamalar[i] && Ortalamalar[i] <= 84.99)
                {
                    Console.WriteLine("HARF NOTU:BB");
                    ++Yüzde[2];
                }
                else if (75 <= Ortalamalar[i] && Ortalamalar[i] <= 79.99)
                {
                    Console.WriteLine("HARF NOTU:CB");
                    ++Yüzde[3];
                }
                else if (65 <= Ortalamalar[i] && Ortalamalar[i] <= 74.99)
                {
                    Console.WriteLine("HARF NOTU:CC");
                    ++Yüzde[4];
                }
                else if (58 <= Ortalamalar[i] && Ortalamalar[i] <= 64.99)
                {
                    Console.WriteLine("HARF NOTU:DC");
                    ++Yüzde[5];
                }
                else if (50 <= Ortalamalar[i] && Ortalamalar[i] <= 57.99)
                {
                    Console.WriteLine("HARF NOTU:DD");
                    ++Yüzde[6];
                }
                else if (40 <= Ortalamalar[i] && Ortalamalar[i] <= 49.99)
                {
                    Console.WriteLine("HARF NOTU:FD");
                    ++Yüzde[7];
                }
                else
                {
                    Console.WriteLine("KALDI");
                    ++Yüzde[8];
                }
            }
            Console.WriteLine("HANGİ HARF NOTUNDAN KAÇ TANE VAR: ");
            Console.WriteLine("HARF NOTU AA OLANLARIN SAYISI:{0}", Yüzde[0]);
            Console.WriteLine("HARF NOTU BA OLANLARIN SAYISI:{0}", Yüzde[1]);
            Console.WriteLine("HARF NOTU BB OLANLARIN SAYISI:{0}", Yüzde[2]);
            Console.WriteLine("HARF NOTU CB OLANLARIN SAYISI:{0}", Yüzde[3]);
            Console.WriteLine("HARF NOTU CC OLANLARIN SAYISI:{0}", Yüzde[4]);
            Console.WriteLine("HARF NOTU DC OLANLARIN SAYISI:{0}", Yüzde[5]);
            Console.WriteLine("HARF NOTU DD OLANLARIN SAYISI:{0}", Yüzde[6]);
            Console.WriteLine("HARF NOTU FD OLANLARIN SAYISI:{0}", Yüzde[7]);
            Console.WriteLine("KALANLARIN SAYISI:{0}", Yüzde[8]);
            Console.WriteLine("HARF NOTLARININ YÜZDESİ: ");
            Console.WriteLine("HARF NOTU AA OLANLARIN YÜZDESİ:%{0}", (Yüzde[0] * 100) / satirlar.Length);
            Console.WriteLine("HARF NOTU BA OLANLARIN YÜZDESİ:%{0}", (Yüzde[1] * 100) / satirlar.Length);
            Console.WriteLine("HARF NOTU BB OLANLARIN YÜZDESİ:%{0}", (Yüzde[2] * 100) / satirlar.Length);
            Console.WriteLine("HARF NOTU CB OLANLARIN YÜZDESİ:%{0}", (Yüzde[3] * 100) / satirlar.Length);
            Console.WriteLine("HARF NOTU CC OLANLARIN YÜZDESİ:%{0}", (Yüzde[4] * 100) / satirlar.Length);
            Console.WriteLine("HARF NOTU DC OLANLARIN YÜZDESİ:%{0}", (Yüzde[5] * 100) / satirlar.Length);
            Console.WriteLine("HARF NOTU DD OLANLARIN YÜZDESİ:%{0}", (Yüzde[6] * 100) / satirlar.Length);
            Console.WriteLine("HARF NOTU FD OLANLARIN YÜZDESİ:%{0}", (Yüzde[7] * 100) / satirlar.Length);
            Console.WriteLine("KALANLARIN YÜZDESİ:%{0}", (Yüzde[8] * 100) / satirlar.Length);
            //Yüzdeyi STRİNGE DÖNÜŞTÜRÜR VE yüzdeler DİZİSİNE ATAR.
            for (int k = 0; k < 9; k++)
            {
                yüzdeler[k] = Convert.ToString(Yüzde[k]);
            }
            string[] sayilar = { "AA HARF NOTU SAYISI:",yüzdeler[0],"BA HARF NOTU SAYISI:",yüzdeler[1], "BB HARF NOTU SAYISI:",yüzdeler[2],"CB HARF NOTU SAYISI:",yüzdeler[3],
                 "CC HARF NOTU SAYISI:",yüzdeler[4],"DC HARF NOTU SAYISI:",yüzdeler[5], "DD HARF NOTU SAYISI:",yüzdeler[6],"FD HARF NOTU SAYISI:",yüzdeler[7],
                   "KALANLARIN SAYISI:",yüzdeler[8]  };
            //yüzde.txt METNİNE HANGİ HARF NOTUNDAN KAÇ TANE OLDUĞUNU YAZDIRIR.
            System.IO.File.WriteAllLines(@"c:\sınıf\yüzde.txt", sayilar);
            //ORTALAMALARI STRİNGE ÇEVİRİR VE not DİZİSİNİN İÇİNE ATAR.
            for (int k = 0; k < satirlar.Length; k++)
            {
                not[k] = Convert.ToString(Ortalamalar[k]);
            }
            //Yüzdeyi STRİNGE DÖNÜŞTÜRÜR VE yüzdeler DİZİSİNİN İÇİNE ATAR.
            for (int k = 0; k < 9; k++)
            {
                yüzdeler[k] = Convert.ToString(Yüzde[k] * 100 / satirlar.Length);
            }
            //yüzde.txt METNİNİN DEVAMINA YÜZDELERİ,İSİMLERİ VE ORTALAMALARI EKLER.
            using (System.IO.StreamWriter yüzde = new System.IO.StreamWriter(@"c:\sınıf\yüzde.txt", true))
            {
                yüzde.WriteLine("AA HARF NOTU YÜZDESİ:%{0}", yüzdeler[0]);
                yüzde.WriteLine("BA HARF NOTU YÜZDESİ:%{0}", yüzdeler[1]);
                yüzde.WriteLine("BB HARF NOTU YÜZDESİ:%{0}", yüzdeler[2]);
                yüzde.WriteLine("CB HARF NOTU YÜZDESİ:%{0}", yüzdeler[3]);
                yüzde.WriteLine("CC HARF NOTU YÜZDESİ:%{0}", yüzdeler[4]);
                yüzde.WriteLine("DC HARF NOTU YÜZDESİ:%{0}", yüzdeler[5]);
                yüzde.WriteLine("DD HARF NOTU YÜZDESİ:%{0}", yüzdeler[6]);
                yüzde.WriteLine("FD HARF NOTU YÜZDESİ:%{0}", yüzdeler[7]);
                yüzde.WriteLine("KALANLARIN YÜZDESİ:%{0}", yüzdeler[8]);
                yüzde.WriteLine("MEHMET YILMAZ B1912 20 40 60 70 Ortalaması:{0}", not[0]);
                yüzde.WriteLine("AHMET KAYA B1913 30 30 60 40 Ortalaması:{0}", not[1]);
                yüzde.WriteLine("AYŞE GÜMÜŞ B1914 70 80 60 50 Ortalaması:{0}", not[2]);
                yüzde.WriteLine("BURCU ÖZTÜRK B1915 100 100 60 50 Ortalaması:{0}", not[3]);
                yüzde.WriteLine("FATMA YILDIRIM B1917 80 56 40 50 Ortalaması:{0}", not[4]);
                yüzde.WriteLine("SEMA AKGÜL B1920 85 95 65 55 Ortalaması:{0}", not[5]);
                yüzde.WriteLine("DUHA YILMAZ B1936 76 95 65 75 Ortalaması:{0}", not[6]);
                yüzde.WriteLine("ALEYNA SÖNMEZ B1942 94 91 76 56 Ortalaması:{0}", not[7]);
                yüzde.WriteLine("TUBA AKKURT B1923 89 75 60 70 Ortalaması:{0}", not[8]);
                yüzde.WriteLine("SEVCAN KAYA B1945 96 75 60 70 Ortalaması:{0}", not[9]);
                yüzde.WriteLine("FATİH YILMAZ B1944 26 30 23 15 Ortalaması:{0}", not[10]);
                yüzde.WriteLine("OSMAN AKIN B1962 97 96 78 75 Ortalaması:{0}", not[11]);
                yüzde.WriteLine("DENİZ TOLGA B1975 85 96 85 75 Ortalaması:{0}", not[12]);
                yüzde.WriteLine("REŞAT AK B1984 92 93 85 90 Ortalaması:{0}", not[13]);
                yüzde.WriteLine("BEGÜM KAYA B1912 20 40 60 70 Ortalaması:{0}", not[14]);
                yüzde.WriteLine("AKIN AKTOLGA B1931 100 100 95 90 Ortalaması:{0}", not[15]);
                yüzde.WriteLine("ELİF SÖNMEZ B1910 30 35 45 40 Ortalaması:{0}", not[16]);
                yüzde.WriteLine("YUSUF ŞAHİN B1992 80 80 78 88 Ortalaması:{0}", not[17]);
                yüzde.WriteLine("ŞAFAK AKCAN B1981 75 85 60 78 Ortalaması:{0}", not[18]);
                yüzde.WriteLine("ORHAN YILDIRIM B1967 76 96 74 78 Ortalaması:{0}", not[19]);
            }
            Console.ReadKey();
        }
    }
}

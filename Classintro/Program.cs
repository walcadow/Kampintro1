using System;

namespace Classintro
{
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int İzlenmeOranı { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Melih";
            kurs1.İzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Melih Mert Sakur";
            kurs2.İzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmen = "Melih Mert";
            kurs3.İzlenmeOranı = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Kurs kurs = kurslar[i];
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Eğitmen);
                Console.WriteLine(kurs.İzlenmeOranı);
            }
        }
    }
}





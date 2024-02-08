using BusinessTekrar.ConcreteTekrar;
using EntitiesTekrar.ConcreteTekrar;

using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace WorkaroundTekrar
{


    class Program
    {
        static void Main(string[] args)
        {

            SelamVer("Engin");
            SelamVer("Ahmet");
            SelamVer("Ayşe");
            SelamVer();

            int sonuc = Topla(6,58);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);


            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler =new string[4];

             ogrenciler[3] = "İlker";

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1= new[] {"Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] {"Bursa", "Antalya", "Diyarbakır"};

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            PersonTekrar personTekrar1 = new PersonTekrar();
            personTekrar1.FirstName = "ENGİN";
            personTekrar1.LastName = "DEMİROĞ";
            personTekrar1.DateOfBirthYear = 1985;
            personTekrar1.NationalIdentity = 123;



            PersonTekrar personTekrar2 = new PersonTekrar();
            personTekrar2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);

            }

            List<string> yeniSehirler1 = new List<string> {"Ankara 1","İstanbul 1","İzmir 1" };

            yeniSehirler1.Add("Adana 1");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManagerTekrar pttManagerTekrar = new PttManagerTekrar(new PersonManagerTekrar());
            pttManagerTekrar.GiveMask(personTekrar1);






            Console.ReadLine();
        }

      
        //resharper
        static void SelamVer(string isim= "isimsiz")
        {

            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1=5,int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;

            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }


    }

}

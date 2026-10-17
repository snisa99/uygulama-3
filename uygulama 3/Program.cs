using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_3
{
    internal class Program
    {
       
           
class Ekipman
        {
            public string DemirbasNo;
            public string Ad;
            public bool OduncteMi = false;

            public Ekipman(string no, string ad)
            {
                DemirbasNo = no;
                Ad = ad;
            }
        }

        class Ogrenci
        {
            public string OgrenciNo;
            public string Ad;

            public Ogrenci(string no, string ad)
            {
                OgrenciNo = no;
                Ad = ad;
            }
        }

      
            static Ekipman EkipmanBul(List<Ekipman> liste, string no)
            {
                foreach (Ekipman e in liste)
                {
                    if (e.DemirbasNo == no)
                        return e;
                }

                return null;
            }

            static Ogrenci OgrenciBul(List<Ogrenci> liste, string no)
            {
                foreach (Ogrenci o in liste)
                {
                    if (o.OgrenciNo == no)
                        return o;
                }

                return null;
            }

            static void OduncVer(Ekipman e, Ogrenci o)
            {
                if (e == null || o == null)
                {
                    Console.WriteLine("Ekipman veya ogrenci bulunamadi.");
                }
                else if (e.OduncteMi)
                {
                    Console.WriteLine("Ekipman zaten oduncte.");
                }
                else
                {
                    e.OduncteMi = true;
                    Console.WriteLine(e.Ad + ", " + o.Ad +
                                      " ogrencisine odunc verildi.");
                }
            }

            static void IadeAl(Ekipman e)
            {
                if (e == null)
                {
                    Console.WriteLine("Ekipman bulunamadi.");
                }
                else if (!e.OduncteMi)
                {
                    Console.WriteLine("Ekipman zaten iade edilmis.");
                }
                else
                {
                    e.OduncteMi = false;
                    Console.WriteLine(e.Ad + " iade alindi.");
                }
            }

            static void Main()
            {
                // Listeleri olustur
                List<Ekipman> ekipmanlar = new List<Ekipman>
        {
            new Ekipman("D001", "Laptop"),
            new Ekipman("D002", "Projeksiyon"),
            new Ekipman("D003", "Tablet")
        };

                List<Ogrenci> ogrenciler = new List<Ogrenci>
        {
            new Ogrenci("100", "Ali"),
            new Ogrenci("101", "Ayse")
        };

                // Demirbas numarasiyla ekipman ve ogrenci bul
                Ekipman ekipman = EkipmanBul(ekipmanlar, "D001");
                Ogrenci ogrenci = OgrenciBul(ogrenciler, "100");

                // Birinci odunc
                Console.WriteLine("1. Odunc:");
                OduncVer(ekipman, ogrenci);

                // Ikinci odunc
                Console.WriteLine("\n2. Odunc:");
                OduncVer(ekipman, ogrenci);

                // Birinci iade
                Console.WriteLine("\n1. Iade:");
                IadeAl(ekipman);

                // Ikinci iade
                Console.WriteLine("\n2. Iade:");
                IadeAl(ekipman);

                // Bulunamayan ekipman
                Console.WriteLine("\nBulunamayan ekipman:");
                Ekipman bulunamayan = EkipmanBul(ekipmanlar, "D999");
                IadeAl(bulunamayan);

                // Bulunamayan ogrenci
                Console.WriteLine("\nBulunamayan ogrenci:");
                Ogrenci olmayan = OgrenciBul(ogrenciler, "999");
                OduncVer(ekipman, olmayan);
            }
        

    }
}


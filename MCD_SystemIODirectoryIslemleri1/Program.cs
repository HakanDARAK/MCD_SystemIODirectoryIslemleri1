using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_SystemIODirectoryIslemleri1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //C sürücüsü içerisinde CodingIsFun adında bir klasör oluşturalım oluşturmadan önce varlık kontrolü yapalım eğer klasör var ise silelim silerken yine kullanıcıdan silmek istiyormusunuz diye E / H ile kontrol sağlayalım daha sonra oluşturalım. eğer klasör yok ise oluşturalım fakat adımların bilgisini ekrana yazdıralım. Bunları yaparken de oluşturdugumuz metodları kullanmayalım.
            bool varlikKontrol = KlasorVarlikKontrolu("c:\\CodingIsFun");

            if (varlikKontrol)
            {
                Console.WriteLine("Aradıgınız dosya C sürücüsünün içerisinde vardır. Silmemizi istiyor musunuz E/H");
                string kullaniciKarari=Console.ReadLine();
                kullaniciKarari.ToLower();

                if (kullaniciKarari=="e")
                {
                    KlasorSilmeIslemi("c:\\CodingIsFun");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Dosya silindi.");
                    Console.WriteLine("Dosya oluşturuluyor");
                    System.Threading.Thread.Sleep(1000);
                    YeniKlasorOlustur("c:\\CodingIsFun");
                    Console.WriteLine("Dosya yeniden oluşturuldu.");

                }
                else if (kullaniciKarari=="h")
                {
                    Console.WriteLine("Dosya silinmedi mevcut hali duruyor.");
                }
                else
                {
                    Console.WriteLine("Lütfen cevabınız E/H formatında olsun");
                }
            }
            else
            {
                Console.WriteLine("Dosyanız Oluşturulmaya başlanıyor.");
                System.Threading.Thread.Sleep(1000);
                YeniKlasorOlustur("c:\\CodingIsFun");
                Console.WriteLine("Dosyanız Oluşturulmuştur.");
            }


            Console.ReadLine();

        }


        //Yeni klasör olusturma
        static void YeniKlasorOlustur(string path)
        {
            Directory.CreateDirectory(path);
        }

        //Klasör varlık kontrolü
        static bool KlasorVarlikKontrolu(string path)
        {
            bool varlikKontrol = Directory.Exists(path);

            return varlikKontrol;
        }

        //Klasör silme işlemi
        static void KlasorSilmeIslemi(string path)
        {
            Directory.Delete(path, true);
        }
        //Klasör taşıma işlemi
        static void KlasorTasimaIslemi(string kaynak, string hedef)
        {
            Directory.Move(kaynak, hedef);
        }

    }
}

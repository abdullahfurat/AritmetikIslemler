using System;

namespace AritmetikIslemler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ctrl + K + S => region

            #region Örnek 1
            //1)  Disaridan alinan iki sayının toplamiyla farkinin birbirine bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)
            /*
            Console.WriteLine("Lütfen 1. Sayıyı giriniz");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sayıyı giriniz");
            int s2 = Convert.ToInt32(Console.ReadLine());

            int toplam = s1 + s2;
            int fark = s1 - s2;
            int result = toplam % fark;

            Console.WriteLine("İşlem sonucu  : " + result);
            */
            #endregion

            #region Örnek 2
            /*
    //2) Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalaninin karesi kactir?

    //2.1) Disaridan girilen bir sayı
    Console.WriteLine("Lütfen bir sayı giriniz");
    int sayi = int.Parse(Console.ReadLine());

    //2.2) Disaridan girilen bir sayının 10 eksigi
    sayi = sayi - 10;


    //2.3) Disaridan girilen bir sayının 10 eksiginin 20 fazlasi
    sayi = sayi + 20;


    //2.4) Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalan

    sayi = sayi % 2;

    //2.5) Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalaninin karesi kactir?

    Console.WriteLine("İşlem sonucu : {0}", sayi * sayi);


    Console.WriteLine("Lütfen bir sayı giriniz");
    sayi = int.Parse(Console.ReadLine()); 
    sayi = (sayi - 10 + 20) % 2; 

    Console.WriteLine("İşlem sonucu : {0}", sayi * sayi);

*/
            #endregion

            #region Örnek 3
            //Disaridan girilen iki sayının karelerinin toplami ile karelerinin farki toplami kactir?
            /*
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
            int sayi2 = int.Parse(Console.ReadLine());


            int k1 = sayi1 * sayi1;
            int k2 = sayi2 * sayi2;

            int toplam = k1 + k2;
            int fark = k1 - k2;

            int result = toplam + fark;
            Console.WriteLine("işlem sonucu : {0}", result);
            */
            #endregion

            #region Örnek 4
            /*
    //Vize notu'nun % 30'u, final notu'nun % 70'ini alıp öğrencinin not ortalamasini cikartan bir uygulama yaziniz... DİKKAT => Notlar ondalikli olabilir?

    Console.WriteLine("Lütfen vize notunuzu giriniz");
    double vize = double.Parse(Console.ReadLine());

    Console.WriteLine("Lütfen final notunuzu giriniz");
    double final = double.Parse(Console.ReadLine());

    double not = (vize * 0.30) + (final * 0.70);
    Console.WriteLine("Not ortalamanız : {0}", not);
    */
            #endregion


            // Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alnız ve  adi.soyadi@hotmail.com şeklinde mail adresi oluşturup kullanıcıya gösteriniz.

            // .ToLower() => tüm krakterleri küçük harfe çevirir.

            Console.WriteLine("Lütfen adınızı giriniz ");
            string firstname = Console.ReadLine().ToLower();
            Console.WriteLine("Lütfen soyadınız giriniz ");
            string lastname = Console.ReadLine().ToLower();

            Console.WriteLine("Mail Adresiniz : {0}.{1}@hotmail.com", firstname, lastname);
            Console.Read();
        }
    }
}

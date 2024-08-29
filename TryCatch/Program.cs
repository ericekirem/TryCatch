using System;

class Program
{
    static void Main()
    {
        try
        {
            // Kullanıcıdan bir sayı girmesini iste
            Console.Write("Lütfen bir sayı giriniz: ");
            string input = Console.ReadLine();

            // Giriş yapılan metni sayıya dönüştür
            int sayi = int.Parse(input);

            // Sayının karesini hesapla ve ekrana yazdır
            int kare = sayi * sayi;
            Console.WriteLine("Girdiğiniz sayının karesi: " + kare);
        }
        catch (FormatException)
        {
            // Geçersiz giriş durumunda hata mesajı göster
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
    }
}
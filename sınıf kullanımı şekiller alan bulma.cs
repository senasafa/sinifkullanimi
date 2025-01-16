using System;

public class Sekiller
{
    
    public double KareAlani(double kenar)
    {
        return kenar * kenar;
    }

    
    public double DikdortgenAlani(double uzunluk, double genislik)
    {
        return uzunluk * genislik;
    }

    
    public double DikdortgenPrizmaAlani(double uzunluk, double genislik, double yukseklik)
    {
        return uzunluk * genislik * yukseklik;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Sekiller sekiller = new Sekiller();

        double kareKenar = 5;
        double kareAlani = sekiller.KareAlani(kareKenar);
        Console.WriteLine($"Karenin Alanı (kenar = {kareKenar}): {kareAlani}");

       
        double dikdortgenUzunluk = 4;
        double dikdortgenGenislik = 3; 
        double dikdortgenAlani = sekiller.DikdortgenAlani(dikdortgenUzunluk, dikdortgenGenislik);
        Console.WriteLine($"Dikdörtgenin Alanı (uzunluk = {dikdortgenUzunluk}, genişlik = {dikdortgenGenislik}): {dikdortgenAlani}");

        double yukseklik = 5; 
        double dikdortgenPrizmaAlani = sekiller.DikdortgenPrizmaAlani(dikdortgenUzunluk, dikdortgenGenislik, yukseklik);
        Console.WriteLine($"Dikdörtgen Prizmanın Alanı (uzunluk = {dikdortgenUzunluk}, genişlik = {dikdortgenGenislik}, yükseklik = {yukseklik}): {dikdortgenPrizmaAlani}");
         Console.ReadKey();
    }
}


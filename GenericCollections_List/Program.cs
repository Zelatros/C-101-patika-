using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //List<T> class
        //T -> object türündedir.
        //System.Collections.Generic

        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        //Count
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        foreach (var item in sayiListesi)
        {
            Console.WriteLine(item);
        }
        foreach (var item in renkListesi)
        {
            Console.WriteLine(item);
        }

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Listeden eleman çıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("Yeşil");

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Liste Serisinde arama
        if (sayiListesi.Contains(10))
        {
            Console.WriteLine("10 Liste içeresinde bulundu.");
        }

        //Eleman ile indexe erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));

        //Diziyi Liste Çevirme
        string[] hayvanlar = {"kedi", "köpek", "kuş"};
        List<string> hayvanlarList = new List<string>(hayvanlar);

        //Liste temizleme
        hayvanlarList.Clear();

        //Liste içerisinde nesne tutmak
        List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
        Kullanıcılar kullanıcı1 = new Kullanıcılar();
        kullanıcı1.Isim = "Ayşe";
        kullanıcı1.Soyisim = "Ali";
        kullanıcı1.Yaş = 22;
        Kullanıcılar kullanıcı2 = new Kullanıcılar();
        kullanıcı2.Isim = "Veli";
        kullanıcı2.Soyisim = "Ahmet";
        kullanıcı2.Yaş = 28;

        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);

        List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
        yeniListe.Add(new Kullanıcılar(){
            Isim = "Deniz",
            Soyisim = "Derin",
            Yaş = 14
        });

        foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
        {
            Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim);
            Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim);
            Console.WriteLine("Kullanıcı Yaşı: " + kullanıcı.Yaş);
        }

        yeniListe.Clear();

    }
}
public class Kullanıcılar{
    private string isim;
    private string soyisim;
    private int yaş;

    public string Isim {
        get => isim;
        set => isim = value;}

     public string Soyisim {
        get => soyisim;
        set => soyisim = value;}

    public int Yaş {
        get => yaş;
        set => yaş = value;}


}
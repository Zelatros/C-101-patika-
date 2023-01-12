using System;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //System.Collections
        ArrayList liste = new ArrayList();
        //liste.Add("Ayşe");
        //liste.Add(2);
        //liste.Add(true);
        //liste.Add('A');

        //İçeresinde verilere ulaşma
        //Console.WriteLine(liste[1]);
        //foreach (var item in liste)
        //{
        //    Console.WriteLine(item);
        //}

        //AddRange
        Console.WriteLine("****AddRange****");
        //string[] renkler = {"kırmızı","sarı","yeşil"};
        List<int> sayılar = new List<int>(){1,8,3,9,92,5};
        //liste.AddRange(renkler);
        liste.AddRange(sayılar);
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Sort
        Console.WriteLine("****Sort****");
        liste.Sort();

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
        //BinarySearch 
        Console.WriteLine("****BinarySearch****");
        Console.WriteLine(liste.BinarySearch(9));

        //Reverse
        Console.WriteLine("****Reverse****");
        liste.Reverse();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Clear
        Console.WriteLine("****Clear****");
        liste.Clear();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
    }
}
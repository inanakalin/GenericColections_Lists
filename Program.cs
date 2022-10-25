using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericColections_Lists
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            ArrayList Koleksiyon = new ArrayList();

            Koleksiyon.Add ("İnan");
            Koleksiyon.Add ("Nebahat");
            Koleksiyon.Add ("Reşit");
            Koleksiyon.Add ("Emre");
            Koleksiyon.Add ("Elif");

            Koleksiyon.Remove ("Emre");
            int eleman = Koleksiyon.Count;

            System.Console.WriteLine(eleman);
            foreach (var isim in Koleksiyon)
            {
                System.Console.WriteLine(isim);
            }

          



        }
    }
}
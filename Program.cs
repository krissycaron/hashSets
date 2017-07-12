using System;
using System.Collections.Generic;

namespace hashSet
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> showroom = new HashSet<string>();
                showroom.Add("Audi");
                showroom.Add("Kia");
                showroom.Add("Cheverolet");
                showroom.Add("Mazada");

                // Console.WriteLine(showroom.Count);

                showroom.Add("Audi");
                foreach (string carz in showroom){
                    Console.WriteLine($"{carz}");
                
                }
            
            HashSet<string> usedCars = new HashSet<string>();
                usedCars.Add("Ford");
                usedCars.Add("Fiat");
                

            showroom.UnionWith(usedCars);
                foreach (string carz in showroom){
                    Console.WriteLine($"{carz}");
                }
        }
    }
}

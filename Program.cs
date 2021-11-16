using System;
using System.Collections.Generic;

namespace Fruit
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Fruit> frList = new List<Fruit>();

            for (int i = 1; i <= 5; i++)
            {
                Fruit fr = new Fruit();

                System.Console.WriteLine($"Please Enter Fruit Name {i} :");
                fr.name = Console.ReadLine();

                System.Console.WriteLine($"Please Enter {fr.name} Weight (KG) :");
                fr.weight = float.Parse(Console.ReadLine());

                System.Console.WriteLine($"Please Enter {fr.name} Price (Toman) :");
                fr.initialPrice = float.Parse(Console.ReadLine());

                fr.totalPrice = fr.initialPrice * fr.weight;

                frList.Add(fr);
                
            }
            System.Console.WriteLine("\n");
            System.Console.WriteLine("<<<<< ** Calculating Your Bill ** >>>>>");
            System.Console.WriteLine("\n");

            foreach (var item in frList)
            {
                System.Console.WriteLine($"*** Details for {item.name} ***");

                System.Console.WriteLine($"Fruit : {item.name}");
                System.Console.WriteLine($"Weight : {item.weight} Kilo");
                System.Console.WriteLine($"Price/Kilo : {item.initialPrice} Toman");
                System.Console.WriteLine($"Total Price of {item.name} : {item.totalPrice} Toman");
                System.Console.WriteLine("\n");

            }
            System.Console.WriteLine("    **********    ");
            System.Console.WriteLine($"*** Total Bill ***");
            System.Console.WriteLine("    **********    ");
            float sum = 0;
            foreach (var item in frList)
            {
                sum = sum + item.totalPrice;
            }
            System.Console.WriteLine($"You Should Pay :{sum} Toman");
            System.Console.WriteLine("\n");


        }
    }


    class Fruit
    {
        public string name;
        public float weight;
        public float initialPrice;
        public float totalPrice;
    }

  
}

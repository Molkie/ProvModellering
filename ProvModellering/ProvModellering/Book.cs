using System;
using System.Collections.Generic;
using System.Text;

namespace ProvModellering
{
    class Book
    {
        //Variabler
        public int price;
        string name;
        int rarity;
        string category;
        int actualValue;
        bool cursed;

        //Random generator
        Random generator = new Random();

        //Lista för namn
        List<string> names = new List<string>() {"Old book", "Red book", "Black book"};
        //Lista för kategori
        List<string> categories = new List<string>() { "History", "Comic", "Dystopian" };

        //Konstruktor
        public Book(string namessss)
        {
            //Slumpar actualValue och rarity
            actualValue = generator.Next(101);
            rarity = generator.Next(101);
            //Slumpar namn och kategori från listorna
            name = names[generator.Next(0, names.Count)];
            category = categories[generator.Next(0, names.Count)];
        }

        //PrintInfo metod
        public void PrintInfo()
        {
            //Skriver ut bokens värden för namn, rarity, kategori och pris
            Console.WriteLine("name: " + name);
            Console.WriteLine("rarity: " + rarity);
            Console.WriteLine("category: " + category);
            Console.WriteLine("price: " + price);
        }

        //Evaluate
        public int Evaluate()
        {
            //Räknar ut det rätta priset
            int rightPrice = actualValue * rarity;
            //Multiplicerar det rätta priset med ett slumpat nummer mellan 0.5 och 1.5. Definerar detta tal som inten output
            //Random vill arbeta med heltal och krånglar därför när man vill ha decimaler, så jag slumpar ett heltal och delar detta på 100
            int output = rightPrice * (generator.Next(50, 151) / 100);
            //Returnerar output
            return (output);
        }

        //GetCategory metod
        public string GetCategory()
        {
            //Returnerar bokens kategori
            return (category);
        }

        //GetName metod
        public string GetName()
        {
            //Returnerar bokens namn
            return (name);
        }
        
        //IsCursed
        public bool IsCursed()
        {
            //Variabel för svaret
            bool answer;
            //Slumpar ett nummer mellan 0 och 100 och definerar denna i inten chance
            int chance = generator.Next(0, 101);
            //Kollar om cursed är true eller false
            if (cursed == true)
            {
                //Om chance är över 20 returneras rätt svar, i det här fallet true
                if(chance > 20)
                {
                    return (true);
                }
                else
                {
                    //Om chance är under 20 returneras fel svar, dvs false
                    return (false);
                }
            }
            //Om cursed är false
            else
            {
                //Den här koden gör samma som ovanstående kod, fast med ombytta roller
                //Om chance är över 20 returneras rätt svar, dvs false
                if (chance > 20)
                {
                    return (false);
                }
                else
                {
                    //Om chance är under 20 returneras fel svar, dvs true
                    return (true);
                }
            }
        }
    }


}

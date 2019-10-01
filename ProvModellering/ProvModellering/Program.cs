using System;
using System.Collections.Generic;

namespace ProvModellering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista för böcker
            List<Book> books = new List<Book>();

            //Kallar metoden som skapar en ny book och lägger till den i listan med böcker
            books.Add(AddBook());

            //Metod för game round som stoppar in listan books som parameter
            GameRound(books);

            //Avslutar programmet
            Console.ReadLine();
        }

        //Metod för att skapa en ny bok och lägga till den i listan.
        static Book AddBook()
        {
            //Låter anvädnaren välja ett namn till boken
            Console.WriteLine("Youve recieved a new book. Give it a name.");
            string n = Console.ReadLine();
            //Skapar en ny instans av klassen Book
            Book b = new Book(n);
            //Kallar metoden PrintInfo i instansen
            b.PrintInfo();
            //Returnerar instansen till Main där den läggs till i en lista
            return (b);
        }

        //Metod för en spel-runda
        public static void GameRound(List<Book> books)
        {
            //Skapar en ny customer
            Customer cus = new Customer();
            //For loop som skriver ut alla dina böcker som du kan sälja
            for (int i = 0; i < books.Count; i++)
            {
                //Hämtar den aktuella bokinstansens namn via metoden GetName
                string bokNamn = books[i].GetName();
                //Skriver ut bokens namn
                Console.WriteLine(i + ": " + bokNamn);


                //Hämtar köparens pengar från instansen av klassen Customer med metoden GetMoney
                int m = cus.GetMoney();
                //Kollar om köparens pengar är mer än bokens värde och köparen inte äger boken
                if(m > books[i].price && !cus.ownedBooks.Contains(books[i]))
                {

                    //Låter användaren bestämma om denne ska sälja boken eller ej.
                    //Hämtar bokens namn via GetName
                    string thisBook = books[i].GetName();
                    Console.WriteLine("The customer wants to buy " + thisBook +  " Sell? y/n");
                    string input = Console.ReadLine();
                    
                    if(input == "y")
                    {
                        //drar pengar från köparens konto
                        m = -books[i].price;
                        //Lägger till boken i köparens lista för ägda böcker
                        cus.ownedBooks.Add(books[i]);

                        Console.WriteLine("Sold book");
                    }
                    else
                    {
                        return;
                    }
                }
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProvModellering
{
    class Customer
    {
        //Namn på kunden
        string name;
        //Kundens pengar
        int money;
        //Föredragen kategori
        string preferedCategory;
        //Ägda böcker
        public List<Book> ownedBooks = new List<Book>();
        //Random generator
        Random generator = new Random();

        //Konstruktor som slumpar kundens pengar och föredragen kategori
        public Customer()
        {
            //Slumpar pengar
            money = generator.Next(1000);
        }

        //Metod som returnar kundens pengar
        public int GetMoney()
        {
            //Returnerar köparens pengar
            return (money);
        } 
    }
}

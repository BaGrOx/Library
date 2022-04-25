using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   
    internal class Books 
    {
      

        public Dictionary<string, string> baseOfBooks = new Dictionary<string, string>();

        public void AllBooks()
       {

           baseOfBooks.Add("1", "Krzyżacy");
           baseOfBooks.Add("2", "Krzyżacy");
           baseOfBooks.Add("3", "Krzyżacy");
           baseOfBooks.Add("4", "Potop");
           baseOfBooks.Add("5", "Potop");
           baseOfBooks.Add("6", "Ania z zilonego wzgórza");
           baseOfBooks.Add("7", "Pan Tadeusz");

            foreach (KeyValuePair<string, string> book in baseOfBooks)
            {
                Console.WriteLine($"ID books: {book.Key} | Title book: {book.Value}");
                
            }
       }

       public void BookIsBorrow(string idBook)
        {
            Console.ForegroundColor = ConsoleColor.Red;
           
            
        }
        
    }
}

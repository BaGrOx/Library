using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Books : Library
    {
        private int idBooks;
        
      
       public void AllBooks()
        {
            Dictionary<int, string> baseOfBooks = new Dictionary<int, string>();

           baseOfBooks.Add(1, "Krzyżacy");
           baseOfBooks.Add(2, "Krzyżacy");
           baseOfBooks.Add(3, "Krzyżacy");
           baseOfBooks.Add(4, "Potop");
           baseOfBooks.Add(5, "Potop");
           baseOfBooks.Add(6, "Ania z zilonego wzgórza");
           baseOfBooks.Add(7, "Pan Tadeusz");

            foreach (KeyValuePair<int, string> book in baseOfBooks)
            {
                Console.WriteLine($"ID books: {book.Key} | Title book: {book.Value}");
            }
        }

        public string TitleBooks { get; set; }
        public int IdBooks 
        { get { return idBooks; } 
          set
            {
                idBooks = value;
            }
        }

        
    }
}

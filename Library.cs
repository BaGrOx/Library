using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library : Program
    {
        internal Books books = new Books();

        private void PrivateDisplayPerson(Person person)
        {
            Console.WriteLine($"ID: {person.IdClient} Name: {person.Name} ");
        }
      
        public List<Person> userLibrary = new List<Person>();

        public void NewAcoount(Person user)
        {
            if (user.Password != null)
            {
                userLibrary.Add(user);
                for (int i = 1; i <= userLibrary.Count();)
                {
                    user.IdClient = i;
                    i++;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Hello {user.Name}, your ID: {user.IdClient}");
            }
           
        }

        public void DisplayAllBooks()
        {
            books.AllBooks();
        }

        public void DisplayListPerson()
        {
            foreach(Person person in userLibrary)
            {
               PrivateDisplayPerson(person);
            }
               
        }

        
        public void LogInLibrary(string id, string password)
        {
            
            
            var account = userLibrary.Find(i => i.IdClient == Convert.ToInt64(id) && i.Password == password);
            
            if(account != null) { Options(); }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Sorry ID or password is invalid");
                Console.ResetColor();

            }
        }
        
        public void BorrowBooksInLibrary(string idBook)
        {
           

            var borrowBooks = books.baseOfBooks.Where(b => b.Key == idBook);

            if(borrowBooks != null)
            {
                Console.WriteLine($"\nBooks with the title {books.baseOfBooks[idBook]} is borrow");
                books.BookIsBorrow(idBook);
            }
            else
            {
                Console.WriteLine("!!! ERROR !!!");
            }
        }

    }
}

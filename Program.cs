using System;
using System.Collections.Generic;
using System.Diagnostics; // pozwala przeprwadzić diagnoze np ile trwa funkcja StopWatch 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            LogIn();

            Console.ReadKey();
        }

        static void Menu()
        {
            Console.WriteLine("1 - Borrow a book");
            Console.WriteLine("2 - Display all books");
            Console.WriteLine("3 - Return to login");
            Console.WriteLine("x - End program");

        }

        public void Options()
        {
            var library = new Library();

           

            while (true)
            {
                Menu();
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Please choose a book from the list below");
                        library.DisplayAllBooks();
                        var idBook = Console.ReadLine();

                        library.BorrowBooksInLibrary(idBook);
                        break;
                    case "2":
                        library.DisplayAllBooks();
                        break;
                    case "3":
                        LogIn();
                        break;
                    case "4":
                        library.DisplayListPerson();
                        break;
                    case "x":
                        Environment.Exit(1);
                        break;
                    default:
                         Console.WriteLine(" ***** Invalied options *****");
                        break;
                       
                }

                
            }

            

        }

        static void LogIn()
        {
            var library = new Library();

            while (true)
            {


                Console.WriteLine("**** Welcome in Library ****");
                Console.WriteLine("1 - Login your account");
                Console.WriteLine("2 - Create new account");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Pleas insert information");
                        Console.Write("ID: ");
                        var idAccount = Console.ReadLine();
                        Console.Write("Password: ");
                        var passwordAccount = Console.ReadLine();
                        library.LogInLibrary(idAccount, passwordAccount);
                        break;
                    case "2":
                        Console.Write("Insert name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Insert passowrd. Password should consist of 4 numbers.");
                        string password = Console.ReadLine();

                        var newPersson = new Person(name, password);
                        library.NewAcoount(newPersson);
                        
                        Console.ResetColor();
                        break;
                    case "3":
                        library.DisplayListPerson();
                        break;
                  

                }
            }
            
        }
    }
}

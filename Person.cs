using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Person 
    {

        public Person(string name, string password)
        {
            Name = name;
            Password = password;
        }
      
        private string password;
        private int idClient;
        public string Name { get; set; }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length == 4)
                {
                    password = value;
                  
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalied password");
                    Console.ResetColor();
                }
            }

        }

        public int IdClient
        {
            get { return idClient; }

            set { idClient = value; }


        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
   public class Contacts
    {
        public static Dictionary<string, int> contacts;
        public Contacts() { }

        public static void CreateContact(string name, int number)
        {
            contacts.Add(name, number);
            Console.WriteLine($"New contact created: {name} {number}");
        }
       
        public static void Delete(string name)
        {
            contacts.Remove(name);
        }

        public static void showAll()
        {
            Console.WriteLine(contacts);
        }
        class Program
        {
            static void Main(string[] args)
            {
            while  (true) 
                {
                    Console.WriteLine("Choose option you require and type it's number: \n1)Add new contact\n2)Delete number\n3)Show all contacts");
                    int userChoise = Convert.ToInt32(Console.ReadLine());
                    if (userChoise == 1)
                    {
                        Console.WriteLine("Type new name");
                        string name = Console.ReadLine();

                        Console.WriteLine("Type new number ");
                        int number = Convert.ToInt32(Console.ReadLine());

                        Contacts.CreateContact(name, number);
                    }
                    else if (userChoise == 2)
                    {
                        Console.WriteLine("Type name of contact you want to delete:");
                        string name = Console.ReadLine();
                        Delete(name);
                    }
                    else if (userChoise == 3)
                    {
                        showAll();
                    }
                }
            
            
            
                
            }
        }
    }
}

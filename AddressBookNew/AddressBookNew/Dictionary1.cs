using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookNew
{
    internal class Dictionary1
    {
        static Dictionary<string, AddressBookMain> dictionary=new Dictionary<string, AddressBookMain> ();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("1.Add address book\n2.Edit address book\n3.Exit");
                Console.WriteLine("Choose any option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter address book name : ");
                        string name= Console.ReadLine();
                        if (dictionary.ContainsKey(name))
                        {
                            Console.WriteLine("Name not available");
                        }
                        else
                        {
                            dictionary.Add(name,new AddressBookMain());
                        }
                        break;
                        case 2:
                        Console.WriteLine("Enter name of address book to edit : ");
                        string name1= Console.ReadLine();
                        if (dictionary.ContainsKey(name1))
                        {
                            AddressBookMain addressBook= dictionary[name1];
                            addressBook.Menu();
                        }
                        else
                        {
                            Console.WriteLine("Address book doesn't exist");
                        }
                        break;
                    case 3:
                        condition = false;
                        break;
                }
            }
        }
    }
}

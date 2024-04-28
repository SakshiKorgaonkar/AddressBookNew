// See https://aka.ms/new-console-template for more information
namespace AddressBookNew
{
    internal class AddressBookMain
    {
        static List<Contact> contacts = new List<Contact>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            while (true)
            {
                Console.WriteLine("1.Add contact\n2.Edit contact\n3.Delete Contact\n4.Display contacts\n5.Exit");
                Console.WriteLine("Choose any option : ");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Contact contact = new Contact();
                        contact.acceptRecord();
                        contacts.Add(contact);
                        Console.WriteLine("Contact added successfully");
                        break;
                }
            }
        }
    }
}

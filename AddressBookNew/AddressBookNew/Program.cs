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
                    case 2:
                        Console.WriteLine("Enter name of contact to edit: ");
                        string name = Console.ReadLine();
                        bool contactFound = false;
                        foreach (Contact contact1 in contacts)
                        {
                            if (contact1.firstName == name)
                            {
                                contactFound = true;
                                Console.WriteLine("Enter new details for the contact:");
                                contact1.acceptRecord(); 
                                Console.WriteLine("Contact edited successfully");
                                break; 
                            }
                        }
                        if (!contactFound)
                        {
                            Console.WriteLine("Contact not found!");
                        }
                        break;
               
                }
            }
        }
    }
}

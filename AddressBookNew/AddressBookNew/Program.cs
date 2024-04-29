// See https://aka.ms/new-console-template for more information
namespace AddressBookNew
{
    internal class AddressBookMain
    {
        static List<Contact> contacts = new List<Contact>();
        public void Menu()
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("1.Add contact\n2.Edit contact\n3.Delete Contact\n4.Display contacts\n5.Exit");
                Console.WriteLine("Choose any option : ");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Contact contact = new Contact();
                        contact.acceptRecord();
                        if (contacts.Exists(c => c.firstName.Equals(contact.firstName) && c.lastName.Equals(contact.lastName))){
                            Console.WriteLine("Contact already exists");
                        }
                        else
                        {
                            contacts.Add(contact);
                            Console.WriteLine("Contact added successfully");
                        }
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
                    case 3:
                        Console.WriteLine("Enter name of contact to delete : ");
                        string name1= Console.ReadLine();
                        bool contactFound1 = false;
                        for(int i=0;i<contacts.Count; i++)
                        {
                            if (contacts[i].firstName == name1)
                            {
                                contactFound1 = true;
                                contacts.Remove(contacts[i]);
                                Console.WriteLine("Contact removed successfully");
                            }
                        }
                        if (contactFound1 == false)
                        {
                            Console.WriteLine("Contact not found!");
                        }
                        break;

                    case 4:
                        foreach (Contact contact1 in contacts)
                        {
                            contact1.printRecord();
                        }
                        break;
                    case 5:
                        condition=false;
                        break;
                }
            }
        }
    }
}

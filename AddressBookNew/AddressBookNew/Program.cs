﻿// See https://aka.ms/new-console-template for more information
namespace AddressBookNew
{
    internal class AddressBookMain
    {
        public List<Contact> contacts = new List<Contact>();
        public void Menu()
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("1.Add contact\n2.Edit contact\n3.Delete Contact\n4.Display contacts\n5.Search a person by city/state\n6.Sort person by name\n7.Exit");
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
                            Console.WriteLine(contact1.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter city/state");
                        string name2= Console.ReadLine();
                        var filteredContacts = contacts.Where(c => c.city.Equals(name2) || c.state.Equals(name2));
                        Console.WriteLine($"The number of contacts with city/state {name2} is : {filteredContacts.Count()}");
                        if (filteredContacts.Any())
                        {
                            foreach(var item in filteredContacts)
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contacts found in the specified city/state.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Sort contacts on the basis of : ");
                        string name3= Console.ReadLine();
                        if (name3 == "city")
                        {
                            contacts.Sort((c, c1) => c.city.CompareTo(c1.city));
                        }
                        if (name3 == "state")
                        {
                            contacts.Sort((c, c1) => c.state.CompareTo(c1.state));
                        }
                        if (name3 == "zip")
                        {
                            contacts.Sort((c, c1) => c.zip.CompareTo(c1.zip));
                        }
                        else
                        {
                            contacts.Sort((c, c1) => c.firstName.CompareTo(c1.firstName));
                        }
                        foreach (Contact contact1 in contacts)
                        {
                            Console.WriteLine(contact1.ToString());
                        }
                        break;
                    case 7:
                        condition=false;
                        break;
                }
            }
        }
    }
}

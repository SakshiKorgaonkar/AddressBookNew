using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace AddressBookNew
{
    internal class Contact 
    {
        public string? firstName;
        public string? lastName;
        public string? email;
        public int? phone;
        public string? address;
        public string? city;
        public string? state;
        public string? zip;

        public void acceptRecord()
        {
            Console.WriteLine("Enter First Name : ");
            firstName=Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            lastName=Console.ReadLine();
            Console.WriteLine("Enter email : ");
            email=Console.ReadLine();
            Console.WriteLine("Enter address : ");
            address=Console.ReadLine();
            Console.WriteLine("Enter city : ");
            city=Console.ReadLine();
            Console.WriteLine("Enter state : ");
            state=Console.ReadLine();
            Console.WriteLine("Enter zip : ");
            zip=Console.ReadLine();
            Console.WriteLine("Enter phone number : ");
            phone = Convert.ToInt32(Console.ReadLine());
        }
        public void printRecord()
        {
            Console.WriteLine($"First Name : {firstName}");
            Console.WriteLine($"Last Name : {lastName}");
            Console.WriteLine($"Email : {email}");
            Console.WriteLine($"Address : {address}");
            Console.WriteLine($"City : {city}");
            Console.WriteLine($"State : {state}");
            Console.WriteLine($"ZIP code : {zip}");
            Console.WriteLine($"Phone number : {phone}");
        }
        public override String ToString()
        {
            return "Name: " + firstName + " " + lastName +
                    ", Address: " + address +
                    ", City: " + city +
                    ", State: " + state +
                    ", Zip: " + zip +
                    ", Phone Number: " + phone +
                    ", Email: " + email;
        }
        
    }
    internal class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Map(m => m.firstName).Name("firstName");
            Map(m => m.lastName).Name("lastName");
            Map(m => m.email).Name("email");
            Map(m => m.phone).Name("phone");
            Map(m => m.address).Name("address");
            Map(m => m.city).Name("city");
            Map(m => m.state).Name("state");
            Map(m => m.zip).Name("zip");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookNew
{
    internal class Contact : IComparable<Contact>
    {
        internal string? firstName;
        internal string? lastName;
        internal string? email;
        internal int? phone;
        internal string? address;
        internal string? city;
        internal string? state;
        internal int? zip;

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
            zip=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phone number : ");
            phone = Convert.ToInt32(Console.ReadLine());
        }
        public int CompareTo(Contact? other)
        {
            if (other == null)
            {
                return 1;
            }
            string choice = Console.ReadLine();
            if (choice == "city")
            {  
                return this.city.CompareTo(other.city);
            }
            if (choice == "state")
            {
                return this.state.CompareTo(other.state);
            }
            if (choice == "zip")
            {
                if (this.zip > other.zip)
                {
                    return 1;
                }
                if(this.zip< other.zip)
                {
                    return -1;
                }
                return 0;
            }
            return string.Compare(this.firstName,other.firstName, StringComparison.OrdinalIgnoreCase);
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
}

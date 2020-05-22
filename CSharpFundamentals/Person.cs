using System;
namespace CSharpFundamentals
{


    public class Person : IPerson
    {
        

        public Person()
        {
        }

        public Person(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            SurName = lastName;
            PhoneNumber = phone;
        }

        public void GetPerson()
        {
            Console.WriteLine($"first name: {this.FirstName} lastName: {this.SurName} phone number: {this.PhoneNumber}");
        }

        public string FirstName {
            get { return this.FirstName; }
            private set { if (!String.IsNullOrWhiteSpace(value)){ FirstName = value; } }
        }
        public string SurName {get; set;}
        public string PhoneNumber {get; set;}
    }
}

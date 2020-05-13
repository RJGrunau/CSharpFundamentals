using System;
namespace CSharpFundamentals
{

    
    public class Person : IPerson
    {
        public string fName;
        public string lName;
        public string phoneNumber;

        public Person()
        {
        }

        public Person( string firstName, string lastName, string phone)
        {
            fName = firstName;
            lName = lastName;
            phoneNumber = phone;
        }

        public void GetPerson (Person person)
        {
            Console.WriteLine($"first name: {person.fName} lastName: {person.lName} phone number: {person.phoneNumber}");
        }
    }
}

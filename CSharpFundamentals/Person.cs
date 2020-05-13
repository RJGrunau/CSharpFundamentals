using System;
namespace CSharpFundamentals
{

    
    public class Person 
    {
        string fName;
        string lName;
        string phoneNumber;

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

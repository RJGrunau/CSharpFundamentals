using System;
namespace CSharpFundamentals
{

    
    public class Person
    {
        string fName;
        string lName;
        string phoneNumber;

        public Person()
        {
            fName = ""; 
            lName = "";
            phoneNumber = "";
        }

        public void GetPerson (string firstName, string lastName, string phone)
        {
            fName = firstName;
            lName = lastName;
            phoneNumber = phone;

            Console.WriteLine($"first name: {fName} lastName: {lName} phone number: {phoneNumber}");
        }
    }
}

using System;
namespace CSharpFundamentals
{


    public abstract class Person : IPerson
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

        public virtual void GetDetails()
        {
            Console.WriteLine($"first name: {this.FirstName} lastName: {this.SurName} phone number: {this.PhoneNumber}");
        }

        public GetTimeOfDayGreeting()
        {

        }

        public string FirstName { get; set; }
        //public string FirstName {
        //    get { return this.FirstName; }
        //    private set { if (!String.IsNullOrWhiteSpace(value)){ FirstName = value; } }
        //}
        public string SurName {get; set;}
        //public string SurName
        //{
        //    get { return this.SurName; }
        //    set { if (!String.IsNullOrWhiteSpace(value)) { SurName = value; } }
        //}
        public string PhoneNumber {get; set;}
    }
}

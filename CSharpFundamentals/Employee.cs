using System;
namespace CSharpFundamentals
{
    public class Employee : Person, IPerson
    {

        public int EmplyeeId;
        
        public Employee() : base()
        {
            
        }

        public Employee(string fname, string lname, string phone) : base(fname, lname, phone) { }

        public void GetWelcomMessge(Person person)
        {
            DateTime timeOfDay = DateTime.Now;
            Console.WriteLine($"Hello, {person.fName} {person.lName} the time is {timeOfDay}");
        }
    }
}

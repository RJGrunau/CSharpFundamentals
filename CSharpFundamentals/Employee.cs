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
            TimeSpan amStart = new TimeSpan(00, 0, 0);
            TimeSpan amEnd = new TimeSpan(11, 59, 59);
            TimeSpan afterNoonEnd = new TimeSpan(17, 0, 0);
            TimeSpan nightStart = new TimeSpan(19, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now >= amStart && now <= amEnd)
            {
                Console.WriteLine($"Good morning, {person.fName} {person.lName}");
            }else if(now > amEnd && now < afterNoonEnd)
            {
                Console.WriteLine($"Good afternoon, {person.fName} {person.lName}");
            }else if(now > afterNoonEnd && now <= nightStart)
            {
                Console.WriteLine($"Good evening, {person.fName} {person.lName}");
            }
            else
            {
                Console.WriteLine($"Good night, {person.fName} {person.lName}");
            }
        }
    }
}

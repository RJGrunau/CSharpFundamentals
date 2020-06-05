using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp = new Employee("John", "Smith", "222-333-3333");
            String welcomeMessage = emp.GetTimeOfDayGreeting();
            string employeeDetails = emp.GetDetails("Mike", "Bannon", "222-333-4444");
            Console.WriteLine(welcomeMessage);
            Console.WriteLine(employeeDetails);
        }
    }
}

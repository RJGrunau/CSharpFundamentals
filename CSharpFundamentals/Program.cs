using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp = new Employee("John", "Smith", "222-333-3333");
            String welcomeMessage = emp.GetWelcomeMessge();
            Console.WriteLine(welcomeMessage);
        }
    }
}

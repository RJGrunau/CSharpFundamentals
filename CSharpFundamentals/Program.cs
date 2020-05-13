using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person np = new Person("Bob", "Grunau", "111-222-3333");
            np.GetPerson(np);
        }
    }
}

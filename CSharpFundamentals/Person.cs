using System;
using Newtonsoft.Json.Linq;
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

        public virtual string GetDetails()
        {
            JArray personalDetails = new JArray();
            JValue firstName = new JValue(this.FirstName);
            JValue surName = new JValue(this.SurName);
            JValue phone =  new JValue(this.PhoneNumber);

            personalDetails.Add(firstName);
            personalDetails.Add(surName);
            personalDetails.Add(phone);

            string result = personalDetails.ToString();

            return result;
        }

        public abstract String GetTimeOfDayGreeting();
        

        public abstract string FirstName { get; set; }
        //public string FirstName {
        //    get { return this.FirstName; }
        //    private set { if (!String.IsNullOrWhiteSpace(value)){ FirstName = value; } }
        //}
        public abstract string SurName {get; set;}
        //public string SurName
        //{
        //    get { return this.SurName; }
        //    set { if (!String.IsNullOrWhiteSpace(value)) { SurName = value; } }
        //}
        public virtual string PhoneNumber {get; set;}
    }
}

﻿using System;
namespace CSharpFundamentals
{
    public class Employee : Person, IPerson
    {

        public int EmployeeId { get; set; }
        
        public Employee() : base()
        {
            
        }

        public Employee(string fname, string lname, string phone) : base(fname, lname, phone) { }
        
        public  String GetWelcomeMessge()
        {
            TimeSpan amStart = new TimeSpan(00, 0, 0);
            TimeSpan amEnd = new TimeSpan(11, 59, 59);
            TimeSpan afterNoonEnd = new TimeSpan(17, 0, 0);
            TimeSpan nightStart = new TimeSpan(19, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;
            String salutation;
            String message;
            if (now >= amStart && now <= amEnd)
            {
                salutation = "Good morning";
                message = $"{salutation} {this.FirstName} {this.SurName}";
                return message;
            }else if(now > amEnd && now < afterNoonEnd)
            {
                salutation = "Good afternoon";
                message = $"{salutation}, {this.FirstName} {this.SurName}";
                return message;
            }else if(now > afterNoonEnd && now <= nightStart)
            {
                salutation = "Good evening";
                message = $"{salutation}, {this.FirstName} {this.SurName}";
                return message;
            }
            else
            {
                salutation = "Good night";
                message = $"{salutation}, {this.FirstName} {this.SurName}";
                return message;
            }
        }
    }
}

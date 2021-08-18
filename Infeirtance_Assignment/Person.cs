using System;
using System.Collections.Generic;
using System.Text;

namespace Inheirtance_Assignment
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName() 
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}

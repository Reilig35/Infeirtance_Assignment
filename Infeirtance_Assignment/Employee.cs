using System;
using System.Collections.Generic;
using System.Text;

namespace Inheirtance_Assignment
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine($"\n\n\nI.D: {Id}\nName: {FirstName} {LastName}");
        }
    }
}

        

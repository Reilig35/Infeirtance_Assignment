using System;

namespace Inheirtance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Sample";
            person.LastName = "Student";

            person.SayName();


            Employee william = new Employee();
            william.FirstName = "William";
            william.LastName = "Twomey";
            william.Id = 546729;

            william.SayName();
        }
        
           
            
        
    }
}

            
            


            


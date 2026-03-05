using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_stu
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base(message) { }
    }

     public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message) { }
    }

    public class person
    {
        public int id {  get; set; }
        public string name { get; set; }
        public DateTime Dob {  get; set; }
        public string email { get; set; }
        public person(int id,string name,DateTime dob , string email)
        {
            if(name == null) 
                throw new ArgumentNullException("name");
            if(!email.Contains("@"))
                throw new ArgumentException("email must contain @");
         
            id = id;
            name = name;
            Dob = Dob;
            email = email;

        }
        public virtual void displayInfo()
        {
            Console.WriteLine($"id: {id} name: {name} dob: {Dob} email: {email}");
        }



    }
}

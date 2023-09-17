using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__.NET
{
    public class Person
    {
        // Events / Delegates 

        //Field Variables
        // public string Name;
        private byte age;

        // Properties
        public string Name { get; set; }
        
        public byte Age 
        { 
            get { return age; } 
            set {
                if (value > 1 && value < 105){
                    age = value;
                } else {
                    throw new Exception("Invalid Age!");
                }
            } 
        }


        // Methods
        public void SayHello()
        {
            Console.WriteLine($"Hi, I'm {Name} and {age} years old!");
        }
    }


}

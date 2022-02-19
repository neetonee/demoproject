using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    class Program
    {
        public void Show() // No Parameter  
        {
            Console.WriteLine("This is non parameterized function");
            // No return statement  
        }


        public string Returnmsg(string message)
        {
            Console.WriteLine("Inside Show Function");
            return message;
            // accepting parmeter  and return type 
        }


        // User defined function without return type  
        public void Showmsg(string message)
        {
            Console.WriteLine("Hello " + message);
            // No return statement  
        }
        public void byref(ref int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
        public void byvalue(int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
        public void byoutput(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating value  
        }
        static void Main(string[] args)
        {


            Program program = new Program(); // Creating Object  
            program.Show();
            program.Returnmsg("hello");
            program.Showmsg("hello");
            int val = 50;
            Console.WriteLine("Value before calling the function " + val);
            program.byvalue(val); // Calling Function by passing value            
            Console.WriteLine("Value after calling the function call be value " + val);
            program.byref(ref val); // Calling Function by passing ref changes the value in function            
            Console.WriteLine("Value after calling the function call by reference" + val);
            program.byoutput(out val); // Calling Function by passing out manipulayes the value
            // It is like reference-type, except that it does not require variable to initialize before passing
            Console.WriteLine("Value after recieving the out variable " + val);
        }

    }
}

using System; // basic utility classes and primitive types 
using System.Collections.Generic; // works with list, collections and etc.
using System.Linq; // is used to woek with data
using System.Text; // works with text and encoding 
using System.Threading.Tasks; // used to build multithreading applications 

// When we want to use classes from different namespaces we need to import them into our file 
// this is where the using statement comes into play 

// is a namespace in .Net frame work

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) 
        {
            // this function or method is the entry point to the application. when we run the app CLR executes the code inside of this main method
            // this method is delcared as static 
            //  methods have inputs and outputs 
            // the return/output type is before the method name 
            // void means nothing. this method will not return anything it just contains code 

            Console.WriteLine("hello world");
        }
    }
}
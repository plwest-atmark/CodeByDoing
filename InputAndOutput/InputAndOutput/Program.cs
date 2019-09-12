using System;

namespace InputAndOutput
{
    class Program
    {

        /// <summary>
        /// The Main Method is the entry point for ALL application in .NET
        /// We will see this being used even with Web Applications.  It is here that a web application
        ///     creates a HOST for the web site and runs the host that is created. This will be explained
        ///     more when we finish with basic Console application and create a web application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //  The Console 
            //  Represents the standard input, output, and error streams for console applications. 
            //  This class cannot be inherited.
            Console.WriteLine("Hello World!");

            //  There are several things that can be done with the Console
            //      Write(string);  -- Sends output string to the console application for display 
            //          DOES NOT CREATE A NEW LINE
            //
            //      WriteLine(string);  -- Sends an output string to the console application for display
            //          DOES CREATE A NEW LINE
            //      
            //      Read();  -- Reads the next "char" input from the console application.
            //          This can be stored in a variable like this:
            //          var myVariable = Console.Read();
            //          We usually ensure that the input is going to be correct by "validation"
            //          var myVariable = Convert.Int32(Console.Read());  -- Ensures the input is an integer.
            //          When the wrong type on information is read with Console.Read() an error will occur.
            //
            //      ReadLine();  -- Reads the next "line" of input from the console application.  The "return"
            //                      or "Enter" key is used to end the "line"
            //          This can be stored in a variable like this:
            //          var myVariable = Console.ReadLine();
            //          We usually do NOT validate unless we want a specific type to be input, like an integer.
            //          Validation will occur later in the code after the line has been input by the user.


            var myVariable = "This is my variable"; // Creates a "string" variable.
            var myOtherVariable = 24; // Creates an "int" variable.

            string myStringVariable; // Creates a string variable. It does not have a value, and is said to be null. This can create errors.
            string myEmptyStringVariable = String.Empty;  // Creates a string variables and "initializes" it to an Empty string. 
                                                          //  (it has no value, but does not create errors)

            int myIntVariable; // Creates an int variable.  The default value for an int variable is 0.


            


        }
    }
}

using System;
using MethodsFile;
using FundamentalsSpace;
using OOP;

namespace MyApplication;

    class Program
    {
        static void Main(string[] args)
        {
           // ##########################################################################################
           // Fundametals
            // FundamentalsClas.fundamentals();
            
            
           // #####################################################
           // Object-Oriented Programming (OOP)
           // C# follows the Object-Oriented Programming paradigm, which organizes programs using classes and objects. OOP concepts help developers create modular, reusable,
           // and maintainable applications.

           // Creating object
              Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
              Console.WriteLine(tuffy.ToString());
        }
    }

using System;
using MethodsFile;

namespace MyApplication;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Topic #2 Input OutPuts
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            
            // The only difference is that it does not insert a new line at the end of the output:
            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");
            
            // Identifirs  
            // In C#, identifiers are the user-defined names given to program elements such as variables, methods, classes, and labels. They are used to identify these elements in a program.
            // Types of Identifiers
            // Identifiers in C# can represent different program elements:
            //
            // Class Identifiers: Names of classes (e.g., GFG)
            // Method Identifiers: Names of methods (e.g., Main)
            // Variable Identifiers: Names of variables (e.g., x)
            // Object Identifiers: Names of objects created from classe
            
            int a = 10;
            int b = 39;
            int c;

            c = a + b;
            // Display Variables
            Console.WriteLine("The sum of two numbers is: {0}", c);
            Console.WriteLine("The value of a is "  + a);
            
            // Declare Many Variables
            int x = 5, y = 6, z = 50;
            string var1 = "12";
            Console.WriteLine(x + y + var1);
            
            // Input variables vlaues
            Console.Write("Enter a number: ");
            // int num = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Value of num is " + num);
            
            // C# Data Types
            //     │
            //     ├── Value Types
            //     │   ├── Predefined
            //     │   │   ├── int
            //     │   │   ├── bool
            //     │   │   ├── float
            //     │   │   └── char
            //     │   │
            //     │   └── User-Defined
            //     │       ├── enum
            // │       └── struct
            // │
            // ├── Reference Types
            //     │   ├── Predefined
            //     │   │   ├── object
            //     │   │   └── string
            //     │   │
            //     │   └── User-Defined
            //     │       ├── class
            // │       └── interface
            // │
            // └── Pointer Types
            //     └── int*, char*, etc.
            
            int integerDT = 10;
            float floatDT = 3.5f;
            char c2 = 'A';
            bool b2 = true;
            
            // Reference Data Types
            string stringVar = "Hello World!";
            // An int value
            int number = 100;

            // Boxing: int is converted to object
            object obj = number;

            Console.WriteLine(obj);

            // Check the actual type stored inside the object
            Console.WriteLine(obj.GetType());

            // Unboxing: object is converted back to int
            int result = (int)obj;

            Console.WriteLine(result);
            
            int[] arr= {1,2,3,4,5};
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            
            // // Pointer Data Type
            // unsafe {
            //     int n = 10;
            //     int* p = &n;
            //     Console.WriteLine(n);
            // }
            
            // Type Casting in C#
            // Type casting means converting a variable of one data type into another, ensuring compatibility when assigning data between different types
            // Type Casting can be divided into two parts:
            //
            // Implicit Type Conversion (Type Safe)
            // Explicit Type Conversion (Manual Conversion)
            int num = 10;

            // int is converted to double (implicit type casting)
            double d = num;

            Console.WriteLine(d);
            
            // Invalid Implicit Conversion
            int x11 = 10;
            double d11 = 9.5;
            
            // x11 = d11; Error
            x11 = (int)d11; // Correct
            
            int i11 = 12;
            double d1 = 765.12;
            float f1 = 56.123F;

            // Using Built- In Type Conversion Methods & Displaying Result
            Console.WriteLine(Convert.ToString(f1));
            Console.WriteLine(Convert.ToInt32(d));
            Console.WriteLine(Convert.ToUInt32(f1));
            Console.WriteLine(Convert.ToDouble(i11));
            
            
            // Types of Operators
            //     C# has some set of operators that can be classified into various categories based on their functionality. Categorized into the following types:
            //
            // Arithmetic Operators
            // Relational Operators
            // Logical Operators
            // Assignment Operators
            // Increment and Decrement Operators
            // Bitwise Operators
            // Ternary Operator
            // Null Coalescing Operator
            
            // C# Decision Making 
            // Using if statement
            string name = "Geek";
            if (name == "Geek") {
                Console.WriteLine("GeeksForGeeks");
            }
            
            // Using if-else statement
            if (name == "Geeks") {
                Console.WriteLine("GeeksForGeeks");
            }
            else {
                Console.WriteLine("Geeks");
            }
            
            int i = 20;

            // Using If-else-if ladder
            if (i == 10)
                Console.WriteLine("i is 10");
            else if (i == 15)
                Console.WriteLine("i is 15");
            else if (i == 20)
                Console.WriteLine("i is 20");
            else
                Console.WriteLine("i is not present");
         // Switch Statement
         int number1 = 30;
         
         switch(number1)
         {
             case 10: 
                 Console.WriteLine("case 10");
                 break;
             case 20: 
                 Console.WriteLine("case 20");
                 break;
             case 30: 
                 Console.WriteLine("case 30");
                 break;
             default: 
                 Console.WriteLine("None matches"); 
                 break;
         }
         
         // Using Nested Switch Case
         int outter = 2;
         int inner = 3;
         switch(outter){
             case 1:
                 Console.WriteLine("Outter Case 1");
                 break;
             case 2:
                 Console.WriteLine("Outter Case 2");
                 switch(inner)
                 {
                     case 1:
                         Console.WriteLine("Inner Case 1");
                         break;
                     case 2:
                         Console.WriteLine("Inner Case 2");
                         break;
                     case 3:
                         Console.WriteLine("Inner Case 3");
                         break;
                     default:
                         Console.WriteLine("Default Inner Run");
                         break;
                 }
                 break;
             default:
                 Console.WriteLine("Default Outter Run");
                 break;
         }
         
         // Loops in C#
         // Types of Loops in C#
         // Loops are mainly divided into two categories:
         // Entry Controlled Loops
         // Exit Controlled Loop
         // The loops in which the condition to be checked before entering the loop body are known as Entry Controlled Loops.
         //
         //     Example: while, for
         int loopvar = 1;
 
         // Exit when x becomes greater than 4
         while (loopvar <= 4)
         {
             Console.WriteLine("GeeksforGeeks");
 
             // Increment the value of x for next iteration
             loopvar++;
         }
         
         // for loop begins when x=1 and runs till x <= 4
         for (int forLoop = 1; forLoop <= 4; forLoop++)
             Console.WriteLine("GeeksforGeeks");
         
         
        // Exit Controlled Loops
        //     The loops in which the condition is checked after the loop body is known as Exit Controlled Loops.
         
        
        // GeeksforGeeks is printed only 1 times
        for (int i1 = 1; i1 < 3; i1++)
        {
            if (i == 2)
                continue;
            
            Console.WriteLine("GeeksforGeeks"); 
        }
        
        // C# Jump Statements (Break, Continue, Goto, Return and Throw)
         
        
        // ###########################################################################################
         // Methods
         MethodsClass.Add(2,5);

        }
    }

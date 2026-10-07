namespace OOP;

class PropertiesClass
{
    // Properties in C#
    // A property in C# is a member of a class that provides a flexible way to read, write or compute the value of a private field.
    // It acts like a combination of a variable and a method.

    // A property in C# is a member of a class that provides a flexible way to read, write or compute the value of a private field. It acts like a combination of a variable and a method.

    // Declared inside a class using { get; set; }.
    // get: returns the value of the field.
    // set: assigns a value to the field.
    // Can be read only (get only) or write only (set only).
    // Improves encapsulation by controlling access to fields.

    // Accessors
    //     The block of "set" and "get" is known as Accessors. They can be used to restrict or control accessibility based on design requirements. There are two types of accessors: get accessors and set accessors.
    //
    //     Example: Problem Without Properties

    public class C1
    {

        // Public data members (No restrictions)
        public int rn;
        public string name;

        // Private field (Cannot be accessed directly)
        private int marks = 35;
    }
    
    public class Geeks23
    {
        // Private field
        private int r = 357;

        // Read-only property
        public int Roll_no
        {
            get { return r; }
        }
        private int r1;

        // Read-Write Property
        public int RollNo1
        {
            get { return r1; }
            set { r1 = value; }
        }
        public static void Main1(string[] args)
        {
            // Creating an object of class C1
            C1 obj = new C1();

            // Setting values to public data members
            obj.rn = 10000;
            obj.name = null;

            // Directly modifying private field is not possible
            // obj.marks = 0; // Error

            Console.WriteLine("Name: {0} \nRoll No: {1}", obj.name, obj.rn);
        }
        
        public class Student{
            // Auto-implemented property
            public string Name { get; set; } = "GFG";
        }
    }

}



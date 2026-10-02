namespace MethodsFile
{
    class MethodsClass
        
    {
        // Methods in C#
       public static int Add(int a, int b){
            return a + b;
        }
        // Method Parameters
        // value parameter
        static void Display(int x) {
            Console.WriteLine("Value Parameter: " + x);
        }

        // reference parameter
        static void Update(ref int y) {
            // Modify the original variable
            y += 5; 
            Console.WriteLine("Reference Parameter: " + y);
        }

        // output parameter
        static void GetValues(out int z) {
            // Assign value to output parameter
            z = 20;
            Console.WriteLine("Output Parameter: " + z);
        }
        static void Show(in int x)
        {
            Console.WriteLine(x);
        }
        
        //Default (Optional) Parameters
        static void Print(string name = "Guest")
        {
            Console.WriteLine(name);
        }
        // Named Parameters
        static void AddStrings(string first, string middle, string last)
        {
            Console.WriteLine(first + middle + last);
        }
        
        // Params Parameters
        static int Multiply(params int[] numbers)
        {
            int result = 1;
            foreach (int n in numbers)
                result *= n;
            return result;
        }
        
        // Return Types in C#
        static int Add1(int a, int b){
            // Return the sum and terminate the method
            return a + b;
        }
        
        // Types of Return Types in C#
        static void Print(){
            Console.WriteLine("Welcome to GeeksforGeeks");
        }
        
        // Method Overloading in C#
        
        // Method Overloading in C# is the ability to define multiple methods with the same name but different parameter lists.
        //
        //     Parameter lists can differ by type, number or order of parameters.
        //     Improves readability and lets related tasks use the same method name.
        //     Cannot overload methods by only changing the return type (causes compile-time error).
        // Also known as compile-time (static) polymorphism.
        //     Different Ways of Method Overloading
        //     Method overloading can be done by changing:
        //
        // Changing the number of Parameters
        //     Changing data types of the parameters.
        //     Changing the Order of the parameters.
        
        // adding two integer values.
        public int Add2(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public int Add2(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        
        // adding three integer values.
        public static int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        // adding three double values
        public static double Add(double a, double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }
        
        public void Identity(String name, int id)
        {
            Console.WriteLine("Name1 : " + name + ", " + "Id1 : " + id);
        }
    
        public void Identity(int id, String name)
        {
            Console.WriteLine("Name2 : " + name + ", " + "Id2 : " + id);
        }
        
        
        
    }
}
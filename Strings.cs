using System.Text;
namespace  StringsSpace
{

class MyClaaass
{
    static void stringsMethod()
    {
        // declare a string Name using "System.String" class
        System.String Name;
        
        // initialization of String
        Name = "Geek";

        String id;
        
        // initialization of String
        id = "33";

        // declare a string mrk using  string keyword
        string mrk;
        
        // initialization of String
        mrk = "97";
        
        // Declaration and initialization of the string in a single line
        string rank = "1";

        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Id: {0}", id);
        Console.WriteLine("Marks: {0}", mrk);
        Console.WriteLine("Rank: {0}", rank);
        
        
        
        // C# String Operations
        
        string name = "GeeksforGeeks";
        
        // Interpolation is performed
        string res = $"{name} is the Organisation Name.";
        
        // Printing the String
        Console.WriteLine(res);
        Console.WriteLine("Length: " + res.Length);
        string first = " GeEks ";
        string second = " forGeeks ";
        
        // trim the String
        first=first.Trim();
        second=second.Trim();
        
        // Checking element at index 2 first
        Console.WriteLine("Element at index 2: " + first[2]);
        
        // replacing the element in String
        first=first.Replace("E","e");
        Console.WriteLine(first+second);
        
        // C# StringBuilder
        StringBuilder s = new StringBuilder("GeeksForGeeks");
    }
}
}


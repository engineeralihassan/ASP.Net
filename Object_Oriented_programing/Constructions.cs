namespace OOP;

public class ConstructorsClass
{
    // Default Constructor
    // Fields without manual initialization
    int num;        // default: 0
    string name;    // default: null
    bool flag;      // default: false

    // Default constructor
    public ConstructorsClass() {
        Console.WriteLine("Constructor Called");
    }
    
    // Parameterized Constructor
    public ConstructorsClass(int num, string name, bool flag) {
        this.num = num;
        this.name = name;
    }

    // Geek o = new Geek("GFG", 1);
    // Console.WriteLine("Name = " + o.n + " Id = " + o.i);
    
    
    
} 
// COpy COnstructor
class Customer
{
    public string Name;
    public string Email;
    public string City;

    public Customer(string name, string email, string city)
    {
        Name = name;
        Email = email;
        City = city;
    }

    // Copy constructor
    public Customer(Customer other)
    {
        Name = other.Name;
        Email = other.Email;
        City = other.City;
    }
}

// Private Constructor
// If a constructor is created with a private specifier is known as Private Constructor. It is not possible for other classes to derive from this class and also it’s not possible to create an instance of this class. Some important points regarding the topic is mentioned below:
//
// A private constructor is often used in implementing the Singleton design pattern, but it does not implement the pattern by itself.
//     Use a private constructor when we have only static members.
//     Using a private constructor prevents the creation of the instances of that class.
// Note: Access modifiers can be used in constructor declaration to control its access i.e. which other class can call the constructor. Private Constructor is one of it's example.

public class Geeks 
{
    // private Constructor
    private Geeks()
    {
        Console.WriteLine("from private constructor");
    }

    public static int count_geeks;

    public static int geeks_Count()
    {
        return ++count_geeks;
    }


}
// Static Constructor
// Static Constructor has to be invoked only once in the class and it has been invoked during the creation of the first reference to a
// static member in the class. A static constructor is used to initialize static fields or data of a class and is executed only onc


class Geeks1 
{
    // It is invoked before the first instance constructor is run.
    static Geeks1()
    {
        Console.WriteLine("Static Constructor");
    }

    public Geeks1(int i)
    {
        Console.WriteLine("Instance Constructor " + i);
    }

    public string geeks_detail(string name, int id)
    {
        return "Name: " + name + " id: " + id;
    }

    public static void sdddddd()
    {
        // Here Both Static and instance constructors are invoked for first instance
        Geeks1 obj = new Geeks1(1);

        Console.WriteLine(obj.geeks_detail("GFG", 1));

        Geeks1 obj1 = new Geeks1(2);

        Console.WriteLine(
            obj1.geeks_detail("GeeksforGeeks", 2));
    }
}
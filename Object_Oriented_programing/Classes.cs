// Declaration of Class
//     A class declaration begins with the class keyword followed by the class name. However, some optional attributes can be used with class declaration according to the application requirement. Class declarations can include these components, in order:
//
// Modifiers: Define the accessibility of a class. By default, a class is internal.
// Keyword class: Used to declare a class.
// Class Identifier: The name of the class, conventionally starting with a capital letter.
//     Base Class (Optional): Specifies a parent class to inherit from, using the : symbol.
//     Interfaces (Optional): A comma-separated list of interfaces implemented by the class, also preceded by : A class can implement multiple interfaces.
//     Body: Enclosed within { }, containing members like fields, properties, methods, constructors and events.

namespace OOP;

public class OopClass1
{
    // field variables
    public int a, b;

    // member function or method
    public void Display(){
        Console.WriteLine("Class in C#");
    }
}

public class Dog
{

    // Instance Variables
    String name;
    String breed;
    int age;
    String color;

    // Constructor Declaration of Class same name as class
    public Dog(String name, String breed, int age, String color)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
        this.color = color;
    }

    public String GetName()
    {
        return name;
    }

    public String GetBreed()
    {
        return breed;
    }

    public int GetAge()
    {
        return age;
    }

    public String GetColor()
    {
        return color;
    }

    public override String ToString()
    {
        return "my name is: " + name +
               "\nmy breed is: " + breed +
               "\nmy age is: " + age;
    }
    
    
}


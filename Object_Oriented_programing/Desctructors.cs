namespace OOP;

public class Desctructors
{
    // A destructor in C# is a special method that is automatically called when an object is destroyed or removed from memory. It is used to
    // release unmanaged resources like file handles, database connections or network streams before the object is reclaimed by the garbage
    // collector
    
    // Constructor
    public Desctructors() 
    {
        Console.WriteLine("Object Created.");
    }

    // Destructor
    ~Desctructors() 
    {
        Console.WriteLine("Object Destroyed.");
    }

    public void DisplayMessage() 
    {
        Console.WriteLine("Message Printed.");
    }

    public static void main(string[] args)
    {
        // Create an instance of Geeks
        Desctructors g = new Desctructors();
      
        // Destructor will be called when g goes out of scope
        g.DisplayMessage();
    }
    
}
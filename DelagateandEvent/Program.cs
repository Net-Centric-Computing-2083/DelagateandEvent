//Delegate
delegate void Notification(string message);

//Event
class Publisher
{
    public event Notification MessageSent;
    public void Sent(string message)
    {
        MessageSent?.Invoke(message);
    }
}

//Generic delegate
public class Box<T>
{
    public T Value { get; set; }    
    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

class MyClass
{
    public static void Main()
    {
        Console.WriteLine("~~~Delegate and Event~~~");
        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiveMessage;
        publisher.Sent("Hello, World!");

        Console.WriteLine("\n~~~Generic Delegate~~~");
        Console.WriteLine("\n~~~List of int~~~");
        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Console.WriteLine("\n~~~List of string~~~");
        Box<string> stringBox = new Box<string> { Value = "Hello, Generic Delegate!" };
        stringBox.Display();

        Console.WriteLine("\n~~~List of Generic~~~");
        List<string> students = new List<string>();
        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");

        foreach (var student in students)
        {
            Console.WriteLine($"Student:{students}");
        }
    }
    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber message: {message}");
    }

    //Generic delegate usage
    
}


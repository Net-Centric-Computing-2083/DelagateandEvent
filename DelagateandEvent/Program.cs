//delegate
using System.Collections;
using System.Net.Sockets;

delegate void Notificarion(string message);

//Event
class Publisher
{
    public event Notificarion? MessageSent;

    public void send(string message)
    {
        MessageSent?.Invoke(message);
    }
}

//Generic
public class Box<T>
{
    public T Value { get; set; }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Delegate and Event=====");

        Publisher publisher = new Publisher();
        publisher.MessageSent += ReceiveMessage;
        publisher.send("Hello, World!");

        Console.WriteLine("=====Generic=====");
        Console.WriteLine("=====List of int=====");

        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Console.WriteLine("=====List of string=====");

        Box<string> stringBox = new Box<string> { Value = "Hello, World!" };
        stringBox.Display();

        //List

        Console.WriteLine("=====List of Generic=====");
        List<string> students = new List<string>();
        students.Add("Alice");
        students.Add("Amrita");
        students.Add("Susma");

        foreach (var student in students)
        {
            Console.WriteLine($"student:{student}");
        }

        // ArrayList
        Console.WriteLine("\n=====ArrayList Collection=====");
        ArrayList items = new ArrayList();

        items.Add(100);
        items.Add("Apple");
        items.Add(50.5);

        foreach (var item in items)
        {
            Console.WriteLine($"Item: {item}");
        }

        // Dictionary
        Console.WriteLine("\n=====Dictionary Collection=====");
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        dictionary.Add(1, "Alice");
        dictionary.Add(2, "Amrita");
        dictionary.Add(3, "Susma");

        foreach (var item in dictionary)
        {
            Console.WriteLine($"Key: {item.Key}  Value: {item.Value}");
        }



        // Stack
        Console.WriteLine("\n=====Stack Collection=====");
        Stack<string> stack = new Stack<string>();

        stack.Push("Book");
        stack.Push("Pen");
        stack.Push("Copy");

        foreach (var item in stack)
        {
            Console.WriteLine($"Item: {item}");
        }

        Console.WriteLine($"Top Item: {stack.Peek()}");

        stack.Pop();

        Console.WriteLine("After Pop:");
        foreach (var item in stack)
        {
            Console.WriteLine($"Item: {item}");
        }
    }
        
    

    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Received message: {message}");
    }
}

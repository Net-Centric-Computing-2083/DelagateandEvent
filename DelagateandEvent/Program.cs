//delegate
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

        Console.WriteLine("=====List of Generic=====");
        List<string> students =new List<string>();
        students.Add("Alice");
        students.Add("Amrita");
        students.Add("Susma");

        foreach (var student in students)
        {
            Console.WriteLine($"student:{student}");
        }

    }

    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Received message: {message}");
    }
}
//delegate
using System.Security.Cryptography;

delegate void Notification(string message);

//event
class Publisher
{
    public event Notification? MessageSent;

    public void Send(string message)
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

class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Delegate and Event=====");
        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiveMessage;
        publisher.Send("Hello, World!");

        Console.WriteLine("=====Generic=====");
        Console.WriteLine("=====List of int=====");
        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Console.WriteLine("=====List of string=====");
        Box<string> stringBox = new Box<string> { Value = "Hello, World!" };
        stringBox.Display();

        Console.WriteLine("=====List of Generics=====");
        List<string> students = new List<string>();
        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");

        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
        }
    }
    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber message: {message}");
    }
}
using System;

// Event
public class Publisher
{
    public event Action<string>? MessageSent;

    public void Send(string message)
    {
        MessageSent?.Invoke(message);
    }
}

// Generic
public class Box<T>
{
    public T? Value { get; set; }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("==== Delegate and Event ====");

        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiverMessage;

        publisher.Send("Hello, World!");
    }

    public static void ReceiverMessage(string message)
    {
        Console.WriteLine($"Subscriber Message: {message}");

        Console.WriteLine("===== Generic =====");

        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Console.WriteLine("===== List of String =====");

        Box<string> stringBox = new Box<string>
        {
            Value = "Hello, World!"
        };

        stringBox.Display();

        Console.WriteLine("====List of Generic");
        List<String> students = new List<string> ();
        students.Add("John");
        students.Add("Jane");
        students.Add("Jack");

        foreach (var student in students)
        {
            Console.WriteLine($"Students":{ student}); 
        }

console.WriteLine("This is testing");

using System;

// Delegate
delegate void Notification(string message);

// Event
class Publisher
{
    public event Notification? MessageSent;

    public void SendNotification(string message)
    {
        MessageSent?.Invoke(message);
    }
}

// Generic Class
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
        // Delegate and Event Example
        Console.WriteLine("Delegate and Event Example:");

        Publisher publisher = new Publisher();
        publisher.MessageSent += ReceiveMessage;
        publisher.SendNotification("Hello, World!");

        Console.WriteLine();

        // Generic Example
        Console.WriteLine("Generic Example:");
        List<string> students = new List<string> { "Alice", "Bob", "Charlie" };
        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
        }

        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Box<string> stringBox = new Box<string> { Value = "Hello C#" };
        stringBox.Display();
    }

    // Event Subscriber
    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber received: {message}");
    }
}
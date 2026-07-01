using System;
using System.Collections.Generic;

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

        Console.WriteLine("===== String Generic =====");

        Box<string> stringBox = new Box<string>
        {
            Value = "Hello, World!"
        };

        stringBox.Display();

        Console.WriteLine("===== List of Generic =====");

        List<string> students = new List<string>();

        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");

        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
        }
    }
}
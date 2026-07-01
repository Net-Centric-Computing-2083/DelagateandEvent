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
        Console.WriteLine("==== Delegate and Event ====");

        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiverMessage;

        publisher.Send("Hello, World!");
    }

    public static void ReceiverMessage(string message)
    {
        Console.WriteLine($"Subscriber Message: {message}");

        // Generic Integer
        Console.WriteLine("\n===== Integer Generic =====");

        Box<int> intBox = new Box<int>
        {
            Value = 42
        };

        intBox.Display();

        // Generic String
        Console.WriteLine("\n===== String Generic =====");

        Box<string> stringBox = new Box<string>
        {
            Value = "Hello, World!"
        };

        stringBox.Display();

        // Generic List
        Console.WriteLine("\n===== List Generic =====");

        List<string> students = new List<string>();

        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");

        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
        }

        // Dictionary (Key-Value Pair)
        Console.WriteLine("\n===== Dictionary Key-Value =====");

        Dictionary<int, string> studentData = new Dictionary<int, string>();

        studentData.Add(1, "Alice");
        studentData.Add(2, "Bob");
        studentData.Add(3, "Charlie");

        foreach (var item in studentData)
        {
            Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
        }
    }
}
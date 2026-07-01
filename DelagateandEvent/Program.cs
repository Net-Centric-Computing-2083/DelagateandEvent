using System;
using System.Collections.Generic;

// Delegate
delegate void Notification(string message);

// Event
class Publisher
{
    public event Notification MessageSent;

    public void Send(string message)
    {
        MessageSent?.Invoke(message);
    }
}

// Generic Class
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
        Console.WriteLine("==== Delegate and Event ====");
        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiveMessage;
        publisher.Send("Hello World");

        Console.WriteLine("\n==== Generic ====");
        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Box<string> stringBox = new Box<string> { Value = "Hello World" };
        stringBox.Display();

        Console.WriteLine("\n==== Generic List ====");
        List<string> students = new List<string>();
        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");

        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
        }

        // Dictionary Example
        Console.WriteLine("\n==== Dictionary ====");
        Dictionary<int, string> employees = new Dictionary<int, string>();

        employees.Add(101, "Ram");
        employees.Add(102, "Shyam");
        employees.Add(103, "Hari");

        foreach (KeyValuePair<int, string> emp in employees)
        {
            Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
        }

        // Stack Example
        Console.WriteLine("\n==== Stack ====");
        Stack<string> books = new Stack<string>();

        books.Push("C#");
        books.Push("Java");
        books.Push("Python");

        Console.WriteLine("Top Book: " + books.Peek());

        Console.WriteLine("Books in Stack:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("Removed Book: " + books.Pop());

        Console.WriteLine("After Pop:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }
    }

    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber received message: {message}");
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

//delegate
delegate void Notification(string message);

//Event
class Publisher
{
    public event Notification? MessageSent;

    public void Send(string message)
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
        Console.WriteLine($"Value : {Value}");
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("--Delegate and Event--");
        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiveMessage;
        publisher.Send("Hello World");

        Console.WriteLine("---Generic---");
        Console.WriteLine("---List of integer---");
        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Console.WriteLine("---List of string---");
        Box<string> stringBox = new Box<string> { Value = "Hello World!" };
        stringBox.Display();

        Console.WriteLine("---List of Generic---");
        List<string> students = new List<string>();
        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");

        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
        }

        
        // ArrayList
        
        Console.WriteLine("---ArrayList---");

        ArrayList items = new ArrayList();

        items.Add(100);
        items.Add("Apple");
        items.Add(3.14);
        items.Add(true);

        foreach (var item in items)
        {
            Console.WriteLine($"Item: {item}");
        }

       
        // Dictionary
       
        Console.WriteLine("---Dictionary---");

        Dictionary<int, string> studentDictionary = new Dictionary<int, string>();

        studentDictionary.Add(1, "Alice");
        studentDictionary.Add(2, "Bob");
        studentDictionary.Add(3, "Charlie");

        foreach (KeyValuePair<int, string> studentEntry in studentDictionary)
        {
            Console.WriteLine($"ID: {studentEntry.Key}, Name: {studentEntry.Value}");
        }

        
        // Stack
        
        Console.WriteLine("---Stack---");

        Stack<string> books = new Stack<string>();

        books.Push("C# Fundamentals");
        books.Push("ASP.NET Core");
        books.Push("Data Structures");

        Console.WriteLine($"Top Book: {books.Peek()}");

        while (books.Count > 0)
        {
            Console.WriteLine($"Removed: {books.Pop()}");
        }
    }

    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber message: {message}");
    }
}
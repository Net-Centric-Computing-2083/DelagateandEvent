using System;
using System.Collections;
using System.Collections.Generic;

//================ Delegate =================
delegate void Notification(string message);

//================ Event =================
class Publisher
{
    public event Notification? MessageSent;

    public void Send(string message)
    {
        MessageSent?.Invoke(message);
    }
}

//================ Generic =================
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
        //================ Delegate and Event =================
        Console.WriteLine("===== Delegate and Event =====");

        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiveMessage;

        publisher.Send("Hello World!");

        //================ Generic =================
        Console.WriteLine("\n===== Generic =====");

        Console.WriteLine("======= list of Integer =======");
        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Console.WriteLine("===== list of String ======");
        Box<string> stringBox = new Box<string> { Value = "Hello World!" };
        stringBox.Display();

        //================ Generic List =================
        Console.WriteLine("\n===== list of Generic =====");

        List<string> students = new List<string>();

        students.Add("John");
        students.Add("Bob");
        students.Add("Alice");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        //================ ArrayList =================
        Console.WriteLine("\n===== ArrayList =====");

        ArrayList arrayList = new ArrayList();

        arrayList.Add(100);
        arrayList.Add("Ram");
        arrayList.Add(3.14);
        arrayList.Add(true);

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        //================ Dictionary =================
        Console.WriteLine("\n===== Dictionary<Key, Value> =====");

        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        dictionary.Add(101, "John");
        dictionary.Add(102, "Bob");
        dictionary.Add(103, "Alice");

        foreach (KeyValuePair<int, string> item in dictionary)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        //================ Stack =================
        Console.WriteLine("\n===== Stack =====");

        Stack<string> stack = new Stack<string>();

        // Push
        stack.Push("Book");
        stack.Push("Pen");
        stack.Push("Laptop");

        Console.WriteLine("Top Element: " + stack.Peek());

        Console.WriteLine("\nStack Elements:");
        foreach (string item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nPop Element: " + stack.Pop());

        Console.WriteLine("\nStack After Pop:");
        foreach (string item in stack)
        {
            Console.WriteLine(item);
        }
    }

    //================ Subscriber =================
    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber Message: {message}");
    }
}
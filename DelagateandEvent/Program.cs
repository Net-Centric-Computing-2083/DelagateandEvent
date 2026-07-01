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
        Console.WriteLine($"Value: {Value}");
    }
}

class Program
{
    public static void Main()

    {
        Console.WriteLine("====Delegate and Event====");
    
        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiveMessage;
        publisher.Send("Hello, World!");

        Console.WriteLine("====Generic====");
        Console.WriteLine("===List of int==");

        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Console.WriteLine("===List of string");
        Box<string> stringBox = new Box<string> { Value = "Hello, world!" };
        stringBox.Display();

        Console.WriteLine("==list of Generic");
        List<string> students = new List<string>();
        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");
        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
        } 

        // Array
        Console.WriteLine("==== ArrayList ====");

        ArrayList arrayList = new ArrayList();
        arrayList.Add(100);
        arrayList.Add("Hello");
        arrayList.Add(45.5);
        arrayList.Add(true);

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        //Dictionary
        Console.WriteLine("\n==== Dictionary ====");

        Dictionary<int, string> studentsDict = new Dictionary<int, string>();

        studentsDict.Add(1, "Alice");
        studentsDict.Add(2, "Bob");
        studentsDict.Add(3, "Charlie");

        foreach (KeyValuePair<int, string> student in studentsDict)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }

        //Stack

        Console.WriteLine("\n==== Stack ====");

        Stack<string> stack = new Stack<string>();

        stack.Push("Book");
        stack.Push("Pen");
        stack.Push("Notebook");

        Console.WriteLine("Top Item: " + stack.Peek());

        Console.WriteLine("Removing: " + stack.Pop());

        Console.WriteLine("Remaining Items:");
        foreach (string item in stack)
        {
            Console.WriteLine(item);
        }
    }

    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber message:{message}");
    }
}
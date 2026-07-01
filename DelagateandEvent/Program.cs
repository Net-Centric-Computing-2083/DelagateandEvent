using System;
using System.Collections;
using System.Collections.Generic;


//delegate
delegate void Notification(string message);

//Event
class Publisher
{
    public event Notification? MessageSent;   //message aaunani sakxa na aauna ni sakxa so ?

    public void Send(string message)
    {
        MessageSent?.Invoke(message);
    }
}
//Generic
public class Box<T> 
    {   
public T Value
{ get;set;}
    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("==Delegate and Event==");
        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiveMessage;
        publisher.Send("Hello, world!");

        Console.WriteLine("==Generic==");
        Console.WriteLine("==List of int==");
        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Console.WriteLine("==List of string==:");
        Box<string> stringBox = new Box<string> { Value = "Hello, world!" };
        stringBox.Display();

        Console.WriteLine("==List of Generic==:");
        List<string> students = new List<string>();
        students.Add("Aakriti");
        students.Add("Aaku");
        foreach(var student in students)
           {
            Console.WriteLine($"Student: {student}");
        }


        //array list
        Console.WriteLine("\n===== ArrayList =====");

        ArrayList arrayList = new ArrayList();

        arrayList.Add(100);
        arrayList.Add("Aakriti");
        arrayList.Add(95.5);

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        //dictionary
        Console.WriteLine("==Dictionary==");
        Dictionary<int, string> studentDictionary = new Dictionary<int, string>();
        studentDictionary.Add(1, "Aakriti");
        studentDictionary.Add(2, "Aaku");
        foreach (var item in studentDictionary)
        {
            Console.WriteLine($"Student ID: {item.Key}, Name: {item.Value}");
        }

        //stack
        Console.WriteLine("==Stack==");

        Stack<string> subjectStack = new Stack<string>();
        subjectStack.Push("Maths");
        subjectStack.Push("Science");
        Console.WriteLine("Top of the stack: " + subjectStack.Peek());
        Console.WriteLine("Popped from the stack: " + subjectStack.Pop());
        Console.WriteLine("Top of the stack after pop: " + subjectStack.Peek());

        foreach (var subject in subjectStack)
        {
            Console.WriteLine($"Subject: {subject}");
        }
    }
    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber message: {message}");
    }
}
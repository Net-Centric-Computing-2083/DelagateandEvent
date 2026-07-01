//Console.WriteLine("Hello, World!");
//Console.WriteLine(".NET DEMO");
//Console.WriteLine("Hello, .NET!");


//Delegate
using System.Runtime.CompilerServices;

delegate void Notification(string message);

//Event 
class Publisher
{
    public event Notification? MessageSent;
    
    public void Send(String  message)
    {
        MessageSent?.Invoke(message);
    }
}

//Generic 
public class box<T>
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
        Console.WriteLine("=====Delegate and Event Demo=====");
        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiveMessage;
        publisher.Send("Hello, World!");

        Console.WriteLine{"=====Generic Demo====="};
        Console.WriteLine("=====List of integer=====");
        box<int> intBox = new box<int> { Value = 42 };
        intBox.Display();

        Console.WriteLine("=====List of string=====");
        box<string> stringBox = new box<string> { Value = "Hello, World!" };
        stringBox.Display();

        Console.WriteLine("=====List of Generic=====");
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
        Console.WriteLine($"Subscriber Message: {message}");
    }

    //Generic
    


}
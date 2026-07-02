//delegate
using System.Collections;
using System.Security.Cryptography;

delegate void Notification(string message);

//event
class Publisher
{
    public event Notification? MessageSent;

    public void Send(string message)
    {
        MessageSent?.Invoke(message);
    }
}
//Generic delegate
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
        Console.WriteLine("=====Delegate and Event=====");
        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiveMessage;
        publisher.Send("Hello, World!");

        Console.WriteLine("=====Generic=====");
        Console.WriteLine("=====List of int=====");
        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Console.WriteLine("=====List of string=====");
        Box<string> stringBox = new Box<string> { Value = "Hello, World!" };
        stringBox.Display();

        Console.WriteLine("=====List of Generics=====");
        List<string> students = new List<string>();
        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");

        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
        }

        Console.WriteLine("=====ArrayList of Non-Generics=====");
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Nischal");
        arrayList.Add(3.33);
        foreach (var array in arrayList)
        {
            Console.WriteLine($"ArrayList item: {array}");
        }

        Console.WriteLine("=====Dictionary of Generics=====");
        Dictionary<int, string> footballers = new Dictionary<int, string>();
        footballers.Add(1, "Cristiano Ronaldo");
        footballers.Add(2, "Lionel Messi");
        footballers.Add(3, "Kylian Mbappe");
        foreach (var footballer in footballers)
        {
            Console.WriteLine($"Footballer ID: {footballer.Key}, Name: {footballer.Value}");
        }

        Console.WriteLine("=====Stack of Non-Generics=====");
        Stack nstack = new Stack();
        nstack.Push("Nischal");
        nstack.Push(2);
        nstack.Push(33.67);
        foreach (var item in nstack)
        {
            Console.WriteLine($"Stack item: {item}");
        }

        Console.WriteLine("=====Stack of Generics=====");
        Stack<string> gstack = new Stack<string>();
        gstack.Push("Nischal");
        gstack.Push("Pangeni");
        foreach (var item in gstack)
        {
            Console.WriteLine($"Stack item: {item}");
        }

    }
    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber message: {message}");
    }
}
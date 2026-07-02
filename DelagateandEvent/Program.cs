using System.Collections;
// Delegate
delegate void Notification(string message);

// Event
class Publisher
{
    public event Notification? MessageSent;

    public void Send(string message)
    {
        MessageSent?.Invoke(message);
    }
}

// Generic Class
public class Box<T>
{
    public T Value { get; set; } = default!;

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

class MyClass
{
    public static void Main()
    {
        // Delegate and Event
        Console.WriteLine("==== Delegate and Event ====");
        Publisher publisher = new Publisher();

        publisher.MessageSent += ReceiveMessage;
        publisher.Send("Hello, World!");

        // Generic Class
        Console.WriteLine("\n==== Generic Class ====");
        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();

        Box<string> stringBox = new Box<string> { Value = "Hello, World!" };
        stringBox.Display();

        // Generic List
        Console.WriteLine("\n==== Generic List ====");
        List<string> students = new List<string>();

        students.Add("Ashna");
        students.Add("Bob");
        students.Add("John");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // ArrayList
        Console.WriteLine("\n==== ArrayList ====");
        ArrayList arrayList = new ArrayList();

        arrayList.Add(100);
        arrayList.Add("Ashna");
        arrayList.Add(99.5);
        arrayList.Add(true);

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Dictionary
        Console.WriteLine("\n==== Dictionary ====");
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        dictionary.Add(1, " Ashna");
        dictionary.Add(2, "Bob");
        dictionary.Add(3, "John");

        foreach (KeyValuePair<int, string> item in dictionary)
        {
            Console.WriteLine($"Roll: {item.Key}, Name: {item.Value}");
        }

        // Stack
        Console.WriteLine("\n==== Stack ====");
        Stack<string> stack = new Stack<string>();

        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        Console.WriteLine("Top Element: " + stack.Peek());

        Console.WriteLine("Stack Elements:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }

    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber Message: {message}");
    }
}
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
    }
    public static void ReceiveMessage(string message)
    {
        Console.WriteLine($"Subscriber message: {message}");
    }
}
//delegate
delegate void Notification(string message);

class Publisher
{
    public event Notification? MessageSent;

    public void SendMessage(string message)
    {
        MessageSent?.Invoke(message);
    }
}

//Generic delegate
public class Box<T>
{
   public T Value { get; set; }
    public void DisplayValue()
    {
        Console.WriteLine($"Value: {Value}");
    }

}
public class Program
{
    public static void Main()
    {
        Publisher publisher = new Publisher();
        publisher.MessageSent += RecieverMessage;
        publisher.SendMessage("Hello, World!");

        Console.WriteLine("Generic Delegate Example:");
        Box<int> intBox = new Box<int> { Value = 42};
        intBox.DisplayValue();

        Console.WriteLine("Generic Delegate Example with string:");
        Box<string> stringBox = new Box<string> { Value = "Hello, World!"};
        stringBox.DisplayValue();

        Console.WriteLine("list of Generic");
        List<string> Students = new List<string>();
        Students.Add("Alice");
        Students.Add("Bob");
        Students.Add("Charlie");

        foreach (var student in Students)
        {
            Console.WriteLine(student);
        }


    }
    public static void RecieverMessage(string message)
    {
        Console.WriteLine($"Received message: {message}");
    }
    

}
  
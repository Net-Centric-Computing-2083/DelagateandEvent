
//delegate 
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

//Generic class

public class Box<T>{
    public T Value { get; set; }
    public void Display()
    {
        Console.WriteLine($"Value : {Value} ");
    }
}



class Program
{

    public static void Main()
    {
        Console.WriteLine("========DELEGATE AND EVENTS=======");
        Publisher publisher = new Publisher();

        publisher.MessageSent += RecieveMessage;
        publisher.Send("Hello, Kushal! The event has been fired.");


        //generic
        Console.WriteLine("==========Generic ========");
        Console.WriteLine("==========List of Integer ========");

        Box<int>  intBox = new Box<int> { Value = 42 };
        intBox.Display();


        Console.WriteLine("==========List of String========");

        Box<string> stringBox = new Box<string> { Value = "Kushal" };
        stringBox.Display();


        Console.WriteLine("=======List of Generic======");
        List<string> students = new List<string>();
        students.Add("Kushal");
        students.Add("Pahadi");
        students.Add("Hello");


        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
        }
    }

    public static void RecieveMessage(string message) {
        Console.WriteLine($"Subscriber message: {message}");
            }



}
//delegate 
using System.Collections;

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

public class Box<T>
{
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
        publisher.Send("Hello, Rojesh! The event has been fired.");


        //generic class
        Console.WriteLine("==========Generic Class========");
        Console.WriteLine("==========Box of Integer ========");

        Box<int> intBox = new Box<int> { Value = 42 };
        intBox.Display();


        Console.WriteLine("==========Box of String========");

        Box<string> stringBox = new Box<string> { Value = "Rojesh" };
        stringBox.Display();


        Console.WriteLine("=======List :: Generic======");
        List<string> students = new List<string>();
        students.Add("Kushal");
        students.Add("Pahadi");
        students.Add("Hello");


        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
        }


        ///////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("======ArrayList :: Non Genric======");
        ArrayList array = new ArrayList();
        array.Add(1);
        array.Add("Rojesh");
        array.Add(7.7);


        for (int i = 0; i < array.Count; i++)
        {
            Console.WriteLine($"ARRAYLIST[{i}] = {array[i]}");
        }


        ///////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("======HashTable :: Non Genric======");
        Hashtable ht = new Hashtable();
        ht.Add(7, "Rojesh");
        ht.Add("RollNumber", 80010941);

        Console.WriteLine(ht[7]);
        Console.WriteLine(ht["RollNumber"]);



        ///////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("======Stack: Non-Generic======");

        Stack s = new Stack();
        s.Push(1);
        s.Push("Rojesh");
        s.Push(3.3);

        Console.WriteLine(s.Peek());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Peek());



        ///////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("======Queue: Generic======");

        Queue<string> q = new Queue<string>();

        q.Enqueue("Hello");
        q.Enqueue("Rojesh");

        Console.WriteLine(q.Peek());
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Peek());


        ///////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("======Dictionary :: Generic======");
        Dictionary<int, string> d = new Dictionary<int, string>();
        d.Add(1, "Casillas");
        d.Add(4, "Ramos");
        d.Add(7, "Ronaldo");

        Console.WriteLine(d[1]);
        Console.WriteLine(d[4]);
        Console.WriteLine(d[7]);



        ///////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("======HashSet :: Generic======");
        HashSet<string> fruits = new HashSet<string>();

        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Apple");   // Duplicate (ignored)
        fruits.Add("Orange");

        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


    }

    public static void RecieveMessage(string message)
    {
        Console.WriteLine($"Subscriber message: {message}");
    }



}
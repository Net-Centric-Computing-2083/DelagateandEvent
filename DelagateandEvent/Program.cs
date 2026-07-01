using System;
class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public void Speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal dog = new Animal("Dog");
        dog.Speak();
    }
}
using System;

class Animal
{
    // Virtual method
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    // Override the virtual method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.MakeSound();  // Calls Animal's version

        Dog myDog = new Dog();
        myDog.MakeSound();      // Calls Dog's overridden version
    }
}
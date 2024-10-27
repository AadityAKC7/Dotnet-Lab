using System;

class GenericClass<T>
{
    private T[] items;
    private int index;

    public GenericClass(int size)
    {
        items = new T[size];
        index = 0;
    }

    // Generic method to add an item
    public void AddItem(T item)
    {
        if (index < items.Length)
        {
            items[index++] = item;
        }
        else
        {
            Console.WriteLine("Array is full");
        }
    }

    // Generic method to display items
    public void DisplayItems()
    {
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(items[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a generic class for integers
        GenericClass<int> intList = new GenericClass<int>(5);
        intList.AddItem(1);
        intList.AddItem(2);
        intList.AddItem(3);
        intList.DisplayItems();

        // Create a generic class for strings
        GenericClass<string> stringList = new GenericClass<string>(5);
        stringList.AddItem("Hello");
        stringList.AddItem("World");
        stringList.DisplayItems();
    }
}
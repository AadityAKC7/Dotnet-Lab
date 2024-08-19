using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a single alphabet: ");
        char ch = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine(ch + " is a vowel.");
                break;
            default:
                if (ch >= 'a' && ch <= 'z')
                {
                    Console.WriteLine(ch + " is a consonant.");
                }
                else
                {
                    Console.WriteLine(ch + " is not a valid alphabet.");
                }
                break;
        }
    }
}

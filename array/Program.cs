using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize and populate the array with books
        string[] favoriteBooks = {
            "Nous, les dieux",
            "Dorian grey",
            "Invincible",
            "The Odyssey",
            "troisieme humanite"
        };

        Console.WriteLine("📚 My Favorite Books:\n");

        
        foreach (string book in favoriteBooks)
        {
            Console.WriteLine("- " + book);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}

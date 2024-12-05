using System;
using System.Collections.Generic;

public class Program
{
    public static string Likes(string[] names)
    {
        int count = names.Length;

        if (count == 0)
        {
            return "no one likes this";
        }
        else if (count == 1)
        {
            return $"{names[0]} likes this";
        }
        else if (count == 2)
        {
            return $"{names[0]} and {names[1]} like this";
        }
        else if (count == 3)
        {
            return $"{names[0]}, {names[1]} and {names[2]} like this";
        }
        else
        {
            return $"{names[0]}, {names[1]} and {count - 2} others like this";
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество людей, которым понравился товар:");
        int n = int.Parse(Console.ReadLine());

        List<string> names = new List<string>();

        Console.WriteLine($"Введите имена {n} людей, которым понравился товар:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите имя {i + 1}: ");
            string name = Console.ReadLine();
            names.Add(name);
        }

        string result = Likes(names.ToArray());

        Console.WriteLine(result);
    }
}


using Lab3Part1;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter dog's name: ");
        string dogName = Console.ReadLine();
        DogPart1 dog = new DogPart1();
        dog.Name = dogName;
        dog.Colour = "Brown"; 
        dog.Age = 3;
        Console.WriteLine($"Dog's Name: {dog.Name}");
        Console.WriteLine($"Dog's Colour: {dog.Colour}");
        Console.WriteLine($"Dog's Age: {dog.Age}");
        dog.Eat();

        Console.Write("Enter cat's name: ");
        string catName = Console.ReadLine();
        CatPart1 cat = new CatPart1();
        cat.Name = catName;
        cat.Colour = "White"; 
        cat.Age = 2;
        Console.WriteLine($"Cat's Name: {cat.Name}");
        Console.WriteLine($"Cat's Colour: {cat.Colour}");
        Console.WriteLine($"Cat's Age: {cat.Age}");
        cat.Eat();

    }
}

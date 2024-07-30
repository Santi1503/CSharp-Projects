for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"iteracion {i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"iteracion {i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"iteracion {i} - Buzz");
    }
    else
    {
        Console.WriteLine($"iteracion {i}");
    }
}
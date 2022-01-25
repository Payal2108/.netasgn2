using System;
public static class Pro_2
{
    public static void branching(int a, int b)
    {
        if (a + b > 10)
            Console.WriteLine("The answer is greater than 10.");
    }
    public static void ifElse()
    {
        int a = 5;
        int b = 3;
        if (a + b > 10)
            Console.WriteLine("The answer is greater than 10");
        else
            Console.WriteLine("The answer is not greater than 10");
    }
    public static void ifElse2()
    {
        int a = 5;
        int b = 3;
        if (a + b > 10)
        {
            Console.WriteLine("The answer is greater than 10");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
        }
    }
    public static void compare()
    {
        int a = 5;
        int b = 3;
        int c = 4;
        if ((a + b + c > 10) && (a == b))
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("And the first number is equal to the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("Or the first number is not equal to the second");
        }
    }
    public static void compare2()
    {
        int a = 5;
        int b = 3;
        int c = 4;
        if ((a + b + c > 10) || (a == b))
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("Or the first number is equal to the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("And the first number is not equal to the second");
        }
    }
    public static void whileLoop()
    {
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        }
    }
    public static void doWhileLoop()
    {
        int counter = 0;
        do
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        } while (counter < 10);
    }
    public static void forLoop()
    {
        for (int counter = 0; counter < 10; counter++)
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
        }
    }
    public static void nestedLoop()
    {
        for (int row = 1; row < 11; row++)
        {
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
        }
    }
    public static void isDivsibleBy3()
    {
        int sum = 0;
        for (int number = 1; number < 21; number++)
        {
            if (number % 3 == 0)
            {
                sum = sum + number;
            }
        }
        Console.WriteLine($"The sum is {sum}");
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("How many numbers do you want to generate?");
        int values = int.Parse(Console.ReadLine());

        int[] numberArray = new int[values];

        for (int i = 0; i < values; i++)
        {
            numberArray[i] = r.Next(1, 10);
        }

        for(int i = 0;i < numberArray.Length;i++)
        {
            Console.WriteLine(numberArray[i]);
        }

        int addTotal = Add(numberArray);
        int multiplyTotal = Multiply(numberArray);

        Console.WriteLine($"The total amount from the add method is: {addTotal}");
        Console.WriteLine($"The total amount from the multiply method is: {multiplyTotal}");
    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach(int number in numbers)
        {
            total *= number;
        }
        return total;
    }

}
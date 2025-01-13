using System;

public class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        RotateListRight(numbers, 2);
    }

    static void RotateListRight(List<int> data, int amount)
    {
        List<int> lastItems = new();
        for (int i = data.Count - 1, counter = 0; counter < amount; i--, counter++)
        {
            lastItems.Add(data[i]);
        }

        int index;
        for (index = data.Count - 1; (index - amount) >= 0; index--)
        {
            data[index] = data[index - amount];
        }

        for (int i = 0; i < lastItems.Count; i++, index--)
        {
            data[index] = lastItems[i];
        }

        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }
}
public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
        // Create an empty array whose length is the length variable
        // Use a for loop to create a variable, i, that starts at zero and increments by one each loop until it's as big as the length variable
        // In each loop, change the value of the array at i to number times (i plus 1), then return the array

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++) 
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // Save the last 'amount' items in 'data' to a new list
        // Remove the last 'amount' items from 'data'
        // Add the contents of the list you made to the very front of 'data'

        List<int> overflow = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, overflow);

        Console.WriteLine(data);
    }
}
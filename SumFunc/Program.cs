public class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine()?
                             .Split(", ")
                             .Select(s => int.TryParse(s, out var num) ? num : (int?)null)
                             .Where(num => num != null)
                             .Select(num => num!.Value)
                             .ToArray();

        var result = SumMinNumbers(numbers);

        Console.WriteLine(result);
    }

    public static int SumMinNumbers(int[] numbers)
    {
        if (numbers == null)
            throw new ArgumentNullException();
        if (numbers.Length == 0)
            throw new ArgumentException("Пустой массив");
        if (numbers.Length <= 2)
            return numbers.Sum();

        int firstMinNumber = Math.Min(numbers[0], numbers[1]);
        int secondMinNumber = Math.Max(numbers[0], numbers[1]);

        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i] < firstMinNumber)
            {
                secondMinNumber = firstMinNumber;
                firstMinNumber = numbers[i];
                continue;
            }

            if (numbers[i] < secondMinNumber)
                secondMinNumber = numbers[i];
        }

        return firstMinNumber + secondMinNumber;
    }


}
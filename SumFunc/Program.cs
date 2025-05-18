using SumFunc;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите целые числа, разделенные пробелом или через запятую");
            var input = Console.ReadLine() ?? string.Empty;

            var numbers = InputParser.ParseInput(input);
            var result = Calculator.SumMinNumbers(numbers);

            Console.WriteLine($"Сумма минимальных чисел равна: {result}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
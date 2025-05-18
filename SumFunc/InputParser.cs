namespace SumFunc
{
    public static class InputParser
    {
        public static int[] ParseInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Строка не может быть пустой");

            return input.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                       .Select(s => {
                           if (int.TryParse(s.Trim(), out int num))
                               return num;
                           throw new FormatException($"Неверный формат данных: {s}");
                       })
                       .ToArray();
        }
    }
}

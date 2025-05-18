namespace SumFunc
{
    public static class Calculator
    {
        public static int SumMinNumbers(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException();
            if (numbers.Length == 0)
                throw new ArgumentException("Пустой массив");
            if (numbers.Length <= 2)
                return numbers.Sum();

            int firstMinNumber = int.MaxValue;
            int secondMinNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < firstMinNumber)
                {
                    secondMinNumber = firstMinNumber;
                    firstMinNumber = numbers[i];
                    continue;
                }

                if (numbers[i] < secondMinNumber)
                    secondMinNumber = numbers[i];

                if (firstMinNumber < 0 && secondMinNumber < 0 && int.MinValue - firstMinNumber > secondMinNumber)
                    throw new OverflowException("Полученное число выходит за рамки типа int");
                if (firstMinNumber > 0 && secondMinNumber > 0 && int.MaxValue - firstMinNumber < secondMinNumber)
                    throw new OverflowException("Полученное число выходит за рамки типа int");
            }

            return firstMinNumber + secondMinNumber;
        }
    }
}

namespace FactorialNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            var number = Console.ReadLine();

            var result = CalculateFactorial(Convert.ToInt32(number));
            Console.WriteLine($"Factorial of {number} is {result}");
        }

        public static int CalculateFactorial(int number)
        {
            var result = 1;
            for(int i = number; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
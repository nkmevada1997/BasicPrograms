namespace PrimeNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            var number = Console.ReadLine();

            var result = CheckPrimeNumber(Convert.ToInt32(number));

            if (result)
            {
                Console.WriteLine($"{number} is Prime Number");
            }
            else
            {
                Console.WriteLine($"{number} is Not Prime Number");
            }
        }

        private static bool CheckPrimeNumber(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }

}
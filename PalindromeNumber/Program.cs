namespace PalindromeNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            var number = Console.ReadLine();

            var reverse = ReverseNumber(Convert.ToInt32(number));

            if (reverse == Convert.ToInt32(number))
            {
                Console.Write($"{number} is Palindrome");
            }
            else
            {
                Console.Write($"{number} is Not Palindrome");
            }
        }

        private static int ReverseNumber(int number)
        {
            int reverse = 0;
            while (number > 0)
            {
                int rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            };

            return reverse;
        }
    }
}
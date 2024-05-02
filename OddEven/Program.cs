namespace OddEvent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            var number = Console.ReadLine();

            var result = CheckOddEven(Convert.ToInt32(number));

            if (result)
            {
                Console.WriteLine($"{number} is Even");
            }
            else
            {
                Console.WriteLine($"{number} is Odd");
            }


        }

        private static bool CheckOddEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
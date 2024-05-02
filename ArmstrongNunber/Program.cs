namespace ArmStrongNumber
{
    public class Program
    {
        public static void Main(string[] args5)
        {
            Console.WriteLine("Enter The Number");
            var number = Console.ReadLine();

            var result = CheckArmStrongNumber(Convert.ToInt32(number));

            if (result)
            {
                Console.WriteLine($"{number} Is Armstrong");
            }
            else
            {
                Console.WriteLine($"{number} Is Not Armstrong");
            }
        }

        private static bool CheckArmStrongNumber(int number)
        {
            int temp = number;
            int length = temp.ToString().Length;
            double result = 0;
            while (temp > 0)
            {
                int rem = temp % 10;
                result += Math.Pow(rem, length);
                temp /= 10;
            }

            return number == result;
        }
    }
}
namespace FibonacciSeries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            var number = Console.ReadLine();

            var result = GenerateFibonacciSeries(Convert.ToInt32(number));

            foreach ( var item in result )
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> GenerateFibonacciSeries(int number)
        {
            var result = new List<int>
            {
                0
            };
            int b = 0, c = 1;

            for (int i = 1; i <number; i++)
            {
                int a = b;
                b = c;
                c = a + b;
                result.Add(c);
            }
            return result;
        }
    }
}
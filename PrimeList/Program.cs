namespace PrimeList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The StartNumber");
            var start = Console.ReadLine();

            Console.WriteLine("Enter The End Number");
            var end = Console.ReadLine();

            var result = GeneratePrimeList(Convert.ToInt32(start), Convert.ToInt32(end));

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> GeneratePrimeList(int start,int end)
        {
            var result = new List<int>();

            for(int i = start; i <= end; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
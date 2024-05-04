namespace PalindromeString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            var input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                var result = ReverseString(input);

                if (result.Equals(input, StringComparison.Ordinal))
                {
                    Console.WriteLine($"{input} is Palindrome");
                }
                else
                {
                    Console.WriteLine($"{input} is Not Palindrome");
                }
            }
        }

        private static string ReverseString(string value)
        {
            string result = string.Empty;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                result += value[i];
            }
            return result;
        }
    }
}
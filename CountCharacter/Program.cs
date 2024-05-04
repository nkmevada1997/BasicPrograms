namespace CountWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sentence = "Lorem Ipsum is simply dummy script of the printing and typesetting industry. Lorem Ipsum has been the industry standard dummy text ever since the Lorem. Lorem Ipsum is not simply random text.";

            Console.WriteLine("Enter the Word You Want to Find");
            var input = Console.ReadLine();
            var words = sentence.Split(' ');
            var count = 0;
            foreach (var word in words)
            {
                if (input.Equals(word, StringComparison.InvariantCultureIgnoreCase))
                {
                    count++;
                }
            }

            Console.WriteLine($"{input} : {count}");


        }
    }
}
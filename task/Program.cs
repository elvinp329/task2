namespace task
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int number = int.Parse(Console.ReadLine());

            int count = (int)Math.Log10(number) + 1;

            int r;
            int sum = 0;
            while (number != 0)
            {
                r = number % 10;
                number = number / 10;
                sum += r * count;
                count--;
                                                 
             }

                
            Console.WriteLine(sum);
            Console.WriteLine("Hello!");
        }
    }
}
namespace Programming_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my programming practice using https://projecteuler.net/archives");
            //soloutions should be done dated and commited for each Homework
            //example of submission

            // https://projecteuler.net/problem=1
            Console.WriteLine("problem #1 'multiples of 3 or 5'");
            Console.WriteLine("date completed 25/06/2024");
            int total = 0;
            for (int i = 0; i < 1000; i++) { 
                if (i % 3 ==0 || i % 5 ==0)
                {
                    total += i;
                }
            }
            Console.WriteLine("the total of all numbers divisable by 3 or 5 below 1000 is "+ total);
        }
    }
}

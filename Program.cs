namespace ConsoleAppFactorial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas, enter number to calv factorial");
            int nFactorial = int.Parse(Console.ReadLine());
            int fact = 1; 
            for (int i = 2; i <= nFactorial; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
namespace Git_Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 2;
            int c = a + b;
            int Sum (int a, int b)
            {
                return a + b;
            }

            int result = Sum (a, b);
                
            Console.WriteLine($"Обычное сложение: {a} + {b} = {c}");
            Console.WriteLine($"Метод Sum {result}");
            Console.ReadLine();
        }
    }
}

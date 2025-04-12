using ConsoleApp8;

public class Program
{
    public static void Main()
    {
        PrimeNumbers primeNumbers = new PrimeNumbers();

        //GetPrimes
        Console.WriteLine("Простые числа до 20:");
        foreach (var prime in primeNumbers.GetPrimes(20))
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine();

        //GetAllPrimes (первые 10 простых чисел)
        Console.WriteLine("Первые 10 простых чисел:");
        int count = 0;
        foreach (var prime in primeNumbers.GetAllPrimes())
        {
            Console.Write(prime + " ");
            count++;
            if (count == 10)
            {
                break;
            }
        }
        Console.WriteLine();

        //SkipPrimes (пропустить первые 5 простых чисел)
        Console.WriteLine("Простые числа после пропуска первых 5:");
        foreach (var prime in primeNumbers.SkipPrimes(5))
        {
            Console.Write(prime + " ");
            if (prime > 20) 
            {
                break;
            }
        }
        Console.WriteLine();
    }
}
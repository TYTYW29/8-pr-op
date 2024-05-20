using System.IO;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {


        string inputFilePath = "input.txt";
        string numberStr = File.ReadAllText(inputFilePath).Trim();


        BigInteger number = BigInteger.Parse(numberStr);


        int N = 3;
        BigInteger result = BigInteger.Pow(number, N);
        Console.WriteLine(result);

    }
}

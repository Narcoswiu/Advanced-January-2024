using System.Security.Cryptography.X509Certificates;

namespace _03._Count_Uppercase_Words
{
     class Program
    {
        static void Main()
        {
            Predicate<string> filter = (string x) => x.Length > 0 && char.IsUpper(x[0]);
            Console.WriteLine(string.Join("\r\n",Console.ReadLine().Split(" ").Where(x=>filter(x)).ToArray()));

        }
    }
}
using chainofresponsibility2.Models;

namespace chainofresponsibility2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new SentenceValidator(
                new Subject(),
                ChainType.WordSpaceWord,
                ValidationType.Auto);

            Console.ReadLine();

        }
    }
}
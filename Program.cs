using chainofresponsibility2.Models;

namespace chainofresponsibility2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // should validate correct
            new SentenceValidator(
                new Subject(),
                ChainType.WordSpaceWord,
                ValidationType.Auto);
            
            new SentenceValidator(
                new Subject(),
                ChainType.WordSpaceWord,
                ValidationType.Step).Validate(Lista);

            new SentenceValidator

            // should validate wrong 
            new SentenceValidator(
                new Subject("ayto tha bgalei lathos"),
                ChainType.WordSpaceWord,
                ValidationType.Auto);

            new SentenceValidator(
                new Subject("ayto tha bgalei lathos"),
                ChainType.WordSpaceWord,
                ValidationType.Step).Validate();

            Console.ReadLine();

        }
    }
}
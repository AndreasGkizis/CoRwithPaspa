namespace chainofresponsibility2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            var test = new SentenceValidator<Subject>(new Subject(), ChainType.WordSpaceWord);
            Console.WriteLine(test);
            var test2 = new SentenceValidator<string>("asdasd", ChainType.StartsWithWhitespace);
            var test4 = new SentenceValidator<int>(5, ChainType.StartsWithWhitespace);
            Console.ReadLine();

        }
    }
}
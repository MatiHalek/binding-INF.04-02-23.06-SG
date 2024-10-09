namespace konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint[] randomNumbersArray = new uint[100];
            Random randomNumberGenerator = new();
            for(int i = 0; i < randomNumbersArray.Length; i++)
            {
                randomNumbersArray[i] = (uint)randomNumberGenerator.Next(0, 1001);
            }
        }
    }
}

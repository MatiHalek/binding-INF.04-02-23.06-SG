namespace konsola
{
    internal class Program
    {
        static void SortArray(uint[] arrayToSort)
        {
            for(uint i = (uint)arrayToSort.Length - 1; i > 0; i--)
            {
                for (uint j = 0; j < i; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        uint tmp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = tmp;
                    }
                }
            }
        }
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

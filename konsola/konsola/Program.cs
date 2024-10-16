namespace konsola
{
    public class Program
    {
        public static void BubbleSortArray(int[] arrayToSort)
        {
            for(int i = arrayToSort.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        int tmp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = tmp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] randomNumbersArray = new int[100];
            Random randomNumberGenerator = new();
            for(int i = 0; i < randomNumbersArray.Length; i++)
            {
                randomNumbersArray[i] = randomNumberGenerator.Next(0, 1001);
            }
            BubbleSortArray(randomNumbersArray);
            Console.WriteLine($"Posortowana rosnąco tablica sortowaniem bąbelkowym: {string.Join(", ", randomNumbersArray)}");
            ;
        }
    }
}

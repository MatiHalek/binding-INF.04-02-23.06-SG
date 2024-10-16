using konsola;

namespace BubbleSortArrayTests
{
    public class ProgramTests
    {
        [Fact]
        public void GivenUnsortedArray_WhenBubbleSorted_ThenReturnSortedArray()
        {
            //Arrange - przygotuj dane wej�ciowe
            int[] numbersArray = new int[100];

            Random random = new();
            for(int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = random.Next(0, 1001);
            }

            int[] expectedNumbersArray = new int[100];
            Array.Copy(numbersArray, expectedNumbersArray, numbersArray.Length);
            Array.Sort(expectedNumbersArray);

            //Act - Wywo�aj metod�, kt�r� chcesz przetestowa�
            Program.BubbleSortArray(numbersArray);

            //Assert - sprawd�, czy wynik metody jest zgodny z oczekiwan� warto�ci�
            Assert.Equal(expectedNumbersArray, numbersArray);   
            //Assert.Equal(100, expectedNumbersArray.Length);   
        }
    }
}
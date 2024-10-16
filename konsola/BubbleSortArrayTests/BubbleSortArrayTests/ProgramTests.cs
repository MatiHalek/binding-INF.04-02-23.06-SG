using konsola;

namespace BubbleSortArrayTests
{
    public class ProgramTests
    {
        [Fact]
        public void GivenUnsortedArray_WhenBubbleSorted_ThenReturnSortedArray()
        {
            //Arrange - przygotuj dane wejœciowe
            int[] numbersArray = new int[100];

            Random random = new();
            for(int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = random.Next(0, 1001);
            }

            int[] expectedNumbersArray = new int[100];
            Array.Copy(numbersArray, expectedNumbersArray, numbersArray.Length);
            Array.Sort(expectedNumbersArray);

            //Act - Wywo³aj metodê, któr¹ chcesz przetestowaæ
            Program.BubbleSortArray(numbersArray);

            //Assert - sprawdŸ, czy wynik metody jest zgodny z oczekiwan¹ wartoœci¹
            Assert.Equal(expectedNumbersArray, numbersArray);   
            //Assert.Equal(100, expectedNumbersArray.Length);   
        }
    }
}
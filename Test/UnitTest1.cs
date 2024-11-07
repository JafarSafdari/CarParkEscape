using System.Reflection;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Escape_WhenThereIsNoParking_ShouldReturnEmptyArray()
    {
        //arrange
        int[,] carpark = new int[,] {{}};
        string[] expectedResult = new string[] { } ;

        //act
        var result = Kata.escape(carpark);

        //assert
        Assert.Equal(expectedResult, result);
    }

    [Theory, MemberData(nameof(EmptyValues))]
    public void Escape_WhenStartingAtTheGroundFloor_ShouldReturnDirectionAndDistance(int [,] carpark, string[] expectedResult)
    {

        //act
        var result = Kata.escape(carpark);

        //assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> EmptyValues
    {
        get
        {

            yield return new object[] { new int[,] { { 2, 0 } }, new string [] {"R1"} };
            yield return new object[] { new int[,] { { 2, 0, 0, 1 } }, new string [] {"R3"} };
        }
    }


}
using System.Reflection;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Escape_WhenThereIsNoParking_ShouldReturnEmptyArray()
    {
        //arrange
        int[,] carpark = new int[,] { { }};
        string[] expectedResult = new string[] { } ;

        //act
        var result = Kata.escape(carpark);

        //assert
        Assert.Equal(expectedResult, result);
    }
}
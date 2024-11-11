namespace Test;

public class UnitTest1
{
    [Fact]
    public void Escape_WhenThereIsNoParking_ShouldReturnEmptyArray()
    {
        //arrange
        int[,] carpark = {{}};
        string[] expectedResult = { } ;

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

            yield return [new[,] { { 2, 0 } }, new[] {"R1"}];
            yield return [new[,] { { 2, 0, 0, 0 } }, new[] {"R3"}];
        }
    }
    
    [Fact]
    public void Escape_StartingOnSecondFloor_ShouldReturnDirectionsToExit()
    {
        //arrange
        int[,] carpark =
        {
            {0,2,1,0,0}, 
            {0,0,0,0,0}
        };
        string[] expectedResult = ["R2", "D1", "R2"];

        //act
        var result = Kata.escape(carpark);

        //assert
        Assert.Equal(expectedResult, result);
    }


}
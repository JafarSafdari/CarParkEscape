public class Kata
{
    public static string[] escape(int[,] carpark)
    {
        var floorLength = carpark.GetLength(1);
        
        if (floorLength == 0)
            return [];
        
        var startPosition = GetStartPosition(carpark);
        
        return ["R" + GetDistance(floorLength, startPosition)];
    }

    private static int GetDistance(int floorLength, int startPosition)
    {
        return floorLength - startPosition - 1;
    }

    private static int GetStartPosition(int[,] carpark)
    {
        var startPosition = -1;
        for (var i = 0; i < carpark.GetLength(1); i++)
        {
            if (carpark[0, i] == 2)
                startPosition = i;
        }

        return startPosition;
    }
}
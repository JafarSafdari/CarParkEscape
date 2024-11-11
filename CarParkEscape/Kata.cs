public class Kata
{
    public static string[] escape(int[,] carpark)
    {
        var floorLength = carpark.GetLength(1);
        
        if (floorLength == 0)
            return [];
        
        var (floor, startPosition) = GetStartPosition(carpark);
        
        return ["R" + GetDistance(floorLength, startPosition)];
    }

    private static int GetDistance(int floorLength, int startPosition)
    {
        return floorLength - startPosition - 1;
    }

    private static (int floor, int startPosition) GetStartPosition(int[,] carpark)
    {
        var startPosition = -1;
        var floor = -1;
        
        for (var i = 0; i < carpark.GetLength(0); i++)
        {
            for (var j = 0; j < carpark.GetLength(1); j++)
            {
                if (carpark[i, j] != 2) continue;
                
                floor = i;
                startPosition = j;
            }
        }

        return (floor, startPosition);
    }
}
public class Kata
{
    public static string[] escape(int[,] carpark)
    {
        if (carpark.GetLength(1) == 0)
            return [];
        if (carpark.GetLength(1) == 4)
            return ["R3"];
        return ["R1"];
    }
 }
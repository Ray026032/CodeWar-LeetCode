using System;
using System.Collections;
public class Kata
{
    public static void Main()
    {
        Console.WriteLine(FindMinDifference(["12:12", "00:13", "00:13", "00:13"]));
    }
    public static int FindMinDifference(IList<string> timePoints)
    {
        List<int> timeMinutes = new List<int>();
        for(int i = 0; i < timePoints.Count; i++)
        {
            string[] timePointPart = timePoints[i].Split(':');
            var hour = Convert.ToInt32(timePointPart[0]);
            var minute = Convert.ToInt32(timePointPart[1]);
            timeMinutes.Add(hour * 60 + minute);
        }
        timeMinutes.Sort();
        int minDifference = int.MaxValue;
        for (int i = timeMinutes.Count - 1; i > 0; i--)
        {
            minDifference = Math.Min(timeMinutes[i] - timeMinutes[i - 1], minDifference);
        }
        minDifference = Math.Min((1440 - timeMinutes[timeMinutes.Count - 1] + timeMinutes[0]), minDifference);
        return minDifference;
    }
}

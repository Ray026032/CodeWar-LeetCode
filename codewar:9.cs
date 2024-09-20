using System;

public class DigPow
{
    public static void Main()
    {
        Console.WriteLine(digPow(695, 2));
    }
    public static long digPow(int n, int p)
    {
        char[] charArray = n.ToString().ToCharArray();

        int[] Aint = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));

        double sumOfPow = 0;

        for (int i = 0; i < Aint.Length; i++)
        {
            sumOfPow += Math.Pow(Aint[i], p);
            p++;
        }

        return (sumOfPow % n == 0) ? (long)sumOfPow / n : -1;
    }
}

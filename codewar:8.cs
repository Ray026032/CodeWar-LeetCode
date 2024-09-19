using System;

public class Brace
{
    public static void Main()
    {
        Console.WriteLine(validBraces("[](){}"));
        Console.WriteLine(validBraces("[[](){}]"));
        Console.WriteLine(validBraces("[[({"));
    }
    public static bool validBraces(String braces)
    {
        Stack<char> stack = new Stack<char>();
        List<char> Leftbraces = new List<char>() { '(', '[', '{' };
        List<char> Rightbraces = new List<char>() { ')', ']', '}' };

        foreach (char c in braces)
        {
            if (Leftbraces.Contains(c))
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0 || stack.Pop() != Leftbraces[Rightbraces.IndexOf(c)])
                    return false;
            }
        }

        return stack.Count == 0;
    }
}

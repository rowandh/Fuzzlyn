// Generated by Fuzzlyn on 2018-07-31 09:47:11
// Seed: 1036019360908976561
// Reduced from 221.2 KiB to 0.3 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
public class Program
{
    static sbyte s_1 = -61;
    public static void Main()
    {
        bool vr35 = default(bool);
        bool vr36 = '$' >= (ushort)(s_1 ^ 1U);
        if (vr36)
        {
            System.Console.WriteLine(vr35);
        }
        else
        {
        }
    }
}
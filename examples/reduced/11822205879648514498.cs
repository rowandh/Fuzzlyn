// Generated by Fuzzlyn on 2018-07-19 15:05:01
// Seed: 11822205879648514498
// Reduced from 77.1 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    public static void Main()
    {
        var vr6 = new long[][, ]{new long[, ]{{0}}};
        M4(vr6);
    }

    static sbyte M4(long[][, ] arg0)
    {
        bool vr0 = 163 >= (2133751815 % ((331594547251403425UL * (char)(0 & ((arg0[0][0, 0] & 0) | 0))) - 255));
        if (vr0)
        {
        }

        arg0[0] = arg0[0];
        return 0;
    }
}

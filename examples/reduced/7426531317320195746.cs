// Generated by Fuzzlyn on 2018-07-21 03:58:10
// Seed: 7426531317320195746
// Reduced from 285.6 KiB to 0.4 KiB
// Debug: Outputs 65534
// Release: Outputs -2
public class Program
{
    static ulong s_1;
    static sbyte s_4;
    static int s_55;
    public static void Main()
    {
        s_4 = -2;
        s_1 = (ulong)M1();
    }

    static short M1()
    {
        byte vr13 = 244;
        char vr14 = (char)(s_4 | vr13);
        System.Console.WriteLine((int)vr14);
        return (short)s_55;
    }
}

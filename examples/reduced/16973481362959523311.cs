// Generated by Fuzzlyn on 2018-07-30 18:04:38
// Seed: 16973481362959523311
// Reduced from 171.8 KiB to 0.3 KiB
// Debug: Outputs 65440
// Release: Outputs -96
public class Program
{
    static short s_1;
    static sbyte s_36 = -96;
    public static void Main()
    {
        char vr1 = M1();
        System.Console.WriteLine((int)vr1);
    }

    static char M1()
    {
        ushort vr0 = (ushort)(s_36 ^ s_1);
        return (char)vr0;
    }
}

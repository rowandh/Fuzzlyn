// Generated by Fuzzlyn v1.1 on 2018-09-26 19:07:45
// Seed: 182882527214289275
// Reduced from 270.9 KiB to 0.7 KiB in 00:06:55
// Debug: Outputs 0
// Release: Outputs -2
struct S0
{
    public long F4;
}

public class Program
{
    static S0[, ] s_13 = new S0[, ]{{new S0()}};
    static long[] s_28 = new long[]{0};
    static short s_41;
    public static void Main()
    {
        var vr12 = new bool[]{false};
        bool vr13 = M44(vr12, s_41);
    }

    static bool M44(bool[] arg2, short arg3)
    {
        var vr4 = arg3--;
        var vr6 = arg3 / -26653;
        System.Console.WriteLine(vr6);
        try
        {
            System.Console.WriteLine(0);
        }
        finally
        {
            M47(arg3);
        }

        return arg2[0];
    }

    static void M47(short arg1)
    {
        s_28[0] -= s_13[0, 0].F4;
    }
}
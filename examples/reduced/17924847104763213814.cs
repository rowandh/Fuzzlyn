// Generated by Fuzzlyn v1.1 on 2018-09-18 04:46:43
// Seed: 17924847104763213814
// Reduced from 263.8 KiB to 0.6 KiB in 00:08:25
// Debug: Outputs 0
// Release: Outputs 2
public class Program
{
    static uint s_25;
    static long s_45;
    static sbyte s_53;
    public static void Main()
    {
        M60(ref s_45, s_53);
        System.Console.WriteLine(s_45);
    }

    static void M60(ref long arg0, sbyte arg2)
    {
        arg2 = -1;
        try
        {
            M67();
        }
        finally
        {
            System.Console.WriteLine(arg2);
        }

        sbyte vr10 = (sbyte)s_25;
        arg2 = vr10;
        arg0 = (arg2 / -127);
    }

    static short M67()
    {
        return default(short);
    }
}
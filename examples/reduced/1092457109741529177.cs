// Generated by Fuzzlyn v1.1 on 2018-09-09 15:00:48
// Seed: 1092457109741529177
// Reduced from 215.7 KiB to 0.6 KiB in 00:05:16
// Debug: Outputs 0
// Release: Outputs -669519104
public class Program
{
    static sbyte s_34;
    static sbyte s_50;
    public static void Main()
    {
        bool vr5 = 1 == M27(s_50, s_34);
    }

    static ushort M27(sbyte arg0, sbyte arg1)
    {
        try
        {
            arg0 = -1;
            ref sbyte var5 = ref arg1;
            System.Console.WriteLine(var5);
        }
        finally
        {
            arg1 = arg0;
        }

        arg1 = 0;
        arg0 = arg1;
        var vr2 = arg0 * -1993873395;
        System.Console.WriteLine(vr2);
        long vr7 = default(long);
        return (ushort)vr7;
    }
}
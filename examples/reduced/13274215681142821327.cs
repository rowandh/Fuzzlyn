// Generated by Fuzzlyn v1.1 on 2018-08-31 18:05:36
// Seed: 13274215681142821327
// Reduced from 298.2 KiB to 0.9 KiB in 00:15:50
// Debug: Outputs 1
// Release: Outputs -1
public class Program
{
    static short[] s_9;
    static ulong s_28;
    static bool s_63 = true;
    static uint s_78;
    static int s_106;
    static bool s_130;
    static short[] s_145;
    public static void Main()
    {
        s_130 = s_63;
        var vr37 = M107(0);
        System.Console.WriteLine(vr37);
    }

    static sbyte M107(sbyte arg0)
    {
        ulong var4 = default(ulong);
        try
        {
            s_28 = var4;
        }
        finally
        {
            if (s_130)
            {
                arg0 = -127;
                sbyte var6 = arg0;
                arg0 = (sbyte)(var6++ ^ s_78);
                arg0 /= var6;
                System.Console.WriteLine(s_106);
            }
            else
            {
                s_145 = new short[]{1};
                var vr3 = s_9[0];
                s_130 = s_63;
            }
        }

        return arg0;
    }
}
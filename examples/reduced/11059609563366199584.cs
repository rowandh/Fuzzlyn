// Generated by Fuzzlyn v1.1 on 2018-08-31 02:15:27
// Seed: 11059609563366199584
// Reduced from 217.8 KiB to 1.0 KiB in 00:07:37
// Debug: Outputs 0
// Release: Outputs -2
public class Program
{
    static bool s_4;
    static uint s_16;
    static sbyte[] s_30 = new sbyte[]{0};
    static sbyte[, ] s_41;
    static short[] s_66;
    public static void Main()
    {
        M82(-1);
    }

    static void M82(sbyte arg0)
    {
        try
        {
            bool vr1 = M85();
        }
        finally
        {
            if (M85())
            {
                bool var2 = s_4;
                var vr2 = s_16--;
                M84(ref s_66[0], vr2);
                arg0 = s_41[0, 0];
                System.Console.WriteLine(var2);
            }
            else
            {
                int var3 = 0;
                System.Console.WriteLine(var3);
            }
        }

        arg0 -= arg0;
        arg0 = s_30[0];
        arg0 %= 127;
        System.Console.WriteLine(arg0);
    }

    static sbyte M84(ref short arg0, uint arg1)
    {
        return default(sbyte);
    }

    static bool M85()
    {
        return default(bool);
    }
}
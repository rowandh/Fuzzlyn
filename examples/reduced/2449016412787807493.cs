// Generated by Fuzzlyn v1.1 on 2018-09-29 02:31:16
// Seed: 2449016412787807493
// Reduced from 213.4 KiB to 1.0 KiB in 00:06:53
// Debug: Outputs -1
// Release: Outputs 0
public class Program
{
    static uint[] s_31 = new uint[]{1};
    static long[] s_42 = new long[]{0};
    static bool[,, ] s_77 = new bool[,, ]{{{true}}};
    public static void Main()
    {
        long vr15 = default(long);
        var vr12 = (short)vr15;
        bool vr13 = M85(vr12);
    }

    static bool M85(short arg0)
    {
        short var0 = arg0--;
        if (0 == s_31[0])
        {
            try
            {
                M86();
            }
            finally
            {
                bool[][] var3 = new bool[][]{new bool[]{true}, new bool[]{false}, new bool[]{true}, new bool[]{false, true, false}, new bool[]{false}, new bool[]{true}};
            }
        }
        else
        {
            arg0 >>= 0;
            var0 = arg0;
            if (s_42[0] < var0)
            {
                arg0 = 0;
            }
        }

        System.Console.WriteLine(arg0);
        return s_77[0, 0, 0];
    }

    static byte M86()
    {
        return default(byte);
    }
}
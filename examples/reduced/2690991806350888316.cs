// Generated by Fuzzlyn v1.1 on 2018-09-30 13:11:02
// Seed: 2690991806350888316
// Reduced from 348.2 KiB to 1.4 KiB in 00:09:27
// Debug: Outputs 1
// Release: Outputs -14911
public class Program
{
    static sbyte s_4;
    static sbyte s_10;
    static bool s_11;
    static uint s_18;
    static short s_23;
    static ushort s_68;
    static byte s_127;
    static uint[] s_141;
    public static void Main()
    {
        s_10 = -1;
        s_4 = s_10;
        M139(-1);
    }

    static void M139(short arg0)
    {
        bool[] var7 = default(bool[]);
        byte var14 = default(byte);
        bool var16 = default(bool);
        if (M143(0))
        {
            try
            {
                System.Console.WriteLine(var14);
            }
            finally
            {
                var7[0] = true;
                byte var15 = s_127++;
                var vr0 = s_23++;
                uint vr19 = M140(s_68, (byte)M146(vr0));
                if (s_11)
                {
                    vr19 = s_18++;
                }

                System.Console.WriteLine(var16);
            }
        }
        else
        {
            arg0 /= s_4;
            arg0 %= 25312;
        }

        System.Console.WriteLine(arg0);
    }

    static byte M140(ushort arg1, byte arg2)
    {
        return default(byte);
    }

    static bool M143(uint arg1)
    {
        arg1 = s_18++;
        return false;
    }

    static ref uint M146(short arg0)
    {
        return ref s_141[0];
    }
}

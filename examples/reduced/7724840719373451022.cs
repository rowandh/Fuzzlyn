// Generated by Fuzzlyn v1.1 on 2018-09-17 18:21:32
// Seed: 7724840719373451022
// Reduced from 18.3 KiB to 1.3 KiB in 00:00:38
// Debug: Prints 2 line(s)
// Release: Prints 3 line(s)
struct S0
{
    public int F1;
    public long F3;
    public byte F5;
    public int F6;
    public bool F8;
}

public class Program
{
    static long[] s_1;
    static uint s_2;
    static S0 s_4;
    static uint[] s_6 = new uint[]{841732718U};
    static sbyte[] s_7 = new sbyte[]{1};
    public static void Main()
    {
        s_1 = new long[]{-1};
        var vr5 = s_7[0];
        M4(vr5, ref s_6);
    }

    static void M4(sbyte arg0, ref uint[] arg1)
    {
        ulong var5 = default(ulong);
        arg0 = (sbyte)s_1[0];
        s_2 = arg1[0];
        if (((uint)(183 * arg0) < s_2))
        {
            System.Console.WriteLine(var5);
        }

        try
        {
            System.Console.WriteLine(s_4.F6);
        }
        finally
        {
            var vr2 = s_4.F6;
            if (M5(ref s_4.F8, vr2, ref arg1[0]))
            {
                s_4.F5 = s_4.F5--;
                var vr0 = new byte[]{0};
                var vr3 = s_4.F3;
                var vr4 = s_4.F1--;
                M6(ref arg1[0], vr3, vr4);
            }
        }

        System.Console.WriteLine(arg0);
    }

    static bool M5(ref bool arg1, int arg2, ref uint arg3)
    {
        return default(bool);
    }

    static void M6(ref uint arg1, long arg2, int arg3)
    {
    }
}
// Generated by Fuzzlyn v1.1 on 2018-10-05 13:10:48
// Seed: 8857567660410210807
// Reduced from 181.2 KiB to 1.2 KiB in 00:04:28
// Debug: Prints 1 line(s)
// Release: Prints 2 line(s)
struct S0
{
    public ushort F0;
    public S0(ushort f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public int F1;
    public bool F4;
    public long F6;
    public S1(int f1, S0 f2, S0 f3, bool f4, long f6, S0 f7): this()
    {
        F1 = f1;
        F4 = f4;
        F6 = f6;
    }
}

public class Program
{
    static S1[,, ] s_9 = new S1[,, ]{{{new S1(1, new S0(0), new S0(1), false, 0, new S0(0))}}};
    static int[] s_10 = new int[]{0};
    static short s_27;
    public static void Main()
    {
        var vr5 = s_27--;
        var vr7 = new short[]{0};
        M53(vr7, -32768);
    }

    static void M53(short[] arg3, short arg7)
    {
        arg7 <<= s_9[0, 0, 0].F1;
        if (s_27 >= (short)(arg7 % 68))
        {
            System.Console.WriteLine(s_10[0]);
        }

        try
        {
            arg7 = arg3[0];
        }
        finally
        {
            var vr2 = new S1(0, new S0(1), new S0(0), true, 0, new S0(0));
            int var7 = (int)M58();
        }

        System.Console.WriteLine(arg7);
    }

    static ulong M58()
    {
        return default(ulong);
    }
}

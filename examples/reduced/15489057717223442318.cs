// Generated by Fuzzlyn v1.1 on 2018-09-11 22:34:37
// Seed: 15489057717223442318
// Reduced from 314.2 KiB to 1.5 KiB in 00:07:43
// Debug: Outputs 0
// Release: Outputs -2
struct S0
{
    public short F0;
    public sbyte F1;
    public byte F2;
    public ushort F3;
    public int F4;
    public sbyte F5;
    public S0(short f0, sbyte f1, byte f2, ushort f3, int f4, sbyte f5): this()
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
    }
}

class C0
{
    public S0 F2;
    public C0(S0 f2)
    {
        F2 = f2;
    }
}

struct S1
{
    public C0 F7;
    public S1(C0 f7): this()
    {
        F7 = f7;
    }
}

public class Program
{
    static S0 s_14;
    static bool s_17;
    static short s_26;
    static S1 s_28;
    static C0 s_35 = new C0(new S0(-1, 0, 1, 0, 0, 0));
    public static void Main()
    {
        s_28 = new S1(new C0(new S0(-1, 0, 1, 1, 0, 0)));
        S0 vr16 = s_28.F7.F2;
        short vr17 = vr16.F0;
        ulong vr11 = (ulong)M38(vr17) % (byte)(M32() | 1);
    }

    static int M32()
    {
        S0 vr19;
        vr19.F0 = s_14.F0;
        System.Console.WriteLine(vr19.F0);
        return 0;
    }

    static sbyte M38(short arg1)
    {
        try
        {
            M41();
        }
        finally
        {
            var vr2 = new S0(0, 0, 0, 0, 0, 1);
            var vr6 = s_35.F2.F4;
            M41();
            arg1 = s_26;
            arg1 /= 32767;
            System.Console.WriteLine(s_17);
        }

        s_14.F0 = arg1;
        return 0;
    }

    static byte M41()
    {
        return default(byte);
    }
}
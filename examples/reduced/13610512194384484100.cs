// Generated by Fuzzlyn v1.1 on 2018-09-03 02:00:36
// Seed: 13610512194384484100
// Reduced from 326.6 KiB to 1.2 KiB in 00:10:50
// Debug: Outputs 0
// Release: Outputs 25344
struct S0
{
    public byte F1;
}

class C0
{
    public S0 F2;
}

struct S2
{
}

struct S3
{
    public short F0;
    public ulong F1;
    public ushort F2;
    public ushort F3;
    public long F4;
    public ushort F5;
    public ushort F6;
    public int F7;
    public S3(short f0, ulong f1, ushort f2, ushort f3, long f4, ushort f5, ushort f6, int f7): this()
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
        F7 = f7;
    }
}

public class Program
{
    static C0 s_2 = new C0();
    static S3 s_12;
    public static void Main()
    {
        sbyte vr11 = default(sbyte);
        S0 vr12;
        try
        {
            S2[][] vr14 = new S2[][]{new S2[]{new S2()}};
        }
        finally
        {
            S0 vr15 = s_2.F2;
            vr12 = vr15;
            var vr13 = new S3(1, 0, 0, 0, 0, 0, 0, 0);
            s_12.F0 = (short)(537550877U * vr12.F1);
            System.Console.WriteLine(vr11);
        }

        System.Console.WriteLine(vr12.F1);
        var vr16 = s_12.F0;
        System.Console.WriteLine(vr16);
    }
}
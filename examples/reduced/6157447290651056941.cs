// Generated by Fuzzlyn v1.1 on 2018-09-22 19:04:15
// Seed: 6157447290651056941
// Reduced from 118.5 KiB to 0.6 KiB in 00:01:47
// Debug: Outputs 1
// Release: Outputs 0
class C0
{
    public ushort F4;
    public C0(ushort f4)
    {
        F4 = f4;
    }
}

struct S0
{
    public C0 F3;
    public S0(C0 f3): this()
    {
        F3 = f3;
    }
}

struct S3
{
    public S0 F2;
    public sbyte F3;
    public S3(S0 f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    static ushort s_10;
    public static void Main()
    {
        var vr1 = new S3[]{new S3(new S0(new C0(0)))};
        vr1[0].F2.F3.F4 = 0;
        vr1[0].F2.F3 = new C0(1);
        s_10 = vr1[0].F2.F3.F4;
        System.Console.WriteLine(s_10);
    }
}

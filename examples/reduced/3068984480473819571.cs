// Generated by Fuzzlyn v1.1 on 2018-10-04 19:05:03
// Seed: 3068984480473819571
// Reduced from 13.3 KiB to 0.6 KiB in 00:00:20
// Debug: Outputs 1
// Release: Outputs 0
class C0
{
    public sbyte F0;
    public byte F3;
    public C0(sbyte f0)
    {
        F0 = f0;
    }
}

struct S0
{
    public C0 F2;
    public S0(C0 f2): this()
    {
        F2 = f2;
    }
}

struct S1
{
    public S0 F0;
    public C0 F1;
    public S1(S0 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1 s_4 = new S1(new S0(new C0(0)));
    public static void Main()
    {
        S1[] vr0 = new S1[]{new S1(new S0(new C0(0)))};
        s_4.F0.F2.F3 = vr0[0].F0.F2.F3;
        vr0[0].F0.F2 = new C0(1);
        S0 vr1 = vr0[0].F0;
        System.Console.WriteLine(vr1.F2.F0);
    }
}
// Generated by Fuzzlyn v1.1 on 2018-09-08 02:39:41
// Seed: 17841922293791499253
// Reduced from 238.9 KiB to 0.6 KiB in 00:04:13
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public long F0;
    public ulong F1;
    public sbyte F5;
    public ushort F6;
    public bool F7;
    public S0(ushort f6): this()
    {
        F6 = f6;
    }
}

struct S4
{
    public bool F1;
    public S0 F2;
    public S4(S0 f2): this()
    {
        F2 = f2;
    }
}

struct S6
{
    public S4 F0;
    public S6(S4 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S6 vr2 = new S6(new S4(new S0(1)));
        var vr3 = vr2.F0.F2.F6;
        System.Console.WriteLine(vr3);
    }
}

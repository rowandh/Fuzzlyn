// Generated by Fuzzlyn v1.1 on 2018-09-09 23:18:56
// Seed: 10293536524865284108
// Reduced from 408.4 KiB to 0.6 KiB in 00:10:14
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public ulong F0;
    public long F3;
    public byte F5;
    public S0(ulong f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_27 = new S0(1);
    static S0[] s_31;
    static S0 s_105;
    public static void Main()
    {
        var vr1 = new S0(0);
        M55(s_27, M83(vr1));
    }

    static void M55(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }

    static ref S0 M83(S0 arg14)
    {
        s_31 = new S0[]{new S0(0)};
        return ref s_105;
    }
}
// Generated by Fuzzlyn v1.1 on 2018-09-07 05:47:06
// Seed: 2606324740322215447
// Reduced from 378.9 KiB to 0.6 KiB in 00:08:21
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public long F0;
    public sbyte F1;
}

struct S1
{
    public ulong F0;
    public S0 F1;
    public S1(ulong f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1[] s_11 = new S1[]{new S1(1)};
    public static void Main()
    {
        var vr5 = new S1(0);
        S1 vr14 = s_11[0];
        var vr9 = new S1(0);
        M80(vr5, M80(vr14, vr9));
    }

    static ref S1 M80(S1 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        ref S1 vr15 = ref s_11[0];
        return ref vr15;
    }
}
// Generated by Fuzzlyn v1.1 on 2018-09-28 17:49:26
// Seed: 6554649965434080060
// Reduced from 300.7 KiB to 0.7 KiB in 00:07:20
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
}

struct S1
{
    public int F0;
    public S0 F8;
}

struct S2
{
    public bool F1;
    public uint F2;
    public int F4;
    public bool F5;
    public uint F6;
    public S2(bool f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S2[] s_12 = new S2[]{new S2(true)};
    public static void Main()
    {
        var vr7 = new S1();
        S2 vr12 = s_12[0];
        bool vr10 = M45(vr7, M39(vr12));
    }

    static ref S2 M39(S2 arg0)
    {
        arg0.F4 = arg0.F4++;
        return ref s_12[0];
    }

    static bool M45(S1 arg0, S2 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return arg1.F5;
    }
}
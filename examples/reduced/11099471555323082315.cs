// Generated by Fuzzlyn on 2018-07-06 11:12:42
// Seed: 11099471555323082315
// Reduced from 161.4 KiB to 0.3 KiB
// Debug: Outputs 210
// Release: Outputs 4294967250
struct S0
{
    public sbyte F1;
    public S0(sbyte f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S0 s_5;
    public static void Main()
    {
        s_5 = new S0(-46);
        var vr21 = (byte)(s_5.F1 / (long)1);
        uint vr22 = vr21;
        System.Console.WriteLine(vr22);
    }
}

// Generated by Fuzzlyn on 2018-06-25 12:56:57
// Seed: 10543318415066208534
// Reduced from 2.7 KiB to 0.3 KiB
// Debug: Outputs 41802
// Release: Outputs 4294943562
struct S0
{
    public short F1;
    public S0(short f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S0[] s_1;
    public static void Main()
    {
        s_1 = new S0[]{new S0(-23734)};
        uint vr1 = (ushort)(s_1[0].F1 ^ 0U);
        System.Console.WriteLine(vr1);
    }
}

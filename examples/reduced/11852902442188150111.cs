// Generated by Fuzzlyn on 2018-07-14 15:55:12
// Seed: 11852902442188150111
// Reduced from 40.5 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S1
{
    public long F0;
}

public class Program
{
    static uint[] s_1 = new uint[]{0};
    public static void Main()
    {
        var vr3 = new S1[][, ]{new S1[, ]{{new S1()}}};
        s_1[0] = (uint)((0 & vr3[0][0, 0].F0) - vr3[0][0, 0].F0);
    }
}
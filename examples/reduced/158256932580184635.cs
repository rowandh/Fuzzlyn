// Generated by Fuzzlyn on 2018-07-03 13:12:24
// Seed: 158256932580184635
// Reduced from 37.6 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public char F1;
    public ulong F8;
    public S0(ulong f8): this()
    {
        F8 = f8;
    }
}

public class Program
{
    static S0[, ] s_2 = new S0[, ]{{new S0(14749901913371269412UL)}};
    public static void Main()
    {
        char vr8 = s_2[0, 0].F1;
        long vr9 = (long)((byte)(vr8 & 0) % s_2[0, 0].F8);
    }
}
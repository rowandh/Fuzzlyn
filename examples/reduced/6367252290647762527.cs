// Generated by Fuzzlyn on 2018-07-15 21:22:02
// Seed: 6367252290647762527
// Reduced from 64.9 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long[][, ] s_1 = new long[][, ]{new long[, ]{{0}}};
    public static void Main()
    {
        bool vr24 = ('o' / ((0 & s_1[0][0, 0]) | 1)) <= 'o';
        s_1[0][0, 0] = s_1[0][0, 0];
    }
}

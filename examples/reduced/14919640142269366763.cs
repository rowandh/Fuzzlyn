// Generated by Fuzzlyn on 2018-07-16 11:06:28
// Seed: 14919640142269366763
// Reduced from 6.1 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long[, ] s_1 = new long[, ]{{0}};
    public static void Main()
    {
        ushort vr1 = default(ushort);
        sbyte vr2 = (sbyte)(s_1[0, 0] & vr1);
        s_1 = s_1;
        System.Console.WriteLine(vr2);
        System.Console.WriteLine(s_1[0, 0]);
    }
}
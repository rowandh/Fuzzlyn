// Generated by Fuzzlyn on 2018-07-21 09:27:54
// Seed: 7844155601780023370
// Reduced from 121.7 KiB to 0.3 KiB
// Debug: Outputs 65408
// Release: Outputs 4294967168
public class Program
{
    static sbyte s_13 = -128;
    static ulong s_28;
    static byte[, ] s_30 = new byte[, ]{{0}};
    public static void Main()
    {
        ushort vr23 = (ushort)(s_13 ^ s_30[0, 0]);
        s_28 = vr23;
        System.Console.WriteLine(s_28);
    }
}

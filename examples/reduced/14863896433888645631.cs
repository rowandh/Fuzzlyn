// Generated by Fuzzlyn on 2018-07-15 00:57:04
// Seed: 14863896433888645631
// Reduced from 27.0 KiB to 0.5 KiB
// Debug: Outputs 1
// Release: Outputs 0
public class Program
{
    static long s_2;
    static byte s_3;
    static sbyte s_6;
    public static void Main()
    {
        short vr14 = (short)((1 ^ (s_2 / (char)(((ulong)(0 & (M4() | s_6)) ^ s_3) | 1))) & s_6);
        ushort vr12 = (ushort)vr14;
        System.Console.WriteLine(vr12);
    }

    static ushort M4()
    {
        var vr5 = new ulong[, ][]{{new ulong[]{0}}};
        s_6 = 1;
        short vr8 = (short)s_2;
        ushort vr9 = (ushort)vr8;
        return vr9;
    }
}
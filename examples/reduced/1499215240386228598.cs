// Generated by Fuzzlyn on 2018-07-17 14:55:35
// Seed: 1499215240386228598
// Reduced from 108.6 KiB to 0.2 KiB
// Debug: Outputs 4294946868
// Release: Outputs 45108
public class Program
{
    static ulong s_18;
    static short s_22 = -20428;
    public static void Main()
    {
        short vr22 = s_22;
        var vr23 = (uint)vr22 / (s_18 | 1);
        System.Console.WriteLine(vr23);
    }
}
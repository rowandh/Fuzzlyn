// Generated by Fuzzlyn on 2018-07-07 18:24:26
// Seed: 12258904638897078081
// Reduced from 61.6 KiB to 0.2 KiB
// Debug: Outputs 65444
// Release: Outputs -92
public class Program
{
    static sbyte s_6 = -92;
    static ulong s_16;
    public static void Main()
    {
        char vr3 = (char)((int)(s_16 & 0) | s_6);
        System.Console.WriteLine((int)vr3);
    }
}

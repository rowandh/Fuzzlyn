// Generated by Fuzzlyn on 2018-06-30 01:01:12
// Seed: 10337641428482254218
// Reduced from 0.9 KiB to 0.2 KiB
// Debug: Outputs 93
// Release: Outputs -66
public class Program
{
    static short s_1 = -32702;
    public static void Main()
    {
        s_1 = (short)((ushort)(s_1 ^ 1U) % 107);
        System.Console.WriteLine(s_1);
    }
}

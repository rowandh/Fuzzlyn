// Generated by Fuzzlyn on 2018-07-14 17:21:25
// Seed: 15013387470677035027
// Reduced from 129.9 KiB to 0.2 KiB
// Debug: Outputs 65418
// Release: Outputs 4294967178
public class Program
{
    static sbyte s_4 = -118;
    public static void Main()
    {
        short vr37 = 0;
        ulong vr38 = (char)(vr37 ^ s_4);
        System.Console.WriteLine(vr38);
    }
}
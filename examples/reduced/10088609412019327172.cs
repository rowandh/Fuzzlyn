// Generated by Fuzzlyn on 2018-07-11 05:54:33
// Seed: 10088609412019327172
// Reduced from 4.4 KiB to 0.2 KiB
// Debug: Outputs 34125
// Release: Outputs 4294935885
public class Program
{
    static short s_1 = -31412;
    public static void Main()
    {
        ushort vr5 = (ushort)(1L ^ s_1);
        ulong vr3 = vr5;
        System.Console.WriteLine(vr3);
    }
}

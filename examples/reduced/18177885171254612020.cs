// Generated by Fuzzlyn on 2018-06-21 19:10:57
// Seed: 18177885171254612020
// Reduced from 27.1 KiB to 0.3 KiB
// Debug: Outputs 65460
// Release: Outputs 4294967220
class C0
{
    public sbyte F0;
    public ulong F6;
    public C0(sbyte f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static C0 s_1;
    public static void Main()
    {
        s_1 = new C0(-76);
        long vr4 = (ushort)((byte)(s_1.F6 & 0) ^ s_1.F0);
        System.Console.WriteLine(vr4);
    }
}

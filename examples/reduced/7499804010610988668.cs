// Generated by Fuzzlyn on 2018-07-27 00:10:56
// Seed: 7499804010610988668
// Reduced from 139.6 KiB to 0.4 KiB
// Debug: Outputs 4294940677
// Release: Outputs 1608488965
struct S0
{
    public ushort F1;
    public bool F3;
    public int F4;
    public bool F5;
    public int F7;
    public S0(int f7): this()
    {
        F7 = f7;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr59 = new S0(1608488965);
        short vr60 = (short)vr59.F7;
        var vr61 = (uint)vr60;
        System.Console.WriteLine(vr61);
    }
}

// Generated by Fuzzlyn on 2018-07-09 07:10:09
// Seed: 9014692770760573101
// Reduced from 66.4 KiB to 0.4 KiB
// Debug: Outputs 28650
// Release: Outputs 234
class C1
{
    public ushort F0;
    public byte F1;
    public C1(ushort f0)
    {
        F0 = f0;
    }
}

struct S2
{
    public C1 F2;
    public S2(C1 f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        S2 vr1 = new S2(new C1(28650));
        vr1.F2.F1 = (byte)vr1.F2.F0;
        vr1.F2.F0 = vr1.F2.F0;
        System.Console.WriteLine(vr1.F2.F0);
    }
}
// Generated by Fuzzlyn on 2018-06-20 16:52:13
// Seed: 17376638908347038278
// Reduced from 4.6 KiB to 0.6 KiB
// Debug: Outputs 10689
// Release: Outputs 0
struct S1
{
    public ushort F2;
    public short F4;
    public short F6;
    public short F7;
    public S1(ushort f2): this()
    {
        F2 = f2;
    }
}

struct S2
{
    public uint F0;
    public uint F1;
    public S1 F2;
    public S2(S1 f2): this()
    {
        F2 = f2;
    }
}

struct S3
{
    public S2 F0;
    public S3(S2 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S3 vr8 = new S3(new S2(new S1(10689)));
        long vr9 = vr8.F0.F2.F2;
        System.Console.WriteLine(vr9);
    }
}
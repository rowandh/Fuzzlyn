// Generated by Fuzzlyn v1.1 on 2018-08-05 02:40:11
// Seed: 9440607402495893386
// Reduced from 268.4 KiB to 0.6 KiB
// Debug: Outputs -2147483647
// Release: Outputs 0
struct S0
{
    public ushort F0;
    public long F1;
    public int F2;
    public sbyte F3;
    public int F5;
    public S0(int f5): this()
    {
        F5 = f5;
    }
}

struct S1
{
    public sbyte F0;
    public S0 F2;
    public S1(S0 f2): this()
    {
        F2 = f2;
    }
}

struct S3
{
    public S1 F0;
    public S3(S1 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S3 vr12 = new S3(new S1(new S0(-2147483647)));
        vr12.F0.F2.F2 = (vr12.F0.F2.F5 ^ 0);
        System.Console.WriteLine(vr12.F0.F2.F2);
    }
}

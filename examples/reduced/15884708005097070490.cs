// Generated by Fuzzlyn v1.1 on 2018-09-13 10:13:01
// Seed: 15884708005097070490
// Reduced from 276.3 KiB to 0.7 KiB in 00:03:36
// Debug: Outputs 0
// Release: Outputs -1528
class C0
{
    public uint F2;
    public uint F4;
}

class C1
{
    public C0 F3;
    public C0 F4;
    public short F5;
    public C1(C0 f3, C0 f4)
    {
        F3 = f3;
        F4 = f4;
    }
}

public class Program
{
    static C1[][] s_9 = new C1[][]{new C1[]{new C1(new C0(), new C0())}};
    static C1 s_12 = new C1(new C0(), new C0());
    public static void Main()
    {
        M49(-1);
    }

    static void M49(short arg0)
    {
        arg0 = s_9[0][0].F5;
        arg0 %= 32004;
        try
        {
            s_12.F3.F4 = s_12.F4.F2;
        }
        finally
        {
            System.Console.WriteLine(arg0);
        }
    }
}
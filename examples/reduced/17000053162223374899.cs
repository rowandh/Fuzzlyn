// Generated by Fuzzlyn on 2018-07-14 01:05:18
// Seed: 17000053162223374899
// Reduced from 29.6 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C2
{
    public long F0;
    public short F1;
    public ushort F2;
    public C2(short f1, ushort f2)
    {
        F1 = f1;
        F2 = f2;
    }
}

public class Program
{
    static C2 s_1;
    public static void Main()
    {
        s_1 = new C2(0, 40852);
        sbyte vr0 = (sbyte)(0 / ((char)(1L & (s_1.F2 + s_1.F1)) | 1));
    }
}
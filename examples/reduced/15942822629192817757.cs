// Generated by Fuzzlyn v1.1 on 2018-08-25 02:55:17
// Seed: 15942822629192817757
// Reduced from 15.0 KiB to 0.4 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
class C1
{
    public sbyte F0;
    public C1(sbyte f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static long s_1;
    static C1[][, ] s_6 = new C1[][, ]{new C1[, ]{{new C1(-1)}}};
    public static void Main()
    {
        ref long vr1 = ref s_1;
        ushort vr3 = (ushort)(0 ^ s_6[0][0, 0].F0);
        vr1 = vr3;
        System.Console.WriteLine(s_1);
    }
}
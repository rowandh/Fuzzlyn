// Generated by Fuzzlyn v1.1 on 2018-09-19 13:08:14
// Seed: 1764607727557855797
// Reduced from 154.0 KiB to 0.8 KiB in 00:02:34
// Debug: Outputs 3735438
// Release: Outputs 18446744073704898702
class C0
{
    public uint F0;
    public bool F5;
    public C0(uint f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static C0[][][] s_19 = new C0[][][]{new C0[][]{new C0[]{new C0(4294967295U)}}};
    public static void Main()
    {
        ulong vr4 = default(ulong);
        var vr2 = (sbyte)vr4;
        bool vr3 = M35(vr2);
    }

    static bool M35(sbyte arg0)
    {
        arg0 = (sbyte)(17790946877939252088UL + (ulong)(7253392402929945292L % (byte)s_19[0][0][0].F0));
        ulong var0 = (ulong)(arg0 * -32767);
        System.Console.WriteLine(var0);
        try
        {
            M50();
        }
        finally
        {
            arg0 = arg0++;
        }

        return s_19[0][0][0].F5;
    }

    static ulong M50()
    {
        return 0;
    }
}
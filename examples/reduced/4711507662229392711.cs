// Generated by Fuzzlyn on 2018-07-23 03:56:35
// Seed: 4711507662229392711
// Reduced from 31.7 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public uint F1;
    public short F4;
}

public class Program
{
    static C0[, ][, ] s_3 = new C0[, ][, ]{{new C0[, ]{{new C0()}}}};
    static short s_7;
    public static void Main()
    {
        char vr11 = (char)(s_3[0, 0][0, 0].F1 & 0);
        bool vr12 = 3403220900U > vr11;
        if (vr12)
        {
            s_3[0, 0][0, 0].F4 = s_7;
        }
        else
        {
        }
    }
}

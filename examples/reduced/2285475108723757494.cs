// Generated by Fuzzlyn on 2018-07-05 08:31:59
// Seed: 2285475108723757494
// Reduced from 27.5 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public sbyte F4;
    public int F6;
}

public class Program
{
    static C0[][, ] s_6 = new C0[][, ]{new C0[, ]{{new C0()}}};
    public static void Main()
    {
        long vr0 = (0 & s_6[0][0, 0].F6) % (-3351603651705318721L ^ s_6[0][0, 0].F4);
    }
}

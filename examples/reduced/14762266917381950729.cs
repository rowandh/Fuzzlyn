// Generated by Fuzzlyn on 2018-07-24 16:18:28
// Seed: 14762266917381950729
// Reduced from 203.8 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public byte F3;
}

public class Program
{
    static sbyte[, ] s_1 = new sbyte[, ]{{0}};
    public static void Main()
    {
        var vr8 = new C0();
        var vr9 = (0 % ((0 & s_1[0, 0]) | 1)) & M4(vr8, M3((char)s_1[0, 0], 0) < 0);
    }

    static ushort M3(char arg0, ushort arg4)
    {
        return arg4;
    }

    static byte M4(C0 arg5, bool arg6)
    {
        return arg5.F3;
    }
}
// Generated by Fuzzlyn on 2018-06-20 03:39:24
// Seed: 22217949152575578
// Reduced from 41.3 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ulong[,, ] s_1 = new ulong[,, ]{{{0}}};
    public static void Main()
    {
        var vr11 = (byte)(0 & s_1[0, 0, 0]);
        var vr12 = s_1[0, 0, 0];
        M18(vr11);
    }

    static int[][] M18(byte arg3)
    {
        return new int[][]{new int[]{0}, new int[]{0}, new int[]{0}, new int[]{0}, new int[]{0}};
    }
}
// Generated by Fuzzlyn v1.1 on 2018-10-03 12:08:42
// Seed: 14265457428495386440
// Reduced from 217.6 KiB to 0.5 KiB in 00:03:38
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
struct S1
{
    public byte F0;
    public bool F1;
    public short F3;
}

public class Program
{
    static S1[] s_4 = new S1[]{new S1()};
    public static void Main()
    {
        S1[] vr4 = s_4;
        var vr5 = (uint)((0 & vr4[0].F0) & vr4[0].F3);
        M76(vr5);
        System.Console.WriteLine(vr4[0].F1);
    }

    static int[][] M76(uint arg0)
    {
        return new int[][]{new int[]{0}, new int[]{0}, new int[]{0}, new int[]{0}, new int[]{0}, new int[]{0}, new int[]{1}};
    }
}

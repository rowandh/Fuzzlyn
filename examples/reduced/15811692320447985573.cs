// Generated by Fuzzlyn on 2018-07-12 05:49:57
// Seed: 15811692320447985573
// Reduced from 2.1 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs 2147483647
public class Program
{
    static int[] s_1;
    public static void Main()
    {
        s_1 = new int[]{2147483647};
        var vr10 = s_1[0];
        int vr11 = s_1[0];
        var vr12 = (char)vr11;
        System.Console.WriteLine((int)vr12);
    }
}

// Generated by Fuzzlyn on 2018-07-05 15:33:40
// Seed: 6270485056389908856
// Reduced from 30.0 KiB to 0.2 KiB
// Debug: Outputs 16386
// Release: Outputs -254
public class Program
{
    static byte[] s_2 = new byte[]{0};
    public static void Main()
    {
        s_2[0] = 254;
        byte vr18 = s_2[0];
        var vr22 = (0 - vr18) & 16415;
        System.Console.WriteLine((int)vr22);
    }
}

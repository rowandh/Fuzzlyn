// Generated by Fuzzlyn on 2018-07-09 03:58:21
// Seed: 16128002622247120719
// Reduced from 89.5 KiB to 0.3 KiB
// Debug: Outputs 161
// Release: Outputs -95
public class Program
{
    public static void Main()
    {
        M5(-97);
    }

    static sbyte M5(sbyte arg0)
    {
        var vr9 = arg0++;
        var vr18 = (byte)(arg0 ^ 1U);
        int vr37 = vr18;
        System.Console.WriteLine(vr37);
        return arg0;
    }
}

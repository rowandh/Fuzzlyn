// Generated by Fuzzlyn on 2018-07-05 20:05:59
// Seed: 3355854140629136044
// Reduced from 11.1 KiB to 0.2 KiB
// Debug: Outputs 2131820542
// Release: Outputs 65534
public class Program
{
    public static void Main()
    {
        ushort[] vr5 = new ushort[]{65534};
        var vr6 = 2131770854 | vr5[0];
        System.Console.WriteLine(vr6);
    }
}
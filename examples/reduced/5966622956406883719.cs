// Generated by Fuzzlyn on 2018-07-14 05:51:37
// Seed: 5966622956406883719
// Reduced from 4.7 KiB to 0.3 KiB
// Debug: Outputs 65471
// Release: Outputs 4294967231
public class Program
{
    static sbyte[, ] s_1 = new sbyte[, ]{{0}};
    public static void Main()
    {
        s_1[0, 0] = -65;
        var vr15 = (ushort)(s_1[0, 0] & s_1[0, 0]);
        ulong vr16 = vr15;
        System.Console.WriteLine(vr16);
    }
}
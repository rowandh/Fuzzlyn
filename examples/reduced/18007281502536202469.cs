// Generated by Fuzzlyn on 2018-07-04 01:23:54
// Seed: 18007281502536202469
// Reduced from 34.7 KiB to 0.2 KiB
// Debug: Outputs 65437
// Release: Outputs -99
public class Program
{
    public static void Main()
    {
        var vr14 = new sbyte[, ]{{-69}};
        char vr16 = (char)('&' ^ vr14[0, 0]);
        System.Console.WriteLine((int)vr16);
    }
}
// Generated by Fuzzlyn on 2018-07-05 18:38:25
// Seed: 6246316678310303053
// Reduced from 48.0 KiB to 0.2 KiB
// Debug: Outputs 58245
// Release: Outputs -7291
public class Program
{
    static short s_5;
    public static void Main()
    {
        s_5 = -7291;
        char vr15 = (char)(s_5 | 0U);
        System.Console.WriteLine((int)vr15);
    }
}

// Generated by Fuzzlyn on 2018-07-08 10:49:12
// Seed: 885996873900097051
// Reduced from 11.0 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static sbyte s_2;
    public static void Main()
    {
        char vr17 = M9();
        System.Console.WriteLine((int)vr17);
    }

    static char M9()
    {
        s_2 = -8;
        return (char)(s_2 | 15);
    }
}

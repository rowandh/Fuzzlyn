// Generated by Fuzzlyn on 2018-06-18 19:11:39
// Seed: 14315147043234756003
// Reduced from 14.1 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static bool[][][][, ] s_2 = new bool[][][][, ]{new bool[][][, ]{new bool[][, ]{new bool[, ]{{true}}}}};
    public static void Main()
    {
        bool vr1 = false;
        vr1 &= s_2[0][0][0][0, 0];
        s_2 = s_2;
        System.Console.WriteLine(vr1);
        System.Console.WriteLine(s_2[0][0][0][0, 0]);
    }
}
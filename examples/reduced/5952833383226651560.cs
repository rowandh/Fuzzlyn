// Generated by Fuzzlyn on 2018-06-30 18:26:10
// Seed: 5952833383226651560
// Reduced from 2.0 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    public static void Main()
    {
        var vr1 = new ulong[][, ]{new ulong[, ]{{0}}};
        M1('d', 0, vr1);
    }

    static bool M1(char arg1, uint arg2, ulong[][, ] arg3)
    {
        arg1 = (char)((arg2 * (0 & arg3[0][0, 0])) & 0);
        System.Console.WriteLine((int)arg1);
        System.Console.WriteLine(arg3[0][0, 0]);
        return false;
    }
}
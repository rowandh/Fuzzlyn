// Generated by Fuzzlyn on 2018-07-10 11:52:09
// Seed: 7575381783381069407
// Reduced from 5.3 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    public static void Main()
    {
        var vr3 = new uint[][, ]{new uint[, ]{{0}}};
        M1(vr3);
    }

    static short M1(uint[][, ] arg1)
    {
        ulong var0 = 0 & arg1[0][0, 0];
        System.Console.WriteLine(arg1[0][0, 0]);
        System.Console.WriteLine(var0);
        return 0;
    }
}
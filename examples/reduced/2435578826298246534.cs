// Generated by Fuzzlyn v1.1 on 2018-08-12 20:06:30
// Seed: 2435578826298246534
// Reduced from 23.8 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    public static void Main()
    {
        short vr27 = 0;
        var vr29 = (short)0;
        int[][, ] vr30 = M6(vr29, vr27);
        int vr31 = vr27 * vr30[0][0, 0];
        System.Console.WriteLine(vr30[0][0, 0]);
        System.Console.WriteLine(vr31);
    }

    static int[][, ] M6(short arg0, short arg1)
    {
        return new int[][, ]{new int[, ]{{0}}};
    }
}

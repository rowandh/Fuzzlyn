// Generated by Fuzzlyn v1.1 on 2018-10-01 17:44:16
// Seed: 14187645366899403467
// Reduced from 228.9 KiB to 0.4 KiB in 00:03:34
// Debug: Outputs 0
// Release: Outputs -2
public class Program
{
    public static void Main()
    {
        uint vr6 = default(uint);
        var vr3 = (short)vr6;
        M52(vr3);
    }

    static void M52(short arg1)
    {
        try
        {
            short var0 = arg1--;
        }
        finally
        {
            arg1 -= 0;
            arg1 /= -28414;
        }

        System.Console.WriteLine(arg1);
    }
}

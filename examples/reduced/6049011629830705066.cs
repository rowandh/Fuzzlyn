// Generated by Fuzzlyn v1.1 on 2018-09-29 09:22:57
// Seed: 6049011629830705066
// Reduced from 194.6 KiB to 0.8 KiB in 00:03:08
// Debug: Outputs 0
// Release: Outputs -97
public class Program
{
    static int s_35 = -1;
    static long s_44;
    static sbyte s_47;
    public static void Main()
    {
        var vr4 = (sbyte)s_35;
        ushort vr5 = (ushort)M67(vr4, 0);
    }

    static int M67(sbyte arg0, byte arg1)
    {
        long var3 = default(long);
        uint var10 = default(uint);
        arg0 = s_47;
        arg1 = 159;
        arg0 = (sbyte)(arg0 % arg1);
        long var8;
        try
        {
            System.Console.WriteLine(var10);
        }
        finally
        {
            try
            {
                var3 = s_44;
            }
            finally
            {
                var8 = var3;
            }
        }

        System.Console.WriteLine(var8);
        System.Console.WriteLine(arg0);
        return s_35;
    }
}

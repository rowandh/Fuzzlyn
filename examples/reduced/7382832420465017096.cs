// Generated by Fuzzlyn on 2018-07-08 10:08:53
// Seed: 7382832420465017096
// Reduced from 28.5 KiB to 0.3 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static char s_10 = 'j';
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        uint var0 = (uint)(0 % ((0 & (-9223372036854775808L % ((sbyte)(1499765629598741574UL * (char)(57896 - (3920540314U / (s_10 | 1)))) | 1))) | 1));
    }
}

// Generated by Fuzzlyn v1.1 on 2018-09-14 09:31:59
// Seed: 1757450840784021491
// Reduced from 5.7 KiB to 0.2 KiB in 00:00:12
// Debug: Runs successfully
// Release: Throws 'System.DivideByZeroException'
public class Program
{
    public static void Main()
    {
        sbyte[] vr0 = new sbyte[]{1};
        ushort vr1 = (ushort)((vr0[0] % vr0[0]) / ((-1 / vr0[0]) | 1));
    }
}

// Generated by Fuzzlyn on 2018-06-21 03:15:11
// Seed: 15264960098124685893
// Reduced from 0.7 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.DivideByZeroException'
public class Program
{
    public static void Main()
    {
        short[] vr0 = new short[]{1};
        vr0[0] = (short)((0 % vr0[0]) % (sbyte)(-10 / vr0[0]));
    }
}

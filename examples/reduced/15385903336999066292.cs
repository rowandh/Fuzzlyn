// Generated by Fuzzlyn on 2018-06-18 13:44:51
// Seed: 15385903336999066292
// Reduced from 48.2 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static short s_1;
    public static void Main()
    {
        s_1--;
        char vr41 = (char)M13();
        System.Console.WriteLine((int)vr41);
    }

    static ushort M13()
    {
        return (ushort)(1U * s_1);
    }
}

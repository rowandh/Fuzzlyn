// Generated by Fuzzlyn on 2018-06-28 00:38:33
// Seed: 7661667668308136046
// Reduced from 146.6 KiB to 0.3 KiB
// Debug: Outputs -24949
// Release: Outputs -27352
class C0
{
    public short F0;
}

public class Program
{
    static C0 s_3 = new C0();
    public static void Main()
    {
        s_3.F0 = (short)(s_3.F0 ^ 620822515);
        s_3.F0 = (short)(1663735080U % (char)(s_3.F0 | 0U));
        System.Console.WriteLine(s_3.F0);
    }
}

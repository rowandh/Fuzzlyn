// Generated by Fuzzlyn on 2018-07-16 13:16:44
// Seed: 4141145787718810258
// Reduced from 135.2 KiB to 0.2 KiB
// Debug: Outputs 65455
// Release: Outputs -81
public class Program
{
    static sbyte[][, ] s_19 = new sbyte[][, ]{new sbyte[, ]{{-115}}};
    public static void Main()
    {
        char vr33 = (char)(s_19[0][0, 0] | 53030);
        System.Console.WriteLine((int)vr33);
    }
}

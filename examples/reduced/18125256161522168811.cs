// Generated by Fuzzlyn on 2018-08-01 19:27:13
// Seed: 18125256161522168811
// Reduced from 1.9 KiB to 0.2 KiB
// Debug: Outputs 65329
// Release: Outputs -207
public class Program
{
    public static void Main()
    {
        var vr4 = new byte[]{0};
        vr4[0] = 219;
        char vr6 = (char)(vr4[0] ^ -22);
        System.Console.WriteLine((int)vr6);
    }
}
// Generated by Fuzzlyn v1.1 on 2018-08-16 08:41:55
// Seed: 12699397608272884435
// Reduced from 138.0 KiB to 0.5 KiB
// Debug: Outputs -93
// Release: Outputs 0
struct S0
{
    public byte F0;
    public bool F1;
    public byte F2;
}

struct S1
{
    public S0 F0;
    public sbyte F1;
    public S1(sbyte f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S1 s_18 = new S1(-93);
    static S1 s_54;
    public static void Main()
    {
        s_18.F0 = M52();
        System.Console.WriteLine(s_18.F1);
    }

    static S0 M52()
    {
        return s_54.F0;
    }
}
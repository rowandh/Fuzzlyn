// Generated by Fuzzlyn on 2018-06-28 01:42:59
// Seed: 4498927044307174003
// Reduced from 201.7 KiB to 0.3 KiB
// Debug: Outputs 0
// Release: Outputs 22
struct S0
{
    public bool F0;
}

struct S1
{
    public S0 F5;
    public byte F6;
}

public class Program
{
    static S1 s_19;
    public static void Main()
    {
        s_19.F5 = M77();
        System.Console.WriteLine(s_19.F6);
    }

    static S0 M77()
    {
        return new S0();
    }
}

// Generated by Fuzzlyn on 2018-06-19 13:20:24
// Seed: 6998310381800016300
// Reduced from 134.2 KiB to 0.3 KiB
// Debug: Outputs 0
// Release: Outputs 29861
struct S0
{
    public char F0;
}

struct S1
{
    public S0 F0;
    public short F1;
}

public class Program
{
    static S1 s_21;
    public static void Main()
    {
        s_21.F0 = M24();
        System.Console.WriteLine(s_21.F1);
    }

    static S0 M24()
    {
        return new S0();
    }
}

// Generated by Fuzzlyn on 2018-07-30 19:38:32
// Seed: 8534318989776049124
// Reduced from 103.6 KiB to 0.5 KiB
// Debug: 
// Release: 
struct S0
{
    public byte F0;
    public byte F1;
    public byte F2;
    public S0(byte f0): this()
    {
    }
}

struct S1
{
    public int F4;
    public S0 F5;
    public S0 F6;
}

struct S2
{
    public S1 F1;
}

public class Program
{
    public static void Main()
    {
        S2 vr34 = new S2();
        vr34.F1.F5 = M9();
        System.Console.WriteLine(vr34.F1.F6.F0);
    }

    static S0 M9()
    {
        return new S0(0);
    }
}
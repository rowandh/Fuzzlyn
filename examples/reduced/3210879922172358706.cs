// Generated by Fuzzlyn on 2018-07-26 17:17:30
// Seed: 3210879922172358706
// Reduced from 3.4 KiB to 0.3 KiB
// Debug: Outputs 206
// Release: Outputs 26574
class C1
{
    public ushort F2;
    public int F4;
    public C1(int f4)
    {
        F4 = f4;
    }
}

public class Program
{
    public static void Main()
    {
        C1 vr0 = new C1(-913610802);
        vr0.F2 = (ushort)(vr0.F4 & (byte)vr0.F4);
        System.Console.WriteLine(vr0.F2);
    }
}

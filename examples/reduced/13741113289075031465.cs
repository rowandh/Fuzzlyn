// Generated by Fuzzlyn on 2018-07-13 20:30:51
// Seed: 13741113289075031465
// Reduced from 49.5 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        var vr27 = new char[][, ]{new char[, ]{{'+'}}};
        var vr28 = new long[][, ]{new long[, ]{{0}}};
        long vr32 = (0 & vr27[0][0, 0]) | vr27[0][0, 0];
        vr28[0][0, 0] -= vr32;
    }
}

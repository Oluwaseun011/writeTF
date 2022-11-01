internal class Program
{
    private static void Main(string[] args)
    {
        int y = 0;
        int z = 0;
        Sum(9, 7, ref y, ref z );
        System.Console.WriteLine(y + " " + z);
        
    }

    public static void Sum(in int a, in int b, ref int c, ref int d)
    {
        c = a + b;
        d = a * b;
    }
}
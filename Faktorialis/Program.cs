using System.Numerics;

System.Console.Write("Adjon egy egsz szamot: n = ");
bool joe = int.TryParse(Console.ReadLine(), out int n) && n >= 0;

if (joe)
{
    BigInteger fakt = 1;
    for (int i = 2; i <= n; i++)
    {
        fakt *= i;
    }
    System.Console.WriteLine($"n faktorialisa: fakt = {fakt}");
}
else
{
    System.Console.WriteLine("fakt = ervenytelen");
}


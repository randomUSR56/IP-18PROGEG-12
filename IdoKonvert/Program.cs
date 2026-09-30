System.Console.WriteLine("Kérem adja meg az aktuális órát és percet!");

System.Console.Write("Óra(0-23): ");
//DzsóO
bool joeO = int.TryParse(Console.ReadLine(), out int o);

//DzsóP
System.Console.Write("Perc(0-59): ");
bool joeP = int.TryParse(Console.ReadLine(), out int p);

//Mert 1 ora * 60 az 60 perc
const int VALTOSZAM = 60;

if ((joeO && o >= 0 && o <= 23) && (joeP && p >= 0 && p <= 59))
{
    System.Console.WriteLine($"A mai napból eltelt idő: {o*VALTOSZAM+p} perc.");
    return;
}
else
{
    System.Console.WriteLine("érvénytelen");
    return;
}

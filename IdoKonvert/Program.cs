System.Console.WriteLine("Kérem adja meg az aktuális órát és percet!");

System.Console.Write("Óra(0-23): ");
//DzsóO
bool joeO = int.TryParse(Console.ReadLine(), out int o);

//DzsóP
System.Console.Write("Perc(0-59): ");
bool joeP = int.TryParse(Console.ReadLine(), out int p);

int HanyPercTeltEl(int ora, int perc)
{
    //Mert 1 ora * 60 az 60 perc
    const int VALTOSZAM= 60;
    return ora*VALTOSZAM+perc;
}

if ((joeO && o >= 0 && o <= 23) && (joeP && p >= 0 && p <= 59))
{
    System.Console.WriteLine($"A mai napból eltelt idő: {HanyPercTeltEl(o, p)} perc.");
    return;
}
else
{
    System.Console.WriteLine("érvénytelen");
    return;
}

System.Console.WriteLine("Kérem adja meg az aktuális órát és percet!");

System.Console.Write("Óra(0-23): ");
//DzsóO
bool joeO = int.TryParse(Console.ReadLine(), out int o);

//DzsóP
System.Console.Write("\nPerc(0-59): ");
bool joeP = int.TryParse(Console.ReadLine(), out int p);

//Dzsó
bool joe;

if ((joeO && o > 0 && o < 23) && (joeP && p > 0 && p < 23))
{
    joe = true;
}
else
{
    joe = false;
}

int HanyPercTeltEl(int ora, int perc)
{
    //Mert 1 ora * 60 az 60 perc
    const int VALTOSZAM= 60;
    return ora*VALTOSZAM+perc;
}

if (joe)
{
 System.Console.WriteLine($"A mai napból eltelt idő: {HanyPercTeltEl(o, p)} perc.");   
}
else
{
    System.Console.WriteLine("Érvénytelen");
}

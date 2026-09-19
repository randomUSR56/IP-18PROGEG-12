// Felfedeztem, hogy letezik BigInteger ami jobban eleget tesz a specifikacionak.
// Int-tipusnal kene egy felso limit a specifikacionak mert kb 12!-nel kimerul.
// A legnagyobb beepitett fix meretu numerikus valtozonk c#-ban a 64 bites double amely 170!-nel fogy el es pontatlan is addigra (22!-ig pontos).
// Igy tehat a BigInteger-t valasztottam az eredmenyt tarolo valtozo tipusaul.
// A BigInteger azert kulonleges mert az egyetlen hard limitje az, hogy mennyi RAM-mal rendelkezik az adott szamitogep amin futtatjuk.
// Egy dinamikusan novekvo Integer-tomb mukodteti: a tomb minden egyes eleme egy hatalmas "szamjegy" amelyek mind a reszet kepezik a vegeredmenynek.
// Errol tobbet olvasni a https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger?view=net-10.0 hivatkozason lehet.
// Nekem is ujdonsag es most hasznalom eloszor de igen frappansnak tunt, gondoltam hasznositom a megoldasban.
// Igy ennek koszonhetoen az "Ef: -" elofeltetel matematikailag korrekt marad a kod implementacioban.
// Barmilyen termeszetes n szamnak meghatarozhato a faktorialisa
// Megjegyzes: a speci editorban a termeszetes halmaz tartalmazza a nullat kulonben egesz halmazt alkalmaztam volna
// a megfelelo elofeltetellel (n>=0)
using System.Numerics;

System.Console.Write("Adjon egy termeszetes (0;1;2;..n) szamot: n = ");
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


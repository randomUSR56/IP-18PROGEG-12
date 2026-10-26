// https://github.com/randomUSR56/IP-18PROGEG-12/blob/Loverseny/Loverseny/Program.cs
// deklaralas
int n;
int[] lovak;
int[] m;

// beolvasas
Beolvasas(out n, out lovak);

// feldolgozas
Feldolgozas(n, lovak, out m);

// kiiratas
Kiiras(m);

int EllBeolv(string uzenet, string hibauzenet)
{
    Console.Error.Write(uzenet);
    bool joe;
    int x;
    do
    {
        joe = int.TryParse(Console.ReadLine(), out x);
        if (!joe)
        {
            Console.Error.WriteLine(hibauzenet);
        }
    }
    while (!joe);
    return x;
}

void Beolvasas(out int n, out int[] lovak)
{
    n = EllBeolv("Kérem a lovak erősségeinek mértékét: ", "Hibás adat! Kérem egész számot adjon meg!");
    lovak = new int[n];
    for (int i = 0; i < n; i++)
    {
        lovak[i] = EllBeolv($"Kérem a(z) {i + 1}. ló erősségét: ", "Hibás adat! Kérem egész számot adjon meg!");
    }
}

int buntetes(int erosseg)
{
    int meter = 0;
    if (erosseg <= 50)
    {
        meter = 0;
    }
    else if (erosseg > 90)
    {
        meter = 45;
    }
    else if (51 <= erosseg && erosseg <= 90)
    {
        meter = ((erosseg - 50 + 4)/5) * 5;
    }
    return meter;
}

void Feldolgozas(int n, int[] lovak, out int[] m)
{
    m = new int[n];
    for (int i = 1; i <= n; i++)
    {
        m[i-1] = buntetes(lovak[i-1]);
    }
}

void Kiiras(int[] meter)
{
    Console.Error.WriteLine("A lovak büntetései méterben: ");
    for (int i = 0; i < meter.Length; i++)
    {
        Console.WriteLine(meter[i]);
    }
}

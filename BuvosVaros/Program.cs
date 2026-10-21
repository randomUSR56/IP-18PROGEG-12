// deklaralas
int n;
int[] meresek;
double[] jav;

// beolvasas
Beolvasas(out n, out meresek);

// feldolgozas
Feldolgozas(n, meresek, out jav);

// kiiras
Kiiras(jav);

int EllBeolv(string beker, string hiba)
{
    Console.Write(beker);
    bool joe;
    int x;
    do
    {
        joe = int.TryParse(Console.ReadLine(), out x);
        if (!joe)
        {
            Console.WriteLine(hiba);
        }
    }
    while (!joe);
    return x;
}

double Javitas(int meres)
{
    double javitott;

    if (meres < 0)
    {
        javitott = -(double)meres / 2;
    }
    else
    {
        javitott = meres;
    }
    return javitott;
}

void Beolvasas(out int n, out int[] meresek)
{
    n = EllBeolv("Kérem a mérések számát: ", "Hibás adat! Kérem egész számot adjon meg!");
    meresek = new int[n];
    for (int i = 0; i < n; i++)
    {
        meresek[i] = EllBeolv($"Kérem a(z) {i + 1}. mérést: ", "Hibás adat! Kérem egész számot adjon meg!");
    }
}

void Feldolgozas(int n, int[] meresek, out double[] jav)
{
    jav = new double[n];
    for (int i = 0; i < n; i++) // i=1 mert illeszkednie kell a stukinak és UTÁNA toljuk el az indexek amikor hivatkozunk rá és használjuk
    {
        jav[i] = Javitas(meresek[i]);
    }
}

void Kiiras(double[] jav)
{
    Console.WriteLine($"A javított mérések: {string.Join(' ', jav)}");
}
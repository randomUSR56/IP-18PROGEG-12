// deklaralas
int n;
int[] meresek;
double[] jav;

// beolvasas
n = EllBeolv("Adja meg a mérések számát: ", "Hibás adat! Kérem, adjon meg egy egész számot 1-100 között.");
meresek = new int[n];
jav = new double[n];
for (int i = 0; i < n; i++)
{
    meresek[i] = EllBeolv($"Adja meg a(z) {i + 1}. mérést: ", "Hibás adat! Nem egész szám.");
}

// feldolgozas
for (int i = 1; i <= n; i++) // i=1 mert illeszkednie kell a stukinak és UTÁNA toljuk el az indexek amikor hivatkozunk rá és használjuk
{
    jav[i-1] = Javitas(meresek[i-1]);
}
// kiiras
Console.WriteLine($"A javított mérések: {string.Join(" ", jav)}");

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
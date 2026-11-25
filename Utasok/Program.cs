// deklaralas
int n;
int[] utasok;

int gyogyo;

// beolvasas
beolvas(out n, out utasok);

// feldolgozas
feldolgozas(n, utasok, out gyogyo);

// kiiras
Console.WriteLine($"A leghamarabb visszatérő utas útlevélszáma: {gyogyo}");

(bool van, int ind) utaskozt(int n, int[] utasok, int i)
{
    int ind = i + 1;
    while (ind <= 2 * n && !(utasok[i - 1] == utasok[ind - 1]))
    {
        ind++;
    }
    bool van = ind <= 2 * n;
    return (van, ind);
}

void feldolgozas(int n, int[] utasok, out int gyogyo)
{
    bool van = false;
    int minert = 0;
    int gyogyoind = 0;

    for (int i = 1; i <= 2*n-1; i++)
    {
        if (!van && utaskozt(n, utasok, i).van)
        {
            van = true;
            gyogyoind = i;
            minert = utaskozt(n, utasok, i).ind - i - 1;
        }
        else if (van && utaskozt(n, utasok, i).van)
        {
            if (minert > utaskozt(n, utasok, i).ind - i - 1)
            {
                gyogyoind = i;
                minert = utaskozt(n, utasok, i).ind - i - 1;
            }
        }
    }

    if (van)
    {
        gyogyo = utasok[gyogyoind - 1];
    }
    else
    {
        gyogyo = 0;
    }
}

void beolvas(out int n, out int[] utasok)
{
    Console.Write("Adja meg az utasok szamat: ");
    bool joe;
    do
    {
        joe = int.TryParse(Console.ReadLine(), out n) && n > 1;
        if (!joe)
        {
            Console.WriteLine("hiba, az utasok száma 1-nél nagyobb egész szám kell legyen!");
        }
    }
    while (!joe);

    utasok = new int[2*n];
    for (int i = 0; i < 2*n; i++)
    {
        Console.Write($"Adja meg az {i + 1}. utas útlevélszámát: ");
        utasok[i] = int.Parse(Console.ReadLine());
    }
}
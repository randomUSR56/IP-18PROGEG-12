// deklaralas
int n;
int m;
int[,] kav;
int maxkav;
int maxssz;

// beolvasas
beolvasas(out n, out m, out kav);

// feldolgozas
feldolgozas(n, out maxssz, out maxkav);

// kiiras
kiiras("A következő napon gyűjtötték a legtöbb kavicsot a vidrák: ", maxssz);

int napikavics(int i)
{
    int s;
    int j;

    s = 0;
    for (j = 1; j <= m; j++)
    {
        s += kav[i-1, j-1];
    }
    return s;
}

void feldolgozas(int n, out int maxssz, out int maxkav)
{
    int i;
    maxssz = 1;
    maxkav = napikavics(1);
    for (i = 2; i <= n; i++)
    {
        if (maxkav < napikavics(i))
        {
            maxssz = i;
            maxkav = napikavics(i);
        }
    }
}

void kiiras(string message, int maxssz)
{
    Console.WriteLine(message + maxssz);
}

void beolvasas(out int n, out int m, out int[,] kav)
{
    bool joen;
    bool joem;
    do
    {
        Console.Write("Adja meg a napok számát és vidrák számát (szóközzel elválasztva): ");
        string[] input = Console.ReadLine().Split(' ');
        joen = int.TryParse(input[0], out n) && (n >= 1 && n <= 100);
        joem = int.TryParse(input[1], out m) && (m >= 1 && m <= 10);
        if (!joen || !joem)
        {
            Console.WriteLine("Kérem adjon meg egy 1 és 100 közötti számot a napok számához és egy 1 és 10 közötti számot a vidrák számához.");
        }
    }
    while (!joen || !joem);

    kav = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Adja meg a {i + 1}. nap gyűjtött kavicsainak számát szóközzel elválasztva: ");
        string[] sor = Console.ReadLine().Split(' ');
        for (int j = 0; j < m; j++)
        {
            kav[i, j] = Convert.ToInt32(sor[j]);
        }
    }
}
// deklaralas
int n, m, ind, hely;
bool van;

int[,] madarak;

// beolvasas
beolvasas(out n, out m, out madarak);

// feldolgozas
feldolgozas(n, m, madarak, out hely);

// kiiras
kiiras(hely);

void kiiras(int hely)
{
    Console.WriteLine(hely);
}

bool mindnulla(int i, int n, int[,] madarak)
{
    int j = 1;
    while (j <= n && madarak[i-1, j-1] == 0)
    {
        j++;
    }
    bool mind = j > n;
    return mind;
}

void feldolgozas(int n, int m, int[,] madarak, out int hely)
{
    int ind = 1;
    while (ind <= n && !mindnulla(ind, n, madarak))
    {
        ind++;
    }
    bool van = ind <= n;

    if (van)
    {
        hely = ind;
    }
    else
    {
        hely = 0;
    }
}

void beolvasas(out int n, out int m, out int[,] madarak)
{
    string[] sor = Console.ReadLine().Split();
    int.TryParse(sor[0], out m);
    int.TryParse(sor[1], out n);
    madarak = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        sor = Console.ReadLine().Split();
        for (int j = 0; j < n; j++)
        {
            int.TryParse(sor[j], out madarak[i, j]);
        }
    }
}
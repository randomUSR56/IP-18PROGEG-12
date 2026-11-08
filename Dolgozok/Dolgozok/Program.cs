// deklaralas
int n, db;
int[] dol;

// beolvasas
beolvasas(out n, out dol);

// feldolgozas
feldolgozas(out db, n);

// kiiratas
kiiratas(db);

void beolvasas(out int n, out int[] dol)
{
    n = EllBeolv("Kérem a dolgozók számát: \n", "Hibás adat! Kérem egész számot adjon meg, 1 és 100 között!\n");
    
    dol = new int[n];
    for (int i = 0; i < n; i++)
    {
        System.Console.Error.WriteLine($"Kérem a(z) {i + 1}. dolgozó életkorát és fizetését szóközzel elválasztva: ");
        string[] parts = Console.ReadLine().Split(" ");
        dol[i] = EllBeolv($"", "Hibás adat! Kérem az életkornak egész számot adjon meg, 1 és 100 között!\n");
    }
}

// azon ritka eset, hogy sikerült előfeltételt ellenőrizni ellenőrzött beolvasással mindkét inputra mert ugyanaz az előfeltételük. (1 <= x <= 100)
int EllBeolv(string prompt, string error_msg)
{
    Console.Error.Write(prompt);
    bool joe;
    int x;
    do
    {
        joe = int.TryParse(Console.ReadLine(), out x);
        if (!joe)
        {
            Console.Error.WriteLine(error_msg);
        }
    }
    while (!joe);
    return x;
}

void feldolgozas(out int db, int n)
{
    db = 0;
    for (int i = 1; i < n; i++)
    {
        if (!tejleves(i-1))
        {
            db = db + 1;
        }
    }
}
void kiiratas(int output)
{
    System.Console.Error.Write("\nA különböző életkorú dolgozók száma: ");
    System.Console.Write($"{output}\n");
}

bool tejleves(int i)
{
    int j;
    bool van;

    j = 1;
    while (j <= i-1 && !(dol[i] == dol[j]))
    {
        j = j+1;
    }
    van = j <= i-1;
    
    return van;
}

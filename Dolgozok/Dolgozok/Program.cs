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
    n = EllBeolv("Kérem a dolgozók számát: \n", "Hibás adat! Kérem egy egész számot adjon meg, 1 és 100 között!\n", 1)[0];
    
    dol = new int[n];
    for (int i = 0; i < n; i++)
    {
        int[] parts = EllBeolv($"Kérem a(z) {i + 1}. dolgozó életkorát és fizetését szóközzel elválasztva: \n", "Hibás adat! Kérem az életkort (1 és 100 között) és a fizetést egész számként adja meg, szóközzel elválasztva!\n", 2);
        dol[i] = parts[0];
    }
}

// azon ritka eset, hogy sikerült előfeltételt ellenőrizni ellenőrzött beolvasással mindkét inputra mert ugyanaz az előfeltételük. (1 <= x <= 100)
// az első értékre (n vagy életkor) vonatkozik a korlát, a fizetésre nem.
int[] EllBeolv(string prompt, string error_msg, int count)
{
    Console.Error.Write(prompt);
    bool joe;
    int[] x = new int[count];
    do
    {
        string[] parts = Console.ReadLine().Split(' '); // split mert kénytelenek vagyunk feldolgozni minden inputban éerkező adatot még ha nincs is rá szükségünk
        joe = parts.Length == count;
        for (int k = 0; joe && k < count; k++)
        {
            // ha parts 0. eleme van akkor futtatjuk az Ef. checket, amennyiben nem a 0. elemről van szó (se nem n, se nem életkor) akkor a (k>0 ||) rövidrezár és nem kerül az Ef. check kiértékelésre.
            joe = int.TryParse(parts[k], out x[k]) && (k > 0 || (1 <= x[k] && x[k] <= 100));
        }
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
    // mentes de azért rakok egyet mert tényleg aranyosak: 🦦
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

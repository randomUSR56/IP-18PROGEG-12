// deklaralas
int n;
int[] oh;
int ofsz;

// beolvasas
Console.Error.Write("Adja meg az orhelyek szamat: ");
int.TryParse(Console.ReadLine(), out n);
oh = new int[n];
Console.Error.WriteLine("Adja meg az orhelyek vedettseget egyesevel (0 vagy 1):");
for (int i = 0; i < n; i++)
{
    Console.Error.Write($"{i+1}. orhely vedettsege: ");
    int.TryParse(Console.ReadLine(), out oh[i]);
}

// feldolgozas
ofsz = 0;
for (int i = 1; i < n; i++)
{
    if (oh[i-1]==1 || oh[i]==1)
    {
        ofsz = ofsz + 1;
    }
}

// kiiras
Console.Error.Write("Orzott falak szama: ");
Console.Write(ofsz + "\n");
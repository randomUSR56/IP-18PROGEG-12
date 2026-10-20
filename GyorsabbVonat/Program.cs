// deklaralas
int n;
int[] mido;
bool van;
int ind;

// beolvasas
ind = 0;    // nyig a fordito ha nem adunk a valtozonak erteket csak a ciklusban
Console.Error.Write("adja meg a vonatok szamat: ");
int.TryParse(Console.ReadLine(), out n);
Console.Error.Write("\nadja meg a vonatok menetidejet!");
mido = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Error.Write($"\n{(i + 1)}. vonat menetideje: ");
    int.TryParse(Console.ReadLine(), out mido[i]);
}
Console.Error.WriteLine();

// feldolgozas
van = false;
for (int i = 1; (!van)&&(i < n);)
{
    van = (mido[i - 1] > mido[i]);
    ind = i;
    i=i+1;
}
if (!van)
{
    ind = -1;
}

// kiiras
Console.Error.Write("\nVonat sorszama: ");
Console.Write((ind + 1) + "\n");
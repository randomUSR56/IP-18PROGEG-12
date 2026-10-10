// deklaralas
bool joe;

int n;
int[] laborcica;
int porcica;

// beolvasas
Console.Clear();
do
{
    System.Console.Write("Adja meg, hany laborban jart: ");
    joe = int.TryParse(Console.ReadLine(), out n) && n>1;

    if (!joe)
    {
        System.Console.WriteLine("Hibas adat, adjon meg egy 1-nel nagyobb egesz szamot!");
    }
} while (!joe);

laborcica = new int[n];
System.Console.WriteLine("\nAdja meg, mennyi porcicat talalt laboronkent!");
for (int i = 0; i < n; i++)
{
    do
    {
        System.Console.Write($"{i+1}. laborban talalt porcicak szama: ");
        int.TryParse(Console.ReadLine(), out laborcica[i]);

        if (!joe)
        {
            System.Console.WriteLine("Hibas adat, adjon meg egy egesz szamot!");
        }
    } while (!joe);
}

// feldolgozas
porcica = 0;
for (int i = 0; i < n; i++)
{
    if (laborcica[i] >= 10)
    {
        porcica = porcica + 1;
    }
}

// kiiras
System.Console.WriteLine($"\nEnnyi laborban volt tobb mint 10 porcica: {porcica} db");
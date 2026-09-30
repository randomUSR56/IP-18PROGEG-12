string jog;
const int MINIMUM_ELETKOR = 0;
const int MAXIMUM_ELETKOR = 150;
const int FELNOTT_KOR = 18;
const int NYUGDIJAS_KOR = 60;
// Megszüntettem a nemJarKedvezmeny változót.

System.Console.Write("Adja meg az eletkorat: ");
bool joe = int.TryParse(Console.ReadLine(), out int kor) && kor >= MINIMUM_ELETKOR && kor <= MAXIMUM_ELETKOR;

// Külön szedtem a feldolgozástól és megállítottam a futást return-nel amennyiben nem joe.
if (!joe)
{
    Console.WriteLine("ervenytelen");
    return;
}

//  Stuki
//-----------------------------------------------
if (kor >= FELNOTT_KOR && kor < NYUGDIJAS_KOR)
{
    jog = "nem jogosult";
}
else
{
    jog = "jogosult";
}
//-----------------------------------------------
//  Stuki vége

System.Console.WriteLine(jog);

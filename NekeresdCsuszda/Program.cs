int kor;
string jog;
bool joe;
bool nemJarKedvezmeny;
const int MINIMUM_ELETKOR = 0;
const int MAXIMUM_ELETKOR = 150;
const int FELNOTT_KOR = 18;
const int NYUGDIJAS_KOR = 60;

System.Console.Write("Adja meg az eletkorat: ");
joe = int.TryParse(Console.ReadLine(), out kor) && kor >= MINIMUM_ELETKOR && kor <= MAXIMUM_ELETKOR;

nemJarKedvezmeny = kor >= FELNOTT_KOR && kor < NYUGDIJAS_KOR;

if (!joe)
{
    jog = "ervenytelen";
}
else if (nemJarKedvezmeny)
{
    jog = "nem jogosult";
}
else
{
    jog = "jogosult";
}

System.Console.WriteLine(jog);

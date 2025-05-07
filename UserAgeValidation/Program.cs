//küsib kasutaja vanust
//kui vanus < 13, kuva
//"Te olete Instagram-i jaoks liiga noor"
//muul juhul
//kuva "Tere tulemast Instagram-i"

string vanus;
int vanusNR = 0;


Console.WriteLine("Sisestage oma vanus:");

vanus = Console.ReadLine();

bool onVanusnr = int.TryParse(vanus, out vanusNR); //kas input on number [true/false]

if (onVanusnr)
{
    if (vanusNR >= 13) //kas kasutaja on vanem kui 13(k.a)
    { Console.WriteLine("Tere tulemast Instagram-i!"); }
    else { Console.WriteLine("Te olete Instagram-i jaoks liiga noor!"); } //kasutaja on noorem kui 13
}
else { Console.WriteLine("Sisestage korrektne vanus!"); } //kui inputis oli midagi peale numbrite
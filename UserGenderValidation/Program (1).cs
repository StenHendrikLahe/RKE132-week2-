//küsib kasutaja soo m/n
//küsib kasutaja perekonnanime
//lähtudes valikutest, tervitab järgmiselt
//"Tere, Hr. [perekonnanimi]" / "Tere, Pr. [perekonnanimi]"

char sugu;
string perekonnanimi;

Console.WriteLine("Palun valige oma sugu (m/n):");
sugu = char.Parse(Console.ReadLine());

Console.WriteLine("Palun sisestage oma perekonnanimi:");
perekonnanimi = Console.ReadLine();

if (sugu == 'm')
    { Console.WriteLine($"Tere Hr. {perekonnanimi}"); }
else  if (sugu == 'n')
    { Console.WriteLine($"Tere Pr. {perekonnanimi}"); }
else { Console.WriteLine($"Tere, {perekonnanimi}"); }
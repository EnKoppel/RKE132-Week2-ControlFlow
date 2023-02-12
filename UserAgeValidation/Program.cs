//rakendus küsib kasutajal valida tema sugu (M/F)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat jägmiselt:
//"Welcom, Mr. [kasutaja perekonnanime] / Ms. [kasutaja perekonnanime]"

Console.WriteLine("Please, select your gender (m/f):");
char userGender = char.Parse(Console.ReadLine());//loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your lastname:");

string userLastName= Console.ReadLine();

if(userGender=='m')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if(userGender=='f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else 
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
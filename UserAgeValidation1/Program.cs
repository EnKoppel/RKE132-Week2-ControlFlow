//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagramm"
Console.WriteLine("Enter your age");
int userAge = Int32.Parse(Console.ReadLine());
if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram");
}

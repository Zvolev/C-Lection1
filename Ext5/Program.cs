Console.Write("Здрасте, как вас зовут? ");
string nameuser = Console.ReadLine();

if (nameuser.ToLower() == "маша")
{
    Console.Write("Привет, Мария!");
}
else 
{
    Console.Write("Привет, ");
    Console.Write(nameuser);
}
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username == "Серёжа")
{
    Console.WriteLine("Ура, это же Серёжа");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
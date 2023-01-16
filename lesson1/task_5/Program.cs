Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username == "Екатерина Юрьевна")
{
    Console.Write("Екатерина Юрьевна, выздоравливайте!");
}
else 
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}
// 

Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine( );
void Proverka (string num)
{
    if (num [0] == num [4] && num [1] == num [3])
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
        Console.WriteLine($"Число {num} не является палиндромом");
}
if  (num.Length == 5)
{
    Proverka (num);
}
else Console.WriteLine("Введите пятизначное число");
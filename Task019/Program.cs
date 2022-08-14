// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine( ));
string str_num = num.ToString();
char digit1 = str_num[0];
char digit2 = str_num[1];
char digit4 = str_num[3];
char digit5 = str_num[4];
if (digit1 == digit5 && digit2 == digit4)
Console.WriteLine($"Число {num} является палиндромом");
else
Console.WriteLine($"Число {num} не является палиндромом");


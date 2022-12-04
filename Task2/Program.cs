Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int numA = num/10;

if (num < 100) Console.WriteLine("У числа нет третьей цифры");

else
{
while (num > 999)  num = num/10;
}

int result = num%10;
Console.WriteLine($"{result}");
Console.WriteLine("Введите номер дня недели");
int daynum = Convert.ToInt32(Console.ReadLine());
if (daynum > 7) Console.WriteLine("Неверное значение");

else
{
    if (daynum < 6) Console.WriteLine("Это рабочий день");

    else
    {
        Console.WriteLine("Выходной");
    }
}
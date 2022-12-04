int num = new Random().Next(100, 1000);
Console.WriteLine($"{num}");
int numA = num/10;
int numB = numA - numA/10*10;
Console.WriteLine($"{numB}");
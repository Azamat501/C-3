// See https://aka.ms/new-console-template for more information
int a;
Console.WriteLine("Введите числ:");
a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет ");
}

Console.ReadKey();



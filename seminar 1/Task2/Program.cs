Console.WriteLine("ВВедите первое число ");
int a = Convert.ToInt32(Console.ReadLine( ));
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine( ));
Console.WriteLine("Введите второе число: ");
int c = Convert.ToInt32(Console.ReadLine( ));
if (a<b)
if (b>c)
{
    System.Console.WriteLine($"{b}=max");
}
if (a<b)
if (b<c)
{
    System.Console.WriteLine($"{c}=max");
}
if (a>b)
if (a<c)
{
    System.Console.WriteLine($"{c}=max");
}
if (a>b)
if (a>c)
{
    System.Console.WriteLine($"{a}=max");
}

if (a<b)
if (b>c)
{
    System.Console.WriteLine($"{b}=max");
}
else
{
    System.Console.WriteLine($"{c}=max");
}
if (a>b)
if (a<c)
{
    System.Console.WriteLine($"{c}=max");
}
else
{
    System.Console.WriteLine($"{a}=max");
}
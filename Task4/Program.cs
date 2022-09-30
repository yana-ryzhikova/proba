Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine( ));
int count = 2;
while (count<=value)
if (count%2==0)
{
  System.Console.WriteLine(count); 
  count=count+2;
}

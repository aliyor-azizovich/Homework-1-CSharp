Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if ( a < b)
{
    Console.Write("Максимальное число: ");
    Console.Write(b);
}
else 
{
    Console.Write("Максимальное число: ");
    Console.Write(a);
}

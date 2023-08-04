Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if ( a > b && a > c)
{
    max = a;
}
else if (b > c)
    {    
        max = b;
    }
    else 
    {
        max = c;
    }
Console.Write("Максимальное число: " + max);
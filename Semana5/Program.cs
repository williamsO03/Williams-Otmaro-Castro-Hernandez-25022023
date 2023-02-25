string? numero1;
string? numero2;

Console.WriteLine("Ingresa el primer valor");
numero1 = Console.ReadLine();

Console.WriteLine("Ingresa el segundo valor");
numero2 = Console.ReadLine();

for(int i = Int32.Parse(numero1); i <= Int32.Parse(numero2); i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine("Numero par: " + i);
    }
}
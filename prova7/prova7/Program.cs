Console.WriteLine("Digite um número inicial:");
int numeroinicial = int.Parse(Console.ReadLine());

Console.WriteLine("Agora digite um número final:");
int numerofinal = int.Parse(Console.ReadLine());

if (numeroinicial > numerofinal)
{
    Console.WriteLine("O número inicial não pode ser menor do que o final");
    int temp = numeroinicial;
    numeroinicial = numerofinal;
    numerofinal = temp;
}
Console.WriteLine();

for (int i = numeroinicial; i <= numerofinal; i++)
{
    Console.WriteLine($"Tabuada do {i}:"); 

    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine(); 
}







Console.Write("Digite um número de 1 a 1000: ");

int numero = int.Parse(Console.ReadLine());

if (numero is < 1000 and >= 1)
{
    for (int i = 1; i <= numero; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}


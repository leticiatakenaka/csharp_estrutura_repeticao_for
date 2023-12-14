Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write("Digite um par de números separados por espaço: ");
    var numeros = Console.ReadLine().Split(' ');

    var n1 = double.Parse(numeros[0]);
    var n2 = double.Parse(numeros[1]);

    if (n2 == 0)
    {
        Console.WriteLine("Divisão impossível");
        continue;
    }

    Console.WriteLine(n1/n2);
}

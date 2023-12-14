//Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
// Lembrando que, por definição, fatorial de 0 é 1

Console.Write("Digite um valor: ");
var n = int.Parse(Console.ReadLine());

Console.WriteLine(Fatorial(n));

static int Fatorial(int numero)
{
    if (numero == 0)
    {
        return 1;
    }

    return numero * Fatorial(numero - 1);
}
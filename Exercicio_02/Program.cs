// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
// Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
// essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)

Console.Write("Digite a quantidade de números que serão lidos: ");
int n = int.Parse(Console.ReadLine());

int dentro = 0, fora = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Digite um número: ");
    var numero = int.Parse(Console.ReadLine());

    if (numero is >= 10 and <= 20)
    {
        dentro++;
        continue;
    }

    fora++;
}

Console.WriteLine($"{dentro} in");
Console.WriteLine($"{fora} out");
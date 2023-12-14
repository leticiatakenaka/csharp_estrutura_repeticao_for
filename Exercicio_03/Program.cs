
Console.Write("Digite um valor inteiro: ");
var n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write("Digite três números separados por espaço: ");
    var numeros = Console.ReadLine().Split(' ');

    var n1 = double.Parse(numeros[0]) * 2;
    var n2 = double.Parse(numeros[1]) * 3;
    var n3 = double.Parse(numeros[2]) * 5;

    var mediaPonderada = (n1 + n2 + n3) / 10;

    Console.WriteLine(mediaPonderada.ToString("F1"));
}

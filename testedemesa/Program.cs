// teste de mesa ( calculo de media de notas)
double[] notas = { 7.5, 8.0, 6.5, 9.0, 7.0 };
double soma = 0;

Console.WriteLine("=== teste de mesa ===");
Console.WriteLine("passo | i | notas[i] | somas antes | soma depois");
Console.WriteLine("----------------------------------------------------");

for (int i = 0; i < notas.Length; i++)
{
    double somaAntes = soma;
    soma += notas[i];
    double somaDepois = soma;

    Console.WriteLine(
        $"{i + 1,5} | {i,5} | {notas[i],8} | {somaAntes,10} | {somaDepois,11}");

}
Console.WriteLine("-------------------------------------------");

double media = soma / notas.Length;
Console.WriteLine("a media das notas é:" + media );
Console.WriteLine();


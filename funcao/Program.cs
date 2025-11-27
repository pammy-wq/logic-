using System;

    class Program
{
    static void Main ()
    {
        //chama uma função simples que imprime uma mensagem
        ImprimirMensagem();

        // exemplo de funções para calculo de areas (modularização)
        Console.WriteLine("\n--- Areas ---");
        Console.WriteLine("quadrado:" + CalcularAreaQuadrado(4));
        Console.WriteLine("Circulo:" + CalcularAreaCirculo(3));

        // exemplo de progrma dividido em fuções; entrada, prcessamento e saida
        Console.WriteLine("\n----Media de notas---");
        double[] notas = EntrarNotas(3);  // entrada de dados
        double media = CalcularMedia(notas);  // processando
        Console.WriteLine("media:" + media );  // saida
    }

    // função simples que exibe uma mensagem no console
    static void ImprimirMensagem() => Console.WriteLine("olá mundo");

    // função que calcula a area de um quadrado
    static double CalcularAreaQuadrado(double lado) => lado * lado;

    // função que calcula a area de um circulo

    static double CalcularAreaCirculo(double raio) => Math.PI * raio * raio;


    // função que lê notas digitadas pelo usuario e amarzena em um vetor
    static double[] EntrarNotas ( int qtd)
    {
        double[] notas = new double[qtd];
        for (int i = 0; i < qtd; i++)
        {
            Console.Write("nota"+ (i + 1) + ": ");
            notas[i] = double.Parse(Console.ReadLine());    
        }
        return notas;
            }

    // função que calcula a media de um vetor de notas

    static double CalcularMedia(double[] notas)
    {
        double soma = 0;
        foreach (double n in notas) soma += n;
    return soma / notas.Length;
    
    }
}

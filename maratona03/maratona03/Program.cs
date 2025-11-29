using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ================================
        // 1. LISTA DE PEÇAS DE CARRO
        // ================================
        Console.WriteLine("=== Lista de Peças de Carro ===");
        string[] pecas = {
            "Motor", "Bateria", "Pneu", "Freio", "Radiador",
            "Velas", "Filtro de Ar", "Amortecedor", "Embreagem", "Farol"
        };

        foreach (string peca in pecas)
        {
            Console.WriteLine(peca);
        }

        Console.WriteLine(); // linha em branco



        // ================================
        // 2. DADOS DO GATO (Dictionary)
        // ================================
        Console.WriteLine("=== Dados do Gato ===");
        Dictionary<string, string> gato = new Dictionary<string, string>()
        {
            {"Nome", "Irelia"},
            {"Idade", "2 anos"},
            {"Peso", "4 kg"},
            {"Raça", "SRD"},
            {"Cor", "Cinza"}
        };

        foreach (var dado in gato)
        {
            Console.WriteLine($"{dado.Key}: {dado.Value}");
        }

        Console.WriteLine(); // linha em branco



        // ================================
        // 3. PROGRAMA QUE PERGUNTA SE QUER CONTINUAR
        // ================================
        Console.WriteLine("=== Perguntar se quer continuar ===");
        string resposta;

        do
        {
            Console.Write("Deseja continuar? (s/n): ");
            resposta = Console.ReadLine();

        } while (resposta.ToLower() == "s");

        Console.WriteLine(); // linha em branco



        // ================================
        // 4. TABUADA DO 3 COM DO WHILE
        // ================================
        Console.WriteLine("=== Tabuada do 3 ===");

        int i = 1; // variável declarada na mesma linha

        do
        {
            Console.WriteLine($"3 x {i} = {3 * i}");
            i++;

        } while (i <= 10);
    }
}

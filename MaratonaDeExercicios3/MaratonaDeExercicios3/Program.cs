using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== LISTA DE PEÇAS DE CARRO ===");
        ListaDePecas();

        Console.WriteLine("\n=== DADOS DO GATO (ARRAY ASSOCIATIVO) ===");
        DadosDoGato();

        Console.WriteLine("\n=== DO WHILE - DESEJA CONTINUAR? ===");
        DesejaContinuar();

        Console.WriteLine("\n=== DO WHILE - TABUADA DO 3 ===");
        TabuadaDoTres();

        Console.WriteLine("\n--- FIM DAS ATIVIDADES ---");
        Console.ReadLine();
    }

    // ----------------------------------------------------
    // 1. LISTA DE PEÇAS DE CARRO (Array + foreach)
    // ----------------------------------------------------
    static void ListaDePecas()
    {
        string[] pecas = {
            "Motor",
            "Pneu",
            "Freio",
            "Bateria",
            "Radiador",
            "Embreagem",
            "Farol",
            "Velas",
            "Para-choque",
            "Filtro de ar"
        };

        foreach (string p in pecas)
        {
            Console.WriteLine(p);
        }
    }

    // ----------------------------------------------------
    // 2. DADOS DO GATO (Dictionary + foreach)
    // ----------------------------------------------------
    static void DadosDoGato()
    {
        Dictionary<string, string> gato = new Dictionary<string, string>();

        gato.Add("Nome", "Irelia");
        gato.Add("Idade", "2 anos");
        gato.Add("Cor", "Cinza");
        gato.Add("Raça", "Vira-lata");
        gato.Add("Peso", "3.5 kg");

        foreach (var info in gato)
        {
            Console.WriteLine(info.Key + ": " + info.Value);
        }
    }

    // ----------------------------------------------------
    // 3. DO WHILE - PERGUNTA SE QUER CONTINUAR
    // ----------------------------------------------------
    static void DesejaContinuar()
    {
        string resposta;

        do
        {
            Console.WriteLine("Você deseja continuar? (s/n)");
            resposta = Console.ReadLine();

        } while (resposta == "s");

        Console.WriteLine("Programa finalizado.");
    }

    // ----------------------------------------------------
    // 4. DO WHILE - TABUADA DO 3
    // ----------------------------------------------------
    static void TabuadaDoTres()
    {
        int contador = 1;

        do
        {
            Console.WriteLine("3 x " + contador + " = " + (3 * contador));
            contador++;
        }
        while (contador <= 10);
    }
}

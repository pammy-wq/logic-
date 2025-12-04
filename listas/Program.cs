using System;
using System.Collections.Generic;

    class program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        // adicionando elementos
        nomes.Add("ana");
        nomes.Add("bruno");
        nomes.Add("carlos");

        Console.WriteLine(nomes[0]); // ana
        Console.WriteLine(nomes[1]); // bruno
        Console.WriteLine(nomes[2]); // Carlos

        Console.WriteLine("lista após adicionar elementos:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //adiciona novo nome
        nomes.Add("daniel");

        Console.WriteLine("\nLista apos adicionar 'daniel':");
      foreach (string nome in nomes)
        {
            Console.WriteLine(nome); 
        }

        // removendo elementos
        nomes.Remove("bruno"); // remove pelo valor

        Console.WriteLine("\nListas apos remover 'bruno':");
            foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        // removendo pelo indice
        nomes.RemoveAt(0); // remove o primeiro (ana)

        Console.WriteLine("\nLista apos remover o indice 0 (ana):");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }



        //limpando toda a lista
        nomes.Clear();

        Console.WriteLine("\n Lista apos clear():");
        Console.WriteLine("Quantidade de elementos:" + nomes.Count);

    }
}
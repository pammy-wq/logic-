//declar~ção de dois vetores
int[] numeros = { 7, 2, 3, 34, 5 }; // vetor de inteiros
string[] nomes = { "ana", "joão", "maria", "carlos" }; //vetor de string

//exibido os elementos de vetor de numeros com loop for
Console.WriteLine("vetor de numeros (usando for):");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

//exibindo os elementos do vetor de nomes com loop forech
Console.WriteLine("\nvetor de nomes(usando foreach):");
foreach (var nome in nomes)
    {
    Console.WriteLine(nome);

}

/* ordenação do vetor de numeros
Array.Sort(numeros);
Console.WriteLine("\nvetor de numeros ordenado:");
foreach (var n in nomes)
{
    Console.WriteLine(n);
}*/


int valorProcurado = 5;
int posiçãoSequencial = PesquisaSequencial(numeros, valorProcurado);

if (posiçãoSequencial != -1)
{
    Console.WriteLine($"\nPesquisa Sequnecial: Valor {valorProcurado} encontrado na posição {posiçãoSequencial}");
}
else
{
    Console.WriteLine($"\n pesquisa sequencial:valor {valorProcurado} não encontrado.");
}

static int PesquisaSequencial(int[]vetor, int valor)
{
    for (int i = 0;i < vetor.Length;i++)
    {
        if (vetor[i] == valor)
            return i; // retorna o indice do valor encontrado
    }
    return -1; // retorna -1 se não encontrar
}


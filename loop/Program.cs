//loop for 
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

int soma = 0;

for (int i = 1; i <=100; i++)
{
    soma += i; // somar o valor da i á variavel soma, exemplo; 1+2+3+4........+99+100
}

Console.WriteLine("A soma dos numero de 1 á 100 é:" + soma);
/*
for (; ; )
{
    Console.WriteLine("este é um loop infinito");
}
*/

//loop while (enquanto)

int contador = 1;

while (contador <=5)
{
    Console.WriteLine(contador);
    contador++; // Incrementa o contador
}

//loop do while (faça enquanto)

int novocontador = 2;

do
{
    Console.WriteLine(novocontador);
    novocontador++; // incrementar o cotador
} while (contador <=5);

//loop ifinita while

/*while (true) 

{
    Console.WriteLine("Esse é um loop infinito");
}*/

// FORECH

// uma lista de string
List<string> nomes = new List<string> { "ana", "carlos", "joão", "Maria" };

// usando o foreach para recorrer a lista
foreach (string nome in nomes)
    { 
    Console.WriteLine(nome); // imprimi cada nome exibido na tela  
}

/*foreach (string teste in nomes)
{
    Console.WriteLine(teste); // imprimi cada nome exibido na tela  
}*/

// um vetor de numeros inteiros
int[] numeros = { 1, 2, 3, 4, 5 };

// usando foreach para recorrer o vetor
foreach ( int numero in numeros)
{
    Console.WriteLine(numero); // imprime cada numero exibido na tela
}









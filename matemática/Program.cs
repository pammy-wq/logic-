//declarando constantes
const int valor1 = 10;
const int valor2 = 5;

//soma
int soma = valor1 + valor2;
Console.WriteLine($"{valor1} + {valor2} é igual á {soma}");

//subtracão
int subtracao = valor1 - valor2;
Console.WriteLine($"{valor1} - {valor2} é igual a {subtracao}");

//multiplicação

int multiplicacao = valor1 * valor2;
Console.WriteLine($"{valor1} x {valor2} é igual á {multiplicacao}");

//divisão
int divisao = valor1 / valor2;
Console.WriteLine($"{valor1} dividindo por {valor2} é igual a {divisao}");

// resto da divisao
int restoDaDivisao = valor1 % valor2;
Console.WriteLine($"o resto da divisão de {valor1} por {valor2} é igual a {restoDaDivisao}");

//ponteciação

double potencia = Math.Pow(valor1, valor2);
Console.WriteLine($"ponreciação: {valor1} elevado a {valor2} é igual {potencia}");

/* (comentando mais de 1 linha ao mesmo tempo)
ordem
de
grandeza */

//exemplo 1: sem parênteses
int resultado1 = 3 + 5 * 2; //multiplicação tem prioridade
Console.WriteLine($"resultado de 3 + 5 * 2 é igual a {resultado1}");

//exemplo 1: com parênteses
int resultado2 = (3 + 5) * 2; //parênteses alteram a ordem 
Console.WriteLine($"resultado de (3 + 5) * 2 é igual a {resultado2}");

//exemplo 1: sem parênteses
int resultado3 = 8 / 4 + 3;//divisacão tem prioridade
Console.WriteLine($"resultado de 8 / 4 + 3 é igual a {resultado3}");

//exemplo 1: com parênteses
double resultado4 = 8.0 / (4 + 3);//parênteses alteram a ordem
Console.WriteLine($"resultado de 8.0 / (4 + 3) é igual a {resultado4}");
int a = 10;
int b = 5;

//operadores relacionais
bool maiorQue = a > b;
bool menorQue = a < b;
bool igual = a == b;
bool diferente = a != b;
bool maiorOuIgual = a >= b;
bool menorOuIgual = a <= b;


//Exibindo resultados dos operadores relacionais
Console.WriteLine("\nOperadores Relacionais:");
Console.WriteLine($"{a} > {b}: {maiorQue}");
Console.WriteLine($"{a} < {b}: {menorQue}");
Console.WriteLine($"{a} == {b}: {igual}");
Console.WriteLine($"{a} != {b}: {diferente}");
Console.WriteLine($"{a} >= {b}: {maiorOuIgual}");
Console.WriteLine($"{a} <= {b}: {menorOuIgual}");


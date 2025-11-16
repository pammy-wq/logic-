//variavel
char letra = 'a';
string nome = "joao";
float temperatura = 36.5f;
double salario = 12345.67;
bool estaChovendo = true;

//alterando as variaveis #mudou os valores
letra = 'B';
nome = "maria";
temperatura = 37.0f;
salario = 15000.50;
estaChovendo = false;

//constanes
const char simbolo = '$';
const string saudacao = "bem-vindo ao C#";
const float pi = 3.14159f;
const double altura = 1.75;
const bool ehVerdade = false;
const int numero = 14;

// Exibindo os valores originais por interpolação
Console.WriteLine("valores originais");
Console.WriteLine($"letra: {letra}");
Console.WriteLine($"nome: {nome}");
Console.WriteLine($"temperatura: {temperatura}");
Console.WriteLine($"temperatura: {salario}");
Console.WriteLine($"salraio: {salario}");
Console.WriteLine($"está chovendo? {estaChovendo}");

//exibindo os valores originais por concatenação
Console.WriteLine("\nConstantes:");
Console.WriteLine("simbolo: " + simbolo);
Console.WriteLine("saudação: " + saudacao);
Console.WriteLine("valor de pi: " + pi);
Console.WriteLine("altura: " + altura);
Console.WriteLine("é verdade? " + ehVerdade);
Console.WriteLine("número: " + numero);
//condicional IF
using System.ComponentModel.Design;
using System.Globalization;
using System.Transactions;

string nome = "ana";

if (nome == "ana")
{
    Console.WriteLine("Ola, ana");
}


String texto = "";

if (string.IsNullOrEmpty(texto))
{
    Console.WriteLine("A string esta vazia.");
}

//condicional IF/ELSE

int idade = 16;

if (idade >=18) 
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}

int numero = 7;
if(numero % 2 == 0)
{
    Console.WriteLine("O numero é par.");
}
else
{
    Console.WriteLine("O numero é impa.");
}

//condicional usando Else IF

double nota = 6.5;

if (nota >= 9.0)
{
    Console.WriteLine("Voce obeteve uma excelente nota! Aprovado com distinção");

}
else if (nota >= 7.0)
{ 
    Console.WriteLine("Você esta aprovado");
}

else if (nota >= 5.0)
{
    Console.WriteLine("Você está em recuperação");
}

else if(nota >=3.0)
{
    Console.WriteLine("Você esta em risco de reprovação");
}

else
{
    Console.WriteLine("você foi reprovado!");
}

//switch
double pontuação = 8.5;
// arrendondando a nota para o interior mais proximo  - Floor arrendoda para baixo - Roun() para cima se for 8.6
int faixaNota = (int)Math.Floor(pontuação);

switch (faixaNota)
{
    case 10:
        Console.WriteLine("voce obteve uma excelente nota! Aprovado com distinção");
        break;
        case 9:
        case 8:
        Console.WriteLine("Você esta aprovado");
        break;
    case 7:
        case 6:

        Console.WriteLine("Você esta em recuperação");
        break;
        case 5:
        case 4: 
       case 3:

       Console.WriteLine("Você esta em risco de reprovação");
        break;
    default:
        Console.WriteLine("Você foi reprovado");
        break;


}


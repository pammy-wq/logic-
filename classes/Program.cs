 
using Microsoft.VisualBasic;
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 
namespace logica13
{
    //Definição da classe Carro
    internal class Carro
    {
        // propriedade pública: Pode ser acessada e modificada fora da classe
        public string Marca { get; set; } // Publica a propriedade Marca

        // Propriedade privada: Não pode ser acessada ou modificada fora da classe
        private string Modelo { get; set; } // Privada, acessível apenas dentro da classe

        // Propriedade privada com um campo privado e um método getter e setter personalizados
        private int _ano; // Campo privado

        public int Ano
        {
            get { return _ano; } // Getter, para acessar o valo do campo privado
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year) // Verificação para garantir um valor válido
                {
                    _ano = value;
                }
                else
                {
                    Console.WriteLine("Ano inválido.");
                }
            }
        }
        // metodo publico para exibir informaçoes do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"marca: {Marca}");
            Console.WriteLine($"Modelo:{Modelo}"); // acesso ao modelo e restrito por ser privado
            Console.WriteLine($"Ano: {Ano}");
        }
        // metodo para calcular a idade do carro
        public int CalcularIdade()
        { int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }
        // metodo para definir o modelo do carro (com exemplo de uso de propriedade privada)
        public void DefinirModelo(string modelo)
        {
            Modelo = modelo; // acessando a propriedade privada dentro da classe
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando um objeto da classe carro
            Carro meuCarro = new Carro();

            // atribuindo valores as propriedades publicas e privadas
            meuCarro.Marca = "toyota";
            meuCarro.DefinirModelo("corolla"); //  usando metodo para definir o modelo, pois é privado
            meuCarro.Ano = 2020;  // a propriedade Ano é publica, mas com uma validaçao interna

            // exibindo as informações do carro
            meuCarro.ExibirInformacoes();
            
            // calculamdo e exibindo a idade do carro
            int idadeCarro = meuCarro.CalcularIdade();
            Console.WriteLine($"idade do carro: {idadeCarro} anos.");

            // mantendo o console aberto
            Console.ReadLine();
        }
    }
}


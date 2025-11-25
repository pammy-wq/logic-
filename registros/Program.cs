using System;
using System.IO; // ele esta utilizando alguma coisa da propria biblioteca do codigo c#

namespace AulaResgistrosArquivos // nome da pasta 
{
    public struct Cliente  // criando a estrutura de dados do cliente
    {
        public string Nome;
        public int Idade;
        public string Email;
    }


    class Program // uma classe executavel do prgrama
    {
        static void Main(string[] args)
        {
            {
                // declaração  e uso basico de registros
                Cliente cliente1;
                cliente1.Nome = "joão";
                cliente1.Idade = 30;
                cliente1.Email = "joão@example.com";

                Console.WriteLine("===Cliente 1===");
                Console.WriteLine("Nome:" + cliente1.Nome);
                Console.WriteLine("idade:" + cliente1.Idade);
                Console.WriteLine("email:" + cliente1.Email);
                Console.WriteLine();


                // GRavação e exibição de informações
                Cliente cliente2;
                cliente2.Nome = "maria";
                cliente2.Idade = 25;
                cliente2.Email = "maria@example.com";

                Console.WriteLine("=== cliente 2 ===");
                Console.WriteLine("nome:" + cliente2.Nome);
                Console.WriteLine("idade:" + cliente2.Idade);
                Console.WriteLine("email:" + cliente2.Email);
                Console.WriteLine();

                // organização de dados em tabela (vetor de registros)
                Cliente[] clientes = new Cliente[2];
                clientes[0].Nome = "joão";
                clientes[0].Idade = 30;
                clientes[0].Email = "joão@example.com";
                clientes[1].Nome = "maria";
                clientes[1].Idade = 25;
                clientes[1].Email = "maria@example.com";

                Console.WriteLine("=== Tabela de clientes===");
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine("Nome:" + cliente.Nome);
                    Console.WriteLine("idade:" + cliente.Idade);
                    Console.WriteLine("email:" + cliente.Email);
                    Console.WriteLine();

                    //=== gravação de dados em arquivos ===
                    Cliente cliente3;
                    cliente3.Nome = "carlos";
                    cliente3.Idade = 40;
                    cliente3.Email = "calors@example";

                    string caminhoArquivo = "clientes.txt.";

                    using (StreamWriter sw = new StreamWriter(caminhoArquivo))
                    {
                        sw.WriteLine("=== Cliente 3===");
                        sw.WriteLine("nome:" + cliente3.Nome);
                        sw.WriteLine("idade:" + cliente3.Idade);
                        sw.WriteLine("email:" + cliente3.Email);
                    }
                    Console.WriteLine("=== Gravação de arquivos===");
                    Console.WriteLine($"informação de {cliente3.Nome} gravadas em ' {caminhoArquivo}'.");
                    Console.WriteLine();

                    //Leitura do arquivo gravado
                    Console.WriteLine("=== Conteudo do arquivo ===");
                        string conteudo = File.ReadAllText(caminhoArquivo);
                    Console.WriteLine(conteudo);

                    Console.WriteLine("\n=== Fim da execução ===");
                }
            }
        }
    }
 }


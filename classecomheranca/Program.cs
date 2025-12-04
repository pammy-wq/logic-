using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica14  // nome da pasta de trabalho
{
    // classe base (superclasse)
    internal class Animal
    {
        // propriedade da clsse animal
        public string Nome { get; set; }

        // metodo que sera sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine($"o animal{Nome} emite um som.");
        }
    }
        //classe derivada (subclasse)
        internal class cachorro : Animal 
        {
            //sobrescrevendo o metodo emitirsom
            public override void EmitirSom()
            {
                Console.WriteLine($"{Nome} late: AUAU!");
            }
    }

    //outra classe derivada
    internal class Gato : Animal
    {
        // sobreescrevendo o metodo de emitirsom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: Miau!");
        }
    }
    internal class program
    {
        static void Main(string[] args) // o meu executavel
        {
            //criando instancias das classes derivadas
            Animal meuCachorro = new cachorro { Nome = "rex" };
            Animal meuGato = new Gato { Nome = "felix" };
            Animal meuCoelho = new Animal { Nome = "lulu" };


            // chamando o metodo emitirsom para cada animal
            meuCachorro.EmitirSom(); // saida: rex late: auau
            meuGato.EmitirSom();  // saida: felix mia:miau
            meuCoelho.EmitirSom(); // saida: o animal emiti um som

            // utilizando polimorfismo: array de animais
            Animal[] animais = { meuCachorro, meuGato , meuCoelho };

            foreach (var anima in animais)
            {
                Animal.EmitirSom(); // cada objeto chama o metodo adequado de sua classe
            }

           

        }
    }
}
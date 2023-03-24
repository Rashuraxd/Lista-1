using System.Runtime.Intrinsics.X86;

namespace Lista_1
{
    internal class Exercicio3
    {
        static void Main(string[] args)
        {
            //3.Faça um algoritmo em que efetue a leitura do nome e do sexo de uma pessoa,
            //apresentando como saída uma das seguintes mensagens: “Ilmo Sr.”, para o sexo informado
            //como masculino, ou a mensagem “Ilma Sra.”, para o sexo informado como feminino.
            //Apresente na sequência da mensagem impressa o nome da pessoa.

            Console.WriteLine("|||||||||||||||||| Exercício 3 |||||||||||||||||");
            Console.WriteLine("Qual seu nome?");
            string nome;
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Qual seu sexo? F/M");
            string sexo;
            sexo = Convert.ToString(Console.ReadLine());

            if (sexo == "M" || sexo == "m")
            {
                Console.WriteLine($"Olá Ilmo Sr.{nome}");
            }
            else if (sexo == "F" || sexo == "f")
            {
                Console.WriteLine($"Olá Ilma Sra.{nome}");
            }

            else
            {
                Console.WriteLine("invalido");
            }

        }
    }
}
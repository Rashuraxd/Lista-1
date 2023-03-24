using System.Runtime.Intrinsics.X86;

namespace Lista_1
{
    internal class Exercicio10
    {
        static void Main(string[] args)
        {
            //1 - Elabore um algoritmo em que efetue a leitura de um valor que esteja entre a faixa de 1 a
            //9.Após a leitura do valor fornecido pelo usuário, o programa deverá indicar uma de duas
            //mensagens: “O valor está na faixa permitida”, caso o usuário forneça o valor nesta faixa,
            //ou a mensagem “O valor está fora da faixa permitida”, caso o usuário forneça valores
            //menores que 1 ou maiores que 9.

            Console.WriteLine("|||||||||||||||||| Exercício 1 |||||||||||||||||");

            int num;
            Console.WriteLine("Entre com o numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if ((num>9) || (num<1))
            {
                Console.WriteLine("o numero está fora da faixa");
            }
           
            else
                Console.WriteLine("o numero esta dentro da faixa");

            //2.Escreva um algoritmo que lê três valores para os lados de um triângulo. O algoritmo deve
            //verificar se o triângulo é equilátero(todos os lados iguais), isósceles(dois lados iguais) ou
            //escaleno(todos lados diferentes).

            Console.WriteLine("|||||||||||||||||| Exercício 2 |||||||||||||||||");

            Console.WriteLine("Insira o comprimento do lado A do triângulo:");
            int xA;
            xA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o comprimento do lado B do triângulo:");
            int xB;
            xB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o comprimento do lado C do triângulo:");
            int xC;
            xC = Convert.ToInt32(Console.ReadLine());

            if (xA == xB && xA == xC)
            {
                Console.WriteLine("O triângulo é Equilátero.");
            }
            else if (xA != xB && xA != xC && xB != xC)
            {
                Console.WriteLine("O triângulo é Escaleno");
            }

            else 
            {
                Console.WriteLine("o triangulo é Isoceles");
                  
            }

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
            else if(sexo == "F" || sexo == "f")
            {
                Console.WriteLine($"Olá Ilma Sra.{nome}");
            }

            else {
                Console.WriteLine("invalido");
            }

            //4.Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo
            //em que calcule peso ideal, utilizando as seguintes fórmulas:
            //• Para homens: (72.7 * h) –58
            //• Para mulheres: (62.1 * h) - 44.7
            //• Onde h equivale à altura da pessoa.

            float altura;
            Console.WriteLine("Digite seu sexo");


        }
    }
}
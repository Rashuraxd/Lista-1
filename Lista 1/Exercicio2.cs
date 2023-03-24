using System.Runtime.Intrinsics.X86;

namespace Lista_1
{
    internal class Exercicio2
    {
        static void Main(string[] args)
        {
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
        }
    }
}
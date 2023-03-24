using System.Runtime.Intrinsics.X86;

namespace Lista_1
{
    internal class Exercicio1
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
        }
    }
}
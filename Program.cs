using System;

namespace Zero_a_Dez
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

            Console.WriteLine("Digite a nota correta");
            int nota = int.Parse(Console.ReadLine());
            
            while(nota != 7)
            {
                Console.WriteLine("Errou!");
                Console.WriteLine("Digite a nota novamente!");
                nota = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acertou!");
             
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar um número entre 1 e 100.");

        // Gerar um número aleatório entre 1 e 100
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int tentativas = 0;
        int tentativaUsuario;

        do
        {
            Console.Write("Digite sua tentativa: ");

            // Certifique-se de que a entrada é um número inteiro
            if (int.TryParse(Console.ReadLine(), out tentativaUsuario))
            {
                // Verificar se a tentativa é maior, menor ou igual ao número gerado
                if (tentativaUsuario < numeroAleatorio)
                {
                    Console.WriteLine("Tente um número maior.");
                }
                else if (tentativaUsuario > numeroAleatorio)
                {
                    Console.WriteLine("Tente um número menor.");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

            tentativas++;

        } while (tentativaUsuario != numeroAleatorio);

        Console.WriteLine($"Você acertou em {tentativas} tentativa(s). O jogo acabou!");
    }
}
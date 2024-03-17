using System;

class Program
{
    enum Opcao
    {
        Pedra,
        Papel,
        Tesoura
    }

    static void Main(string[] args)
    {
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Opcao a opção desejada:\n1 - Pedra\n2 - Papel\n3 - Tesoura\n0 - Sair");
            int OpcaoJogador = Convert.ToInt32(Console.ReadLine());

            if (OpcaoJogador == 0)
                break;

            if (OpcaoJogador < 1 || OpcaoJogador > 3)
            {
                Console.WriteLine("Opcao uma opção válida!");
                continue;
            }

            Opcao OpcaoJogadorEnum = (Opcao)(OpcaoJogador - 1);
            Opcao OpcaoMaquina = (Opcao)random.Next(0, 3);

            Console.WriteLine($"Sua Opcao foi: {OpcaoJogadorEnum}");
            Console.WriteLine($"A maquina escolheu: {OpcaoMaquina}");

            if (OpcaoJogadorEnum == OpcaoMaquina)
            {
                Console.WriteLine("Empate!");
            }
            else if ((OpcaoJogadorEnum == Opcao.Pedra && OpcaoMaquina == Opcao.Tesoura) ||
                     (OpcaoJogadorEnum == Opcao.Papel && OpcaoMaquina == Opcao.Pedra) ||
                     (OpcaoJogadorEnum == Opcao.Tesoura && OpcaoMaquina == Opcao.Papel))
            {
                Console.WriteLine("Ganhou!");
            }
            else
            {
                Console.WriteLine("Perdeu!");
            }
        }
    }
}

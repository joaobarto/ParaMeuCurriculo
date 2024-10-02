
        Random random = new Random();
        string[] opcoes = { "Pedra", "Papel", "Tesoura" };

        Console.WriteLine("Bem-vindo ao jogo Pedra, Papel e Tesoura!");
        
        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Pedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tesoura");
            Console.WriteLine("4. Sair");
            Console.Write("Digite o número da sua escolha: ");
            string escolhaUsuario = Console.ReadLine();

            if (escolhaUsuario == "4")
            {
                Console.WriteLine("Saindo do jogo. Até logo!");
                break;
            }

            int escolhaComputador = random.Next(0, 3);
            string escolha = opcoes[int.Parse(escolhaUsuario) - 1];

            Console.WriteLine($"Você escolheu: {escolha}");
            Console.WriteLine($"Computador escolheu: {opcoes[escolhaComputador]}");

            if (escolhaUsuario == "1" && escolhaComputador == 2 || 
                escolhaUsuario == "2" && escolhaComputador == 0 || 
                escolhaUsuario == "3" && escolhaComputador == 1)
            {
                Console.WriteLine("Você perdeu!");
            }
            else if (escolhaUsuario == "1" && escolhaComputador == 0 ||
                     escolhaUsuario == "2" && escolhaComputador == 1 ||
                     escolhaUsuario == "3" && escolhaComputador == 2)
            {
                Console.WriteLine("Empate!");
            }
            else
            {
                Console.WriteLine("Você ganhou!");
            }
        }


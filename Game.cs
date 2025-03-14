 public class Game
{
    private List<Carta> cartas;
    private Jogador usuario;
    private Jogador computador;

    private List<Carta> CriarCartas()
    {
        List<Carta> _cartas =
        [
            new CartaAtaque("Golpe Rápido", "Um corte veloz que fere o oponente.", 1, 2),
            new CartaAtaque("Estocada Precisa", "Um ataque certeiro que perfura a defesa.", 2, 4),
            new CartaAtaque("Machado Brutal", "Um golpe destruidor com machado pesado.", 3, 6),
            new CartaAtaque("Espada Flamejante", "Um corte envolto em chamas, causando queimaduras.", 3, 5),
            new CartaAtaque("Flecha Venenosa", "Atinge o inimigo e causa dano persistente.", 2, 3),
            new CartaAtaque("Rajada de Gelo", "Um golpe congelante que reduz a movimentação.", 3, 4),
            new CartaAtaque("Golpe Sombrio", "Um ataque das trevas, consumindo energia vital.", 4, 8),
            new CartaAtaque("Fúria do Berserker", "Um ataque feroz, mas consome toda sua energia.", 5, 10),
            new CartaAtaque("Impacto Sísmico", "Um golpe que faz o chão tremer, atingindo em cheio.", 6, 12),
            new CartaAtaque("Lança Sombria", "Uma lança de energia negra atravessa o adversário.", 4, 6),
            new CartaAtaque("Flecha Tripla", "Três flechas rápidas atingem o inimigo ao mesmo tempo.", 3, 5),
            new CartaAtaque("Espinhos do Caos", "Projeta espinhos mágicos que perfuram a armadura.", 4, 7),
            new CartaAtaque("Trovão Arcano", "Um raio destruidor cai sobre o oponente.", 5, 9),
            new CartaAtaque("Golpe Veloz", "Um ataque ágil que confunde o inimigo.", 2, 4),
            new CartaAtaque("Rajada de Lâminas", "Várias lâminas cortam o oponente de diferentes ângulos.", 4, 7),
            new CartaAtaque("Garras da Fera", "Um ataque selvagem como de uma fera raivosa.", 3, 5),
            new CartaAtaque("Chamas do Inferno", "Um fogo intenso consome o adversário.", 6, 11),
            new CartaAtaque("Corte Duplo", "Dois cortes rápidos que ignoram parte da defesa.", 3, 5),
            new CartaAtaque("Golpe Fantasma", "Uma espada espectral atinge o inimigo sem ser bloqueada.", 5, 9),
            new CartaAtaque("Lança de Sangue", "Usa o próprio sangue para fortalecer o ataque.", 4, 7),
            new CartaDefesa("Poção de Cura", "Uma poção básica que recupera energia vital.", 2, 4),
            new CartaDefesa("Escudo Espiritual", "Uma barreira de luz bloqueia ataques.", 3, 6),
            new CartaDefesa("Regeneração Mágica", "Uma magia que regenera feridas lentamente.", 4, 7),
            new CartaDefesa("Cura do Druida", "A energia da natureza restaura suas forças.", 3, 5),
            new CartaDefesa("Armadura de Pedra", "Endurece sua pele como rocha.", 4, 6),
            new CartaDefesa("Aura de Vida", "Um brilho sagrado envolve o corpo, curando ferimentos.", 5, 8),
            new CartaDefesa("Bênção dos Ancestrais", "Espíritos antigos restauram sua vitalidade.", 6, 10),
            new CartaDefesa("Meditação Interior", "Acalma a mente e acelera a cura natural.", 2, 4),
            new CartaDefesa("Pele de Aço", "Fortalece a resistência física por alguns instantes.", 3, 5),
            new CartaDefesa("Muralha Arcana", "Uma barreira mágica absorve parte do impacto.", 4, 6),
            new CartaDefesa("Fôlego Renovado", "Um segundo fôlego para continuar lutando.", 2, 3),
            new CartaDefesa("Reflexos Felinos", "Movimentos rápidos evitam golpes fatais.", 3, 5),
            new CartaDefesa("Escudo Elemental", "Uma barreira de fogo, gelo ou trovão protege você.", 4, 7),
            new CartaDefesa("Proteção Divina", "Luz celestial fortalece sua alma.", 5, 9),
            new CartaDefesa("Pele do Dragão", "Adquire resistência lendária temporária.", 6, 11),
            new CartaDefesa("Poção de Vitalidade", "Uma mistura poderosa que restaura o vigor.", 2, 4),
            new CartaDefesa("Resiliência Suprema", "Suporta ataques com a força de um titã.", 5, 9),
            new CartaDefesa("Armadura Sagrada", "A luz purifica seu corpo, curando feridas profundas.", 6, 12),
            new CartaDefesa("Restauração Total", "Uma magia suprema que regenera completamente.", 7, 15),
            new CartaDefesa("Cura Sombria", "Poder negro que sacrifica um pouco de energia para curar.", 4, 6),
        ];

        return _cartas;
    }

    private string Viloes()
    {
        Random aleatorio = new Random();
        int numeroAleatorio = aleatorio.Next(1, 43);

        List<string> viloes = new List<string>
        {
            "Voldemort", 
            "Darth Vader", 
            "Loki", 
            "Coringa", 
            "Thanos", 
            "Sauron", 
            "Hannibal Lecter", 
            "Malévola", 
            "Megatron", 
            "Freddy Krueger", 
            "Norman Bates", 
            "Drácula", 
            "Darkseid", 
            "Ra's al Ghul", 
            "Ultron", 
            "Duende Verde", 
            "Scar", 
            "Jafar", 
            "Lex Luthor", 
            "Caveira Vermelha", 
            "Magneto", 
            "Dr. Octopus", 
            "Rei do Crime", 
            "Arlequina", 
            "Bane", 
            "Mística", 
            "Venom", 
            "Poison Ivy", 
            "Adão Negro", 
            "Ronan, o Acusador", 
            "Exterminador", 
            "General Zod", 
            "Killmonger", 
            "Homem-Areia", 
            "Hela", 
            "Jigsaw", 
            "O Governador", 
            "Pennywise", 
            "A Feiticeira Branca", 
            "Destruidor", 
            "Chucky", 
            "Grendel", 
            "Cersei Lannister", 
            "Joffrey Baratheon", 
            "Ares"
        };

        return viloes[numeroAleatorio];
    }

    private void CriarMao(Jogador _jogador)
    {
        List<Carta> mao = new List<Carta>();

        Random aleatorio = new Random();

        var cartasAtaque = cartas.OfType<CartaAtaque>().OrderBy(x => aleatorio.Next()).ToList();
        var cartasDefesa = cartas.OfType<CartaDefesa>().OrderBy(x => aleatorio.Next()).ToList();

        for (int i = 0; i < 10; i++)
        {
            mao.Add(cartasAtaque[i]);
        }

        for (int i = 0; i < 10; i++)
        {
            mao.Add(cartasDefesa[i]);
        }

        _jogador.IniciarDeck(mao);
    }

    private void DemostrarCartas(int posicao, List<Carta> _cartasJogador)
    {
        // O is parece que já retorna false ou não, então o verificar se é null é desnecessário
        if (_cartasJogador[posicao] is CartaAtaque && _cartasJogador[posicao] != null)
        {
            CartaAtaque? cartaAtaque = _cartasJogador[posicao] as CartaAtaque;
            Console.WriteLine($"Carta Ataque ({posicao + 1}°) : {cartaAtaque?.Nome} | Descrição: {cartaAtaque?.Descricao} | Gasto de energia: {cartaAtaque?.Energia} | Dano: {cartaAtaque?.Dano}");
        }
        else if (_cartasJogador[posicao] is CartaDefesa  && _cartasJogador[posicao] != null)
        {
            CartaDefesa? cartaDefesa = _cartasJogador[posicao] as CartaDefesa;
            Console.WriteLine($"Carta Defesa ({posicao + 1}°) : {cartaDefesa?.Nome} | Descrição: {cartaDefesa?.Descricao} | Gasto de energia: {cartaDefesa?.Energia} | Recupera: {cartaDefesa?.Vida}");
        }
    }

    private Carta EscolhaUsuario()
    {
        List<Carta> cartasJogador = usuario.ObterDeck();
        
        string? entrada;
        int carta;

        Console.WriteLine($"Turno de {usuario.Nome}");
        Console.WriteLine($"Vida: {usuario.Vidas} | Energia: {usuario.Energia}");

        Esperar(1000);

        while (true)
        { 
            for (int i = 0; i < cartasJogador.Count; i++)
            {
                DemostrarCartas(i, cartasJogador);
            }
            
            Console.WriteLine("Por favor, escolha a sua carta para usar:");
            entrada = Console.ReadLine();

            if (int.TryParse(entrada, out carta))
            {
                carta -= 1;

                if (carta > -1 && carta < cartasJogador.Count)
                {
                    Console.WriteLine($"Você escolheu a carta número {carta + 1}.");

                    DemostrarCartas(carta, cartasJogador);  
                    Esperar(5000);

                    return usuario.SelecionarCarta(carta);     
                }
                else
                {
                    Console.WriteLine("Carta fora do range.");
                    Esperar(2000);
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, digite um número válido.");
                Esperar(2000);
            }
        }
    }

    private Carta EscolhaComputador()
    {
        Random aleatorio = new Random();
        int cartaNumeroAleatorio = aleatorio.Next(0, 20);

        return computador.SelecionarCarta(cartaNumeroAleatorio);
    }

    private void UsarCartaAtaque(Carta _cartaUsada, Jogador jogadorUsou, Jogador jogadorOponente)
    {
        CartaAtaque? cartaAtaque = _cartaUsada as CartaAtaque;
                
        Console.WriteLine($"O jogador {jogadorUsou.Nome} usou a carta de Ataque {cartaAtaque?.Nome} gastando {cartaAtaque?.Energia} de energia e dando {cartaAtaque?.Dano} de dano.");
    
        cartaAtaque?.Usar(jogadorUsou, jogadorOponente);
    }

    private void UsarCartaDefesa(Carta _cartaUsada, Jogador jogadorUsou, Jogador jogadorOponente)
    {
        CartaDefesa? cartaDefesa = _cartaUsada as CartaDefesa;

        Console.WriteLine($"O jogador {jogadorUsou.Nome} usou a carta de Defesa {cartaDefesa?.Nome} gastando {cartaDefesa?.Energia} de energia e recuperando {cartaDefesa?.Vida}");
        
        cartaDefesa?.Usar(jogadorUsou, jogadorOponente);
    }

    private void Batalha(Carta _jogadorCarta, Carta _computadorCarta)
    {
        if (usuario.Energia >= _jogadorCarta.Energia)
        {
            if (_jogadorCarta is CartaAtaque)
            {
                UsarCartaAtaque(_jogadorCarta, usuario, computador);
            }
            else
            {
                UsarCartaDefesa(_jogadorCarta, usuario, usuario);
            }
        }
        else
        {
            Console.WriteLine("Jogador está sem energia e não pode usar a carta");
        }
    
        if (computador.Energia >= _computadorCarta.Energia)
        {
            if (_computadorCarta is CartaAtaque)
            {
                UsarCartaAtaque(_computadorCarta, computador, usuario);
            }
            else
            {
                UsarCartaDefesa(_computadorCarta, computador, computador);
            }
        }
        else
        {
            Console.WriteLine("Jogador está sem energia e não pode usar a carta");
        }

        Esperar(2000);
    }

    private void MostrarDadosJogadores(int _tempo)
    {
        Console.WriteLine($"Jogador ({usuario.Nome}) - Vida: {usuario.Vidas} | Energia: {usuario.Energia}");
        Console.WriteLine($"Computador ({computador.Nome}) - Vida: {computador.Vidas} | Energia: {computador.Energia}");
        Esperar(_tempo);
    }

    private void RestaurarEnergiaJogadores()
    {
        if (usuario.Vidas > 0 && computador.Vidas > 0)
        {
            usuario.RestaurarEnergia();
            computador.RestaurarEnergia();
            Console.WriteLine($"O usuário {usuario.Nome} restaurou energia, estando agora com {usuario.Energia}.");
            Console.WriteLine($"O computador {computador.Nome} restaurou energia, estando agora com {computador.Energia}.");
            Esperar(3000);
        }   
    }
    
    private void DeckZerado()
    {
        List<Carta> deckUsuario = usuario.ObterDeck();
        int tamanhoDeckUsuario = deckUsuario.Count;

        if (tamanhoDeckUsuario == 0)
        {
            CriarMao(usuario);
            CriarMao(computador);
        }
    }

    private void Esperar(int tempo)
    {
        Thread.Sleep(tempo);
        Console.Clear();
    }
    
    public Game()
    {
        cartas = [.. CriarCartas()];
     
        // Exercício 1:
        // Distribuir 20 cartas para cada Jogador, sendo 10 de ataque e 10 de defesa.

        Console.WriteLine("Bem vindo ao meu jogo de RPG!\nPor favor, digite o seu nome, grande herói (Entre 0 e 20 caracteres):");
        string? nome = Console.ReadLine()?.Trim();

        while (nome?.Length < 1 || nome?.Length > 20)
        {
            Console.WriteLine("Nome inválido! O nome deve ter entre 1 e 20 caracteres. Tente novamente:");
            nome = Console.ReadLine()?.Trim();
        }

        string nome_vilao = Viloes();

        usuario = new Jogador(nome);
        computador = new Jogador(nome_vilao);

        CriarMao(usuario);
        CriarMao(computador);

        Esperar(2000);

        Console.WriteLine("Início do Jogo:");
        MostrarDadosJogadores(2000);
    }

    public void Run()
    {
        // Exercício 2:
        // Enquanto nenhum dos jogadores tiver 0 de vida, o jogo continua.
        while (usuario.Vidas > 0 && computador.Vidas > 0)
        {
            
            // Exercício 3:
            // Deve-se exibir as cartas do jogador e pedir para ele escolher uma carta.
            // O jogador deve escolher uma carta do deck para usar.
            Carta escolhaUsuario = EscolhaUsuario();
    
            // Exercício 4:
            // O computador deve escolher uma carta aleatória do deck para usar.
            Carta escolhaComputador = EscolhaComputador();

            // Exercício 5:
            // As cartas devem ser usadas e o resultado deve ser exibido.
            // Exemplo: Herói usou Poção de Vida, recuperando 4 de vida!
            Batalha(escolhaUsuario, escolhaComputador);

            // Exercício 6:
            // Exibir a quantidade de vidas e energia de cada jogador.
            // Exemplo: Jogador (Herói) - Vida: 26 | Energia: 8
            MostrarDadosJogadores(5000);

            // Exercício 7:
            // Restaurar os Pontos de Energia e continuar o jogo.
            RestaurarEnergiaJogadores();

            // Exercício 8:
            // Mostrar o vencedor e encerrar o jogo.
            // Caso, as cartas acabem, embaralhar o deck e continuar o jogo até que haja a vitória.
            if (usuario.Vidas <=0 && computador.Vidas <= 00)
            {
                Console.WriteLine("O jogo deu empate.");
            }
            else if (usuario.Vidas <= 0)
            {
                Console.WriteLine($"O vilão {computador.Nome} venceu!");
                break;
            }
            else if (computador.Vidas <= 0)
            {
                Console.WriteLine($"O herói {usuario.Nome} venceu!");
                break;
            }

            DeckZerado();

        }
    }
}

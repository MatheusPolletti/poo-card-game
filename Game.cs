public class Game
{
    private List<Carta> cartas;

    private Jogador usuario;
    private Jogador computador;

    public Game()
    {
        cartas = new List<Carta>();
        cartas.Add(new CartaAtaque("Golpe Rápido",  "Um corte veloz que fere o oponente.", 1, 2));
        cartas.Add(new CartaAtaque("Estocada Precisa",  "Um ataque certeiro que perfura a defesa.", 2, 4));
        cartas.Add(new CartaAtaque("Machado Brutal",  "Um golpe destruidor com machado pesado.", 3, 6));
        cartas.Add(new CartaAtaque("Espada Flamejante", "Um corte envolto em chamas, causando queimaduras.", 3, 5));
        cartas.Add(new CartaAtaque("Flecha Venenosa",  "Atinge o inimigo e causa dano persistente.", 2, 3));
        cartas.Add(new CartaAtaque("Rajada de Gelo",  "Um golpe congelante que reduz a movimentação.", 3, 4));

        usuario = new Jogador("Herói");
        computador = new Jogador("Vilão");

        // Exercício 1:
        // Distribuir 20 cartas para cada Jogador, sendo 10 de ataque e 10 de defesa.
        // usuario.IniciarDeck(cartasDoJogador);

        Console.WriteLine("Início do Jogo:");
        Console.WriteLine($"Jogador ({usuario.Nome}) - Vida: {usuario.Vidas} | Energia: {usuario.Energia}");
        Console.WriteLine($"Computador ({computador.Nome}) - Vida: {computador.Vidas} | Energia: {computador.Energia}");
    }

    public void Run()
    {
        // Exercício 2:
        // Enquanto nenhum dos jogadores tiver 0 de vida, o jogo continua.

        // Exercício 3:
        // Deve-se exibir as cartas do jogador e pedir para ele escolher uma carta.
        // O jogador deve escolher uma carta do deck para usar.

        // Exercício 4:
        // O computador deve escolher uma carta aleatória do deck para usar.

        // Exercício 5:
        // As cartas devem ser usadas e o resultado deve ser exibido.
        // Exemplo: Herói usou Poção de Vida, recuperando 4 de vida!  

        // Exercício 6:
        // Exibir a quantidade de vidas e energia de cada jogador.
        // Exemplo: Jogador (Herói) - Vida: 26 | Energia: 8

        // Exercício 7:
        // Restaurar os Pontos de Energia e continuar o jogo.

        // Exercício 8:
        // Mostrar o vencedor e encerrar o jogo.
        // Caso, as cartas acabem, embaralhar o deck e continuar o jogo até que haja a vitória.
    }
}
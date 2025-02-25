public class Jogador
{
    public string Nome { get; }
    public int Energia { get; private set; }
    public int Vidas { get; private set; }

    public List<Carta> Deck { get; set; } // finalizar na próxima aula.

    public Jogador(string nome) {
        Nome = nome;
        Energia = 10;
        Vidas = 30;
    }

    // exercícios:
    // método que consuma a energia do jogador.
    // polimorfismo CartaAtaque muda para a forma de Carta
    // polimorfismo CartaDefesa muda para a forma de Carta
    public void ConsumirEnergia(Carta carta) {
        Energia = Math.Max(0, this.Energia - carta.Energia);
    }

    // método que restaura a energia do jogador em 2 pontos, no máximo 10.
    public void RestaurarEnergia() {
        Energia = Math.Min(10, this.Energia + 2);
    }

    public void RestaurarVida(Carta carta) {
        // CartaDefesa cartaDefesa = (CartaDefesa)carta; // cast (coerção)
        CartaDefesa cartaDefesa = carta as CartaDefesa; // cast seguro

        Vidas = Math.Min(30, this.Vidas + cartaDefesa.Vida);
    }

    public void ReceberDano(CartaAtaque carta) {
        Vidas = Math.Max(0, this.Vidas - carta.Dano);

        // Se Vidas == 0, o jogador perdeu. (condição de vitória).
    }
}
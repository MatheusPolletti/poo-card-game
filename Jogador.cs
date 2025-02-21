public class Jogador
{
    // atributos:
    private string nome;

    // propriedades automáticas:
    public int Energia {get; set;}
    public int Vidas { get; set; }

    // propriedades = atributo + método (encapsulamento):
    public string Nome {
        get { return nome; }
        set {
            if(value.Length < 3)
                throw new Exception("O nome deve ter no mínimo 3 caracteres.");
            nome = value;
        }
    }

    // métodos:
    // public void SetNome(string nome)
    // {
    //     // regra de negócio:
    //     if(nome.Length < 3)
    //         throw new Exception("O nome deve ter no mínimo 3 caracteres.");

    //     this.nome = nome;
    // }

    // public string GetNome()
    // {
    //     return nome;
    // }

    // Jogador jogador = new Jogador();
    // // jogador.SetNome("João");
    // jogador.Nome = "João"; // set
    // Console.WriteLine(jogador.Nome); // get
    // jogador.Energia = 10;

}
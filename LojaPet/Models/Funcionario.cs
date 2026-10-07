namespace LojaPet.Models
{
    // Herança da classe Usuario
    public class Funcionario : Usuario
    {
        // Atributos
        public string Cargo { get; private set; }

        // Método Construtor com parâmetros da classe base (Usuario)
        public Funcionario(string nome, string email, string cargo) : base(nome, email)
        {
            Cargo = cargo;
        }
        // Método Sobrescrito da classe Usuario
        public override bool Autenticar(string senha)
        {
            return !string.IsNullOrEmpty(senha);
        }
    }
}

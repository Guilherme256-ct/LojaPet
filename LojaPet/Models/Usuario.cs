namespace LojaPet.Models
{
    //Classe abstrata Usuario
    public abstract class Usuario
    {
        // atributos privados
        private string _nome;
        private string _email;

        public string Nome
        {
            get => _nome;
            //Caso o nome fornecido estiver vazio ou ser somente espaços o nome é definido como Usuário
            set => _nome = string.IsNullOrWhiteSpace(value) ? "Usuário" : value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        // Método Construtor protegido
        protected Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        // Método abstrato
        public abstract bool Autenticar(string senha); 
    }

}

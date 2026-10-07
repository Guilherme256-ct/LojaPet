namespace LojaPet.Models
{
    public class Cliente
    {
        //Atributos
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Telefone { get; set; }
        // Lista de Pets do Cliente
        public List<Pet> Pets { get; set; } = new List<Pet>();

        // Método Construtor
        public Cliente(int id, string nomeCliente, string telefone)
        {
            Id = id;
            NomeCliente = nomeCliente;
            Telefone = telefone;
        }
    }
}

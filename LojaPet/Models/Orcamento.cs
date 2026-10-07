namespace LojaPet.Models
{
    public class Orcamento
    {
        // Atributos
        public Pet PetDoCliente { get; set; }
        public bool IncluiBanho { get; set; }
        public bool IncluiTosa { get; set; }
        public bool IncluiHidratacao { get; set; }

        // Método Construtor
        public Orcamento(Pet pet)
        {
            PetDoCliente = pet;
        }

        // Polimorfismo
        public virtual decimal CalcularValor()
        {
            decimal valorTotal = 0;
            //Regra de cálculo baseada no porte e nos serviços
            if (IncluiBanho)
            {
                valorTotal += 40.00m;
            }
            if (IncluiTosa)
            {
                valorTotal += 35.00m;
            }
            if (IncluiHidratacao)
            {
                valorTotal += 20.00m;
            }
            if (PetDoCliente.Porte == "Grande")
            {
                valorTotal += 30.00m;
            }
            else if (PetDoCliente.Porte == "Medio")
            {
                valorTotal += 15.00m;
            }

            return valorTotal;
        }
    }
}

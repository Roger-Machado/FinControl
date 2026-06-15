namespace FinControl.Models
{
    public class Cartao
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public decimal Limite { get; set; }

        public decimal LimiteDisponivel { get; set; }

        public int DiaFechamento { get; set; }

        public int DiaVencimento { get; set; }
    }
}
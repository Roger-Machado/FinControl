namespace FinControl.Models
{
    public class Meta
    {
        public int Id { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public decimal ValorObjetivo { get; set; }

        public decimal ValorAtual { get; set; }

        public DateTime DataLimite { get; set; }
    }
}
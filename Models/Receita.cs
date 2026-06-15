namespace FinControl.Models
{
    public class Receita
    {
        public int Id { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public decimal Valor { get; set; }

        public DateTime DataRecebimento { get; set; }

        public string Categoria { get; set; } = string.Empty;
    }
}
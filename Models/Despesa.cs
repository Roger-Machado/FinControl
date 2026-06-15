public class Despesa
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public DateTime DataVencimento { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public bool Pago { get; set; }
}
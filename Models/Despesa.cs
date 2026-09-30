using System.ComponentModel.DataAnnotations;

namespace FinControl.Models
{
    public class Despesa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(100)]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o valor.")]
        [Range(typeof(decimal), "0,01", "999999999", ErrorMessage = "O valor deve ser maior que zero.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Informe a data.")]
        public DateTime DataVencimento { get; set; }

        [Required(ErrorMessage = "Informe a categoria.")]
        [StringLength(50)]
        public string Categoria { get; set; } = string.Empty;

        public bool Pago { get; set; }
    }
}
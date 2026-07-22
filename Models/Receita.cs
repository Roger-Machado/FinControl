using System.ComponentModel.DataAnnotations;

namespace FinControl.Models
{
    public class Receita
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(100)]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o valor.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Informe a data.")]
        public DateTime DataRecebimento { get; set; }

        [Required(ErrorMessage = "Informe a categoria.")]
        [StringLength(50)]
        public string Categoria { get; set; } = string.Empty;
    }
}
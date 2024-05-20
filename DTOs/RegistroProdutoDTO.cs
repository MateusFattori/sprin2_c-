using System.ComponentModel.DataAnnotations;

namespace sprin2_c_.DTOs
{
    public class RegistroProdutoDTO
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string categoria { get; set; }

        public float valor { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace sprin2_c_.DTOs
{
    public class RegistroClienteDTO
    {
        [Required]
        public string nome { get; set; }

        [Required]
        public string cpf { get; set; }

        [Required]
        public string email { get; set; }

        [DataType(DataType.Password)]
        public string senha { get; set; }

        [DataType(DataType.Password)]
        [Compare("senha", ErrorMessage = "As senhas não coincidem.")]
        public string CompareSenha { get; set; }
        public string genero { get; set; }

        [DataType(DataType.Date)]
        public DateTime dt_nascimento { get; set; }

        public string telefone { get; set; }

        public int pontos { get; set; }

        public string fidelidade { get; set; }
    }
}

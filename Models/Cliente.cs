using System.ComponentModel.DataAnnotations;
using nextia_sprint2.Models;

namespace nextia_sprint2.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public string genero { get; set; }

        [DataType(DataType.Date)]
        public DateTime dt_nascimento {  get; set; }

        public string telefone { get; set; }

        public int pontos { get; set; }

        public string fidelidade { get; set; }

    }
}

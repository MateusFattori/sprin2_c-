using System.ComponentModel.DataAnnotations;
using nextia_sprint2.Models;


namespace nextia_sprint2.Models
{
    public class Promocao
    {
        [Key]

        public int Id { get; set; }

        public string produto { get; set; }

        public string nome_promocao { get; set; }

        [DataType(DataType.Date)]
        public DateTime dt_inicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime dt_final { get; set; }
    }
}

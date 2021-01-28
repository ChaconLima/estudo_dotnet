using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [MinLength(1, ErrorMessage=" O titulo do filme deve conter no  minimo 1 Caracter")]
        [MaxLength(80, ErrorMessage=" O titulo do filme deve conter no  minimo 1 Caracter")]
        [Required(ErrorMessage = "Titulo obrigatório")]
        public string Titulo { get; set;}

        [MinLength(20, ErrorMessage=" A descrição deve conter no  minimo 1 Caracter")]
        [MaxLength(160, ErrorMessage=" A descrição deve deve conter no  minimo 1 Caracter")]
        public string Descricao { get; set;}

        [Required(ErrorMessage = "Classificação é obrigatório")]
        public string Classificacao { get; set;}

        [Required(ErrorMessage = "Genero é obrigatório")]
        public string Genero { get; set;}
    }
}
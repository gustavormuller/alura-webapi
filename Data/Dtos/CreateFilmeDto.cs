using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace filmesapi.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 carcteres")]
        public string Genero { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "A duração deve estar entre 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
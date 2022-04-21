using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClimaTempo.Models
{
    public class Cidade
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(200, ErrorMessage = "Nome deve ter no máximo 200 caracteres")]
        public string Nome { get; set; }

        public int EstadoId { get; set; }

        public Estado Estado { get; set; }

        public ICollection<PrevisaoClima> PrevisoesClima { get; set; }


    }
}
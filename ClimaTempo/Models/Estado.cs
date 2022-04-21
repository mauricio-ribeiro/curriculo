using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClimaTempo.Models
{
    public class Estado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(200,ErrorMessage = "Nome deve ter no máximo 200 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Uf é obrigatório")]
        [StringLength(2,MinimumLength = 2,ErrorMessage = "Uf deve ter no máximo 2 caracteres")]
        public string Uf { get; set; }

        public ICollection<Cidade> Cidades { get; set; }

    }
}
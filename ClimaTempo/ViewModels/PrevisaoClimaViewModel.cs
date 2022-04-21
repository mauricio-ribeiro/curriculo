using ClimaTempo.Models;
using System.Collections.Generic;

namespace ClimaTempo.ViewModels
{
    public class PrevisaoClimaViewModel
    {

        public IEnumerable<PrevisaoClima> CidadesMaisFrias { get; set; }

        public IEnumerable<PrevisaoClima> CidadesMaisQuentes { get; set; }

        public IEnumerable<Estado> Estados { get; set; }

        public IEnumerable<Cidade> Cidades { get; set; }

        public IEnumerable<PrevisaoClima> Previsoes { get; set; }
                

    }
}
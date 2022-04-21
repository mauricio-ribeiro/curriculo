using ClimaTempo.Models;
using System.Collections.Generic;

namespace ClimaTempo.Repositories.Interfaces
{
    public interface IPrevisaoClimaRepository
    {
        IEnumerable<PrevisaoClima> ObterCidadesMaisFrias();

        IEnumerable<PrevisaoClima> ObterCidadesMaisQuentes();

        IEnumerable<PrevisaoClima> ObterPrevisaoCidadeById(int id);

    }
}

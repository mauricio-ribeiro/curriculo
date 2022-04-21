using ClimaTempo.Models;
using System.Collections.Generic;

namespace ClimaTempo.Repositories.Interfaces
{
    public interface ICidadeRepository
    {
        IEnumerable<Cidade> ObterTodasCidades(int estadoId);


    }
}

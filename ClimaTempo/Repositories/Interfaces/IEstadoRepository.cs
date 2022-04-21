using ClimaTempo.Models;
using System.Collections.Generic;

namespace ClimaTempo.Repositories.Interfaces
{
    public interface IEstadoRepository
    {
        IEnumerable<Estado> ObterTodosEstados();

    }
}

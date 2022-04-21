using ClimaTempo.Database;
using ClimaTempo.Models;
using ClimaTempo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimaTempo.Repositories
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly AppDbContext context;

        public CidadeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Cidade> ObterTodasCidades(int estadoId)
        {
            var cidades = context.Cidades.AsNoTracking().Where(y => y.EstadoId == estadoId).ToList();
            return cidades;
        }
    }
}
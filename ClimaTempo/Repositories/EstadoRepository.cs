using ClimaTempo.Database;
using ClimaTempo.Models;
using ClimaTempo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimaTempo.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly AppDbContext context;

        public EstadoRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Estado> ObterTodosEstados()
        {
            var estados = context.Estados.AsNoTracking().OrderBy(x=>x.Nome).ToList();
            return estados;
        }
    }
}
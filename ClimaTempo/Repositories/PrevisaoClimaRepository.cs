using ClimaTempo.Database;
using ClimaTempo.Models;
using ClimaTempo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;

namespace ClimaTempo.Repositories
{
    public class PrevisaoClimaRepository : IPrevisaoClimaRepository
    {

        private readonly AppDbContext context;

        public PrevisaoClimaRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<PrevisaoClima> ObterCidadesMaisFrias()
        {
            var previsoes = context.PrevisaoClimas.AsNoTracking().Include(x => x.Cidade)
                .Where(y => EntityFunctions.TruncateTime(y.DataPrevisao) == EntityFunctions.TruncateTime(DateTime.Now) && y.Clima.Nome.Equals("Frio")).ToList();
            
            if (previsoes != null && previsoes.Count > 0)
            {
                var cidadesMaisFrias = previsoes.OrderBy(x => x.TemperaturaMinima).Take(3);
                return cidadesMaisFrias;
            }

            return Enumerable.Empty<PrevisaoClima>();
        }

        public IEnumerable<PrevisaoClima> ObterCidadesMaisQuentes()
        {
            var previsoes = context.PrevisaoClimas.AsNoTracking().Include(x => x.Cidade)
                .Where(y => EntityFunctions.TruncateTime(y.DataPrevisao) == EntityFunctions.TruncateTime(DateTime.Now) && y.Clima.Nome.Equals("Calor")).ToList();

            if (previsoes != null && previsoes.Count > 0)
            {
                var cidadesMaisQuentes = previsoes.OrderByDescending(x => x.TemperaturaMaxima).Take(3);
                return cidadesMaisQuentes;
            }

            return Enumerable.Empty<PrevisaoClima>();
            
        }

        public IEnumerable<PrevisaoClima> ObterPrevisaoCidadeById(int id)
        {
            var previsoes = context.PrevisaoClimas.AsNoTracking().Where(x => x.CidadeId == id && x.DataPrevisao.Hour == 0).ToList();
            return previsoes;
        }
    }
}
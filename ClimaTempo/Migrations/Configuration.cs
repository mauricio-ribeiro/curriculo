namespace ClimaTempo.Migrations
{
    using ClimaTempo.Helpers.Previsoes;
    using ClimaTempo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClimaTempo.Database.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClimaTempo.Database.AppDbContext context)
        {

            var estados = new List<Estado>
              {
                  new Estado { Id = 1, Nome = "Rio de Janeiro", Uf = "RJ"},
                  new Estado { Id = 2, Nome = "S�o Paulo", Uf = "SP"},
                  new Estado { Id = 3, Nome = "Paran�", Uf = "PR"},
              };
            estados.ForEach(x => context.Estados.Add(x));
            context.SaveChanges();

            var cidades = new List<Cidade>
            {
                new Cidade { Id = 1, Nome = "Rio de Janeiro", EstadoId = 1  },
                new Cidade { Id = 2, Nome = "Campos dos Goytacazes", EstadoId = 1  },
                new Cidade { Id = 3, Nome = "S�o Fid�lis", EstadoId = 1  },

                new Cidade { Id = 4, Nome = "S�o Paulo", EstadoId = 2  },
                new Cidade { Id = 5, Nome = "Campinas", EstadoId = 2  },
                new Cidade { Id = 6, Nome = "Jundia�", EstadoId = 2  },

                new Cidade { Id = 7, Nome = "Curitiba", EstadoId = 3  },
                new Cidade { Id = 8, Nome = "Maring�", EstadoId = 3  },
                new Cidade { Id = 9, Nome = "Cascav�l", EstadoId = 3  }

            };
            cidades.ForEach(x => context.Cidades.Add(x));
            context.SaveChanges();


            var cdadesMaisFriasHoje = new List<PrevisaoClima>
            {
                new PrevisaoClima
                {
                    CidadeId = 1,
                    Clima = Enums.ClimaEnum.Frio,
                    TemperaturaMinima = 8,
                    TemperaturaMaxima = 18,
                    DataPrevisao = DateTime.Now
                },
                new PrevisaoClima
                {
                    CidadeId = 4,
                    Clima = Enums.ClimaEnum.Frio,
                    TemperaturaMinima = 6,
                    TemperaturaMaxima = 19,
                    DataPrevisao = DateTime.Now
                },
                new PrevisaoClima
                {
                    CidadeId = 7,
                    Clima = Enums.ClimaEnum.Frio,
                    TemperaturaMinima = 5,
                    TemperaturaMaxima = 20,
                    DataPrevisao = DateTime.Now
                },

            };
            cdadesMaisFriasHoje.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();



            var cdadesMaisQuentessHoje = new List<PrevisaoClima>
            {

                new PrevisaoClima
                    {
                        CidadeId = 2,
                        Clima = Enums.ClimaEnum.Calor,
                        TemperaturaMinima = 12,
                        TemperaturaMaxima = 28,
                        DataPrevisao = DateTime.Now
                    },
                    new PrevisaoClima
                    {
                        CidadeId = 5,
                        Clima = Enums.ClimaEnum.Calor,
                        TemperaturaMinima = 14,
                        TemperaturaMaxima = 29,
                        DataPrevisao = DateTime.Now
                    },
                    new PrevisaoClima
                    {
                        CidadeId = 8,
                        Clima = Enums.ClimaEnum.Calor,
                        TemperaturaMinima = 16,
                        TemperaturaMaxima = 30,
                        DataPrevisao = DateTime.Now
                    }

            };

            cdadesMaisQuentessHoje.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();


            var previsoesRioDeJaneiro = RioDeJaneiroHelper.ObterPrevisao().ToList();
            previsoesRioDeJaneiro.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();

            var previsoesCampopsDosGoytacazes = CamposDosGoytacazesHelper.ObterPrevisao().ToList();
            previsoesCampopsDosGoytacazes.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();

            var previsoesSaoFidelis = SaoFidelisHelper.ObterPrevisao().ToList();
            previsoesSaoFidelis.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();



            var previsoesSaoPaulo = SaoPauloHelper.ObterPrevisao().ToList();
            previsoesSaoPaulo.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();

            var previsoesCampinas = CampinasHelper.ObterPrevisao().ToList();
            previsoesCampinas.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();

            var previsoesJundiai = JundiaiHelper.ObterPrevisao().ToList();
            previsoesJundiai.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();



            var previsoesCuritiba = CuritibaHelper.ObterPrevisao().ToList();
            previsoesCuritiba.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();

            var previsoesMaringa = MaringaHelper.ObterPrevisao().ToList();
            previsoesMaringa.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();

            var previsoesCascavel = CascavelHelper.ObterPrevisao().ToList();
            previsoesCascavel.ForEach(x => context.PrevisaoClimas.Add(x));
            context.SaveChanges();

        }
    }
}

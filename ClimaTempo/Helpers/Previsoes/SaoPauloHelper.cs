using ClimaTempo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimaTempo.Helpers.Previsoes
{
    public static class SaoPauloHelper
    {

        public static IEnumerable<PrevisaoClima> ObterPrevisao()
        {
            var previsoes = new List<PrevisaoClima>()
            {

               new PrevisaoClima
                {
                    CidadeId = 4,
                    Clima = Enums.ClimaEnum.Frio,
                    TemperaturaMinima = 11,
                    TemperaturaMaxima = 17,
                    DataPrevisao = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Sunday)
                },
                 new PrevisaoClima
                 {
                     CidadeId = 4,
                     Clima = Enums.ClimaEnum.Calor,
                     TemperaturaMinima = 12,
                     TemperaturaMaxima = 20,
                     DataPrevisao = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday)
                 },
                new PrevisaoClima
                {
                    CidadeId = 4,
                    Clima = Enums.ClimaEnum.Calor,
                    TemperaturaMinima = 16,
                    TemperaturaMaxima = 24,
                    DataPrevisao = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Tuesday)
                },
                new PrevisaoClima
                {
                    CidadeId = 4,
                    Clima = Enums.ClimaEnum.Frio,
                    TemperaturaMinima = 9,
                    TemperaturaMaxima = 17,
                    DataPrevisao = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Wednesday)
                },
                new PrevisaoClima
                {
                    CidadeId = 4,
                    Clima = Enums.ClimaEnum.Frio,
                    TemperaturaMinima = 8,
                    TemperaturaMaxima = 15,
                    DataPrevisao = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Thursday)
                },
                new PrevisaoClima
                {
                    CidadeId = 4,
                    Clima = Enums.ClimaEnum.Tempestuoso,
                    TemperaturaMinima = 5,
                    TemperaturaMaxima = 10,
                    DataPrevisao = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Friday)
                },
                new PrevisaoClima
                {
                    CidadeId = 4,
                    Clima = Enums.ClimaEnum.Tempestuoso,
                    TemperaturaMinima = 5,
                    TemperaturaMaxima = 10,
                    DataPrevisao = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Saturday)
                },

            };

            return previsoes;

        }

    }
}
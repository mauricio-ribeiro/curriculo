using ClimaTempo.Enums;
using ClimaTempo.Helpers;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClimaTempo.Models
{
    public class PrevisaoClima
    {
        public int Id { get; set; }

        public ClimaEnum Clima { get; set; }

        public decimal TemperaturaMinima { get; set; }

        public decimal TemperaturaMaxima { get; set; }

        public DateTime DataPrevisao { get; set; }

        [NotMapped]
        public string DiaDaSemana => DayOfWeekHelper.DayOfWeekDescription(DataPrevisao);
        
        public int CidadeId { get; set; }

        public Cidade Cidade { get; set; }

        [NotMapped]
        public string TemperaturaMinimaStr => $@"Min {(int)TemperaturaMinima} °C";

        [NotMapped]
        public string TemperaturaMaximaStr => $@"Máx {(int)TemperaturaMaxima} °C";


    }
}
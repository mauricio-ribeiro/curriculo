using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClimaTempo.Enums
{
    public class ClimaEnum
    {
        private readonly string nome;
        public static ClimaEnum Calor { get; } = new ClimaEnum(1, "Calor");
        public static ClimaEnum Frio { get; } = new ClimaEnum(2, "Frio");
        public static ClimaEnum Tempestuoso { get; } = new ClimaEnum(3, "Tempestuoso");


        [NotMapped]
        public int Valor { get; private set; }
        public string Nome { get; private set; }

        public ClimaEnum()
        {
            // requerido pelo EF
        }

        public ClimaEnum(int valor, string nome)
        {
            Valor = valor;
            Nome = nome;
        }

        public IEnumerable<ClimaEnum> List()
        {
            return new[] { Calor, Frio, Tempestuoso };
        }

        public ClimaEnum FromString(string roleString)
        {
            return List().FirstOrDefault(r => string.Equals(r.Nome, roleString, StringComparison.OrdinalIgnoreCase));
        }

        public ClimaEnum FromValue(int valor)
        {
            return List().FirstOrDefault(r => r.Valor == valor);
        }



    }
}
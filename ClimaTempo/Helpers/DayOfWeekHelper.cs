using System;

namespace ClimaTempo.Helpers
{
    public static class DayOfWeekHelper
    {

        public static string DayOfWeekDescription(DateTime data)
        {
            DayOfWeek dow = data.DayOfWeek;
            string diaDaSemana = "";

            switch (dow)
            {
                case DayOfWeek.Sunday:
                    diaDaSemana = "Domingo";
                    break;
                case DayOfWeek.Monday:
                    diaDaSemana = "Segunda";
                    break;
                case DayOfWeek.Tuesday:
                    diaDaSemana = "Terça";
                    break;
                case DayOfWeek.Wednesday:
                    diaDaSemana = "Quarta";
                    break;
                case DayOfWeek.Thursday:
                    diaDaSemana = "Quinta";
                    break;
                case DayOfWeek.Friday:
                    diaDaSemana = "Sexta";
                    break;
                case DayOfWeek.Saturday:
                    diaDaSemana = "Sábado";
                    break;
            }

            return diaDaSemana;

        }

    }
}
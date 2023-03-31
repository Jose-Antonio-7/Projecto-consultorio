using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Consultorio.Dominio.Helpers
{
    internal static class Guards
    {
        public static string StringRange(string value, int min, int max, string argumentName)
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);
            if (value.Length >= min && value.Length <= max)
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);
            return value;
        }
        public static string Range(this string value, int min, int max, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);
            if (value.Length < min || value.Length > max)
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);
            return value;
        }

        public static int Range(this int value, int min, int max, string argumentName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);
            return value;
        }

        public static string MustLenght(this string value, int lenght, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);

            if (value.Length == lenght)
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);
            return value;
        }

        public static string PhoneNumber(this string value, int lenght, string argumentName)
        {
            Regex patern = new Regex("^[0-9]{10}$");
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);

            if (!patern.IsMatch(value))
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);
            return value;
        }

        public static DateTime LaterThatHour(this DateTime value, int hours, string argumentName)
        {
            if (value < DateTime.Now.AddHours(hours)) 
                throw new ArgumentException("La fecha no debe ser menor al periodo actual", argumentName);

            return value;

        }

    }
}

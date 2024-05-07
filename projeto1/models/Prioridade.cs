using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{
    public abstract class Prioridade
    {
        public static string Alta { get; set; } = "Alta";
        public static string Media { get; set; } = "Media";
        public static string Baixa { get; set; } = "Baixa";
    }
}
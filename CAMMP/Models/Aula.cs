using System;
using CAMMP.Models.Enums;

namespace CAMMP.Models
{
    public class Aula
    {
        public DiaSemana DiaDaSemana { get; set; }
        public DateTime Horario { get; set; }
        public int Duracao { get; set; }

        public Aula()
        {
        }

        public Aula(DiaSemana diaDaSemana, DateTime horario, int duracao)
        {
            DiaDaSemana = diaDaSemana;
            Horario = horario;
            Duracao = duracao;
        }
    }
}

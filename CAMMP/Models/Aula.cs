using System;
using System.ComponentModel.DataAnnotations;
using CAMMP.Models.Enums;

namespace CAMMP.Models
{
    public class Aula
    {
        public int Id { get; set; }

        [Display(Name = "Dia da Semana")]
        public DiaSemana DiaDaSemana { get; set; }

        [Display(Name = "Horário")]
        public DateTime Horario { get; set; }

        [Display(Name = "Duração")]
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

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
        public string Horario { get; set; }

        [Display(Name = "Duração (Minutos)")]
        public int Duracao { get; set; }

        public Aula()
        {
        }

        public Aula(DiaSemana diaDaSemana, string horario, int duracao)
        {
            DiaDaSemana = diaDaSemana;
            Horario = horario;
            Duracao = duracao;
        }
    }
}

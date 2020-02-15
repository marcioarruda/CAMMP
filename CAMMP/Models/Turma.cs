using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAMMP.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public Curso Curso { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public List<Aula> Aulas { get; set; } = new List<Aula>();

        public Turma()
        {
        }

        public Turma(int id, Curso curso, Professor professor)
        {
            Id = id;
            Curso = curso;
            Professor = professor;
        }
    }
}

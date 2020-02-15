using System;
using System.ComponentModel.DataAnnotations;

namespace CAMMP.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DtNascimento { get; set; }

        [Display(Name = "Matrícula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DtMatricula { get; set; }
        public string Sexo { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Aluno()
        {
        }

        public Aluno(int id, string nome, string cpf, DateTime dtNascimento, 
            DateTime dtMatricula, string sexo, string endereco, string bairro, 
            string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DtNascimento = dtNascimento;
            DtMatricula = dtMatricula;
            Sexo = sexo;
            Endereco = endereco;
            Bairro = bairro;
            Telefone = telefone;
            Email = email;
        }
    }

    
}

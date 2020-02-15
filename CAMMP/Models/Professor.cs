using System;
using System.ComponentModel.DataAnnotations;

namespace CAMMP.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DtNascimento { get; set; }

        [Display(Name = "Valor Hora")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double ValorHora { get; set; }
        public string Sexo { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Professor()
        {
        }

        public Professor(int id, string nome, string cpf, DateTime dtNascimento,
            double valorHora, string sexo, string endereco, string bairro,
            string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DtNascimento = dtNascimento;
            ValorHora = valorHora;
            Sexo = sexo;
            Endereco = endereco;
            Bairro = bairro;
            Telefone = telefone;
            Email = email;
        }
    }
}

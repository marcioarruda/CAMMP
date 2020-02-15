using System;
namespace CAMMP.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DtNascimento { get; set; }
        public double ValorHora { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
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

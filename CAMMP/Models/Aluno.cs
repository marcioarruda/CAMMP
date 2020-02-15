using System;

namespace CAMMP.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DtNascimento { get; set; }
        public DateTime DtMatricula { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
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

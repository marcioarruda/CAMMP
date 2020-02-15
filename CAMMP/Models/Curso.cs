using System.ComponentModel.DataAnnotations;

namespace CAMMP.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Preco { get; set; }

        public Curso()
        {
        }

        public Curso(int id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}

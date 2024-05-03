using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRUD_ACADEMICO.Models
{
    public class Instituicao 
    { 
        public int InstituicaoID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public ICollection<Departamento> Departamentos { get; set;}


    }
}


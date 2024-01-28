using System.ComponentModel.DataAnnotations;

namespace ProjetoCrud.Models
{
    public class Empresa
    {   
        public int Id { get; set; }
        [StringLength(20, ErrorMessage="A Razão Social deve ter no máximo 20 caracteres")]
        public string RazaoSocial { get; set; }
    }
}

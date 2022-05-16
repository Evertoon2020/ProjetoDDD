using System.ComponentModel.DataAnnotations;

namespace ProjetoDDD.Entities.Entities
{
    public class Product : Base
    {
        [Display(Name = "Preço")]
        public int Preco { get; set; }
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }
    }
}

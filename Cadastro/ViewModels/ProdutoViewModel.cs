using System.ComponentModel.DataAnnotations;

namespace Cadastro.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Produto")]
        [Required(ErrorMessage = "O nome do produto é requerido.")]
        public string Produto { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O Valor é requerido.")]
        public decimal Value { get; set; }

        [Display(Name = "Disponivel")]
        public bool Active { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication1.Models
{
    public class Kisi
    {
        [DisplayName("Kişi No")]
        [Required(ErrorMessage = "Id zorunlu alandır")]
        public int Id { get; set; }


        [DisplayName("Adı")]
        [Required(ErrorMessage = "Adı zorunlu alandır")]
        [MinLength(5, ErrorMessage = "Mininum 5 karakter girebilirsiniz.")]
        [MaxLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz.")]
        public string Name { get; set; }


        [DisplayName("Soyadı")]
        [Required(ErrorMessage = "Soyadı zorunlu alandır")]
        [MaxLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz.")]
        public string Surname { get; set; }

        [DisplayName("Telefon")]
        [Required(ErrorMessage = "Telefon zorunlu alandır")]
        [MaxLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz.")]
        public string Phone { get; set; }



        [MaxLength(500, ErrorMessage = "Maksimum 500 karakter girebilirsiniz.")]
        public string? ImageUrl { get; set; }
    }
}

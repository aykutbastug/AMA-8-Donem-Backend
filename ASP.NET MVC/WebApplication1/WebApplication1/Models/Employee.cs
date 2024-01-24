using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Employee
    {
        [DisplayName("Personel No")]
        [Required(ErrorMessage = "Id zorunlu alandır")]
        public int Id { get; set; }


        [DisplayName("Adı")]
        [Required(ErrorMessage = "Adı zorunlu alandır")]
        [MinLength(5, ErrorMessage = "Mininum 5 karakter girebilirsiniz.")]
        public string Name { get; set; }


        [DisplayName("Soyadı")]
        [Required(ErrorMessage = "Soyadı zorunlu alandır")]
        public string Surname { get; set; }


        [DisplayName("Görev")]
        public Gorevler Gorev { get; set; }


        [DisplayName("Durumu")]
        public bool Durumu { get; set; }
    }

    public enum Gorevler
    {
        Developer,
        TeamLead,
        ProjectManager
    }
}

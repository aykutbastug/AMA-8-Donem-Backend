using System.ComponentModel;

namespace WebApplication2.Models
{
    public class Employee
    {
        [DisplayName("Personel No")]
        public int Id { get; set; }

        [DisplayName("Adı")]
        public string Name { get; set; }


        [DisplayName("Soyadı")]
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

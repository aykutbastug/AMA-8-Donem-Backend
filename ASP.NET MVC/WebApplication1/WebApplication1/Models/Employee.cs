namespace WebApplication2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gorevler Gorev { get; set; }
        public bool Durumu { get; set; }
    }

    public enum Gorevler
    {
        Developer,
        TeamLead,
        ProjectManager
    }
}

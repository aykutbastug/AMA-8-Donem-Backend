using WebApplication2.Models;

namespace WebApplication1.Models
{
    public class PersonelDetayModel
    {
        public Employee  Employee { get; set; }

        public List<Izin> Izinler { get; set; }

        public DateTime Tarih { get; set; }
    }
}

using System.ComponentModel;

namespace BookStore.Entities
{
    public class EntityBase
    {

        [DisplayName("Kayıt No")]
        public int Id { get; set; }
    }
}

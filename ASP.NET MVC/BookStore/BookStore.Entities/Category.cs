using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities
{
    public class Category : EntityBase
    {

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "Kategori Adı zorunlu alandır")]
        [MaxLength(50, ErrorMessage = "Kategori Adı maksimum 50 karakter olmalıdır")]
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities
{
    public class Book : EntityBase
    {
        [DisplayName("Adı")]
        [Required(ErrorMessage = "Adı alanı zorunludur")]
        [MaxLength(50, ErrorMessage = "Adı alanı maksimum 50 karakter olmalıdır")]
        public string Name { get; set; }


        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "Kategori Adı alanı zorunludur")]
        public int CategoryId { get; set; }


        [DisplayName("Yazar Adı")]
        [Required(ErrorMessage = "Yazar Adı alanı zorunludur")]
        public int WriterId { get; set; }


        [DisplayName("Sayfa Sayısı")]
        public int PageCount { get; set; }


        [DisplayName("Birim Fiyatı")]
        [Required(ErrorMessage = "Birim Fiyatı alanı zorunludur")]
        public double Price { get; set; }


        [DisplayName("Yayın Tarihi")]
        public DateTime? PublishDate { get; set; }


        [DisplayName("Açıklama")]
        public string? Description { get; set; }



        [DisplayName("Resim")]
        [MaxLength(250, ErrorMessage = "Resim alanı maksimum 250 karakter olmalıdır")]
        public string? ImageUrl { get; set; }



        [DisplayName("Büyük Resim")]
        [MaxLength(250, ErrorMessage = "Büyük Resim alanı maksimum 250 karakter olmalıdır")]
        public string? BigImageUrl { get; set; }



        [DisplayName("Küçük Resim")]
        [MaxLength(250, ErrorMessage = "Küçük Resim alanı maksimum 250 karakter olmalıdır")]
        public string? SmallImageUrl { get; set; }
    }
}

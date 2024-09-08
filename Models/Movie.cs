using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "タイトル")]//項目の名前を日本語化
        public string? Title { get; set; } = string.Empty;

        [Display(Name = "公開年月日")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDAte { get; set; }

        [Display(Name = "ジャンル")]
        public string Genre { get; set; } = string.Empty;


        [Column(TypeName = "decimal(18, 2)")]//decimal 浮動小数点のデータ型
        [Display(Name = "価格")]
        public decimal Price { get; set; }
        public string Rating { get; set; } = string.Empty;

    }
}

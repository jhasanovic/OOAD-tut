using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OOAD_tutorijal_FINAL.Models
{
    public class Predmet
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Naziv predmeta")]
        [Required]
        [StringLength(maximumLength:50, MinimumLength =3, ErrorMessage ="Naziv predmeta smije imati između 3 i 50 karaktera!")]
        [RegularExpression(@"[0-9| |a-z|A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova, brojeva i razmaka!")]
        public string Naziv { get; set; }

        [Required]
        [Range(1.0, 10.0, ErrorMessage = "Broj ECTS bodova mora biti između 1 i 10!")]

        public double ECTS { get; set; }

        public Predmet() { }

    }
}

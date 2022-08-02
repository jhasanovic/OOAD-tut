using System.ComponentModel.DataAnnotations;

namespace OOAD_tutorijal_FINAL.Models
{
    public class Predmet
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }
        public double ECTS { get; set; }

    }
}

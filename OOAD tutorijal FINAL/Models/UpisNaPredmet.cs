using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD_tutorijal_FINAL.Models
{
    public class UpisNaPredmet
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Predmet")]
        public int PredmetId { get; set; }
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }

        [ValidateDate]
        [DataType(DataType.Date)]

        [DisplayName("Datum upisa")]
        public DateTime DatumUpisa { get; set; }
        public UpisNaPredmet() { }

    }

    public class ValidateDate : ValidationAttribute
    {
        protected override ValidationResult IsValid
        (object date, ValidationContext validationContext)
        {
            //ako je upis mlađi od 14 dana success, u suprotnom zabrani unos
            return ((DateTime)date >= DateTime.Now.AddDays(-14) &&
           (DateTime)date <= DateTime.Now)
            ? ValidationResult.Success
            : new ValidationResult("Validan je upis između 14 dana u prošlosti i danas!");
        }
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace OOAD_tutorijal_FINAL.Models
{
    public class Student
    {
        [Key]
        public int BrojIndeksa { get; set; }
        public VrstaStudenta Vrsta { get; set; }
        public int GodinaStudija { get; set; }

        public Student() { }
    }
}

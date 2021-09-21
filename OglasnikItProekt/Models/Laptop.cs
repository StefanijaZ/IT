using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace OglasnikItProekt.Models
{
    public class Laptop
    {

        public int LaptopID { get; set; }
        [Display(Name = "Слика")]

        public String imgURL { get; set; }
        [Display(Name = "Марка")]

        public String Ime { get; set; }
        [Display(Name = "Локација")]

        public String Lokacija { get; set; }
        [Display(Name = "Цена")]

        public int Cena { get; set; }
        [Display(Name = "Опис")]

        public String Opis { get; set; }
    }
}
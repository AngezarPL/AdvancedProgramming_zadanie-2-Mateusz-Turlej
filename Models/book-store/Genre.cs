using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AdvancedProgramming_Lesson1.Models.book_store
{
    public class Genre
    {
        [Display(Name = "#ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Nazwa gatunku jest wymagana")]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Data jest wymagana")]
        [Display(Name = "Data stworzenia")]
        [DataType(DataType.Date)]
        public DateTime DateOfCreation { get; set; }
        [Required(ErrorMessage = "kategoria jest wymagana")]
        [Display(Name = "Kategoria stworzenia")]
        public string Themes { get; set; }
        [Required(ErrorMessage = "Popularność jest wymagana")]
        [Range(1, int.MaxValue, ErrorMessage = "Podaj prawidłową popularność")]
        [Display(Name = "Popularność gatunku")]
        public decimal Popularity { get; set; }
        [Required(ErrorMessage = "Ilość książek jest wymagana")]
        [Range(1, int.MaxValue, ErrorMessage = "Nieprawidłowa ilość książek")]
        [Display(Name = "Ilość książek")]
        public int AmountOfBooksWorldwide { get; set; }
    }
}

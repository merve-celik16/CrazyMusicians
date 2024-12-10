using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models
{
    public class Musician
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name must be less than 50 characters")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Profession is required")]
        [StringLength(200, ErrorMessage = "Profession must be less than 200 characters")]
        public string Profession { get; set; } = "";

        [Required(ErrorMessage = "FunFeature is required")]
        [StringLength(200, ErrorMessage = "FunFeature must be less than 200 characters")]
        public string FunFeature { get; set; } = "";

       
    }
}

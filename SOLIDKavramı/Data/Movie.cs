using System.ComponentModel.DataAnnotations;

namespace SOLIDKavramı.Data
{

    public class Movie
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public DateTime Year { get; set; }
    }
}

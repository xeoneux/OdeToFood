using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required, MaxLength(80)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }

    public enum CuisineType
    {
        None,
        Indian,
        Italian,
        American
    }
}
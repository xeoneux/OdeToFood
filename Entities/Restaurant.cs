namespace OdeToFood.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
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
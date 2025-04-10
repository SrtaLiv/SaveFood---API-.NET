namespace MyConsoleApp.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}

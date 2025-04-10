using MyConsoleApp.Models;

namespace MyConsoleApp.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        private readonly BloggingContext _context;

        public FoodRepository(BloggingContext context)
        {
            _context = context;
        }

        public List<Food> GetFoods()
        {
            return _context.Foods.ToList();
        }

        public Food getFoodById(int foodId)
        {
            return _context.Foods.Find(foodId);
        }

        public void save(Food food)
        {
            _context.Foods.Add(food);
            _context.SaveChanges();
        }

        public void delete(int foodId)
        {
            var food = _context.Foods.Find(foodId);
            if (food != null)
            {
                _context.Foods.Remove(food);
                _context.SaveChanges();
            }
        }

        public Food updateFood(Food food)
        {
            _context.Foods.Update(food);
            _context.SaveChanges();
            return food;
        }

        public Food updateFoodImage(Food food)
        {
            _context.Foods.Update(food);
            _context.SaveChanges();
            return food;
        }
    }
}

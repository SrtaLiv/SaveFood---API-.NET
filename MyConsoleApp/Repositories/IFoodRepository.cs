using MyConsoleApp.Models;

namespace MyConsoleApp.Repositories
{
    public interface IFoodRepository
    {
        List<Food> GetFoods();
        Food getFoodById(int foodId);
        void save(Food food);
        void delete(int foodId);
        Food updateFood(Food food);
        Food updateFoodImage(Food food); // falta file
    }
}
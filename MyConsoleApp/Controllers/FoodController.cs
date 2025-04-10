using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using MyConsoleApp.Models;
using MyConsoleApp.Services;
using System.Threading.Tasks;

namespace MyConsoleApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController
    {
        private readonly FoodService FoodService;

        public FoodController(FoodService foodService)
        {
            this.FoodService = foodService;
        }

        [HttpPost]
        public Food saveFood(string foodJson)
        {
            var food = JsonSerializer.Deserialize<Food>(foodJson);
            var saved = FoodService.Save(food);
            return saved;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var foods = await _foodRepository.GetAllAsync();
            return Ok(foods);
        }

   
    }
}
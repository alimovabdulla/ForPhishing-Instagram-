
using For_Instagram.DataContext;
using For_Instagram.Models;
using Microsoft.AspNetCore.Mvc;
namespace For_Instagram.Controllers
{
    public class InstagramController : Controller
    {
        private readonly dbContext _dbcontext;

        public InstagramController(dbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(); // Возвращаем форму логина
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            

            // Добавление данных в базу
            _dbcontext.Login.Add(login);
            await _dbcontext.SaveChangesAsync(); // Ожидаем завершения сохранения

            // Перенаправление на другую страницу после успешного сохранения
            return RedirectToAction("Success"); // Предполагается, что у вас есть метод для отображения успешного действия
        }

        public IActionResult Success()
        {
            return View(); // Возвращаем представление успешного логина
        }
    }
}


using api_desafio21dias.ModelsViews;
using Microsoft.AspNetCore.Mvc;

namespace api_desafio21dias.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {    

        [HttpGet]
        public HomeView Index()
        {
            return new HomeView();
        }
    }
}

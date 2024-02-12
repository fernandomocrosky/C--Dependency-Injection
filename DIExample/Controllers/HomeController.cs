using Microsoft.AspNetCore.Mvc;

namespace DIExample.Controllers;
using Services;
using ServiceContracts;

public class HomeController : Controller
{

    private readonly ICitiesService _citiesServices;

    public HomeController()
    {
        _citiesServices = new CitiesService();
    }

    [Route("/")]
    public IActionResult Index()
    {
        List<string> cities = _citiesServices.GetCities();
        return View(cities);
    }
}

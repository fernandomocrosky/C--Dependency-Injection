using Microsoft.AspNetCore.Mvc;

namespace DIExample.Controllers;
using Services;
using ServiceContracts;

public class HomeController : Controller
{

    private readonly ICitiesService _citiesServices;

    public HomeController(ICitiesService citiesService)
    {
        _citiesServices = citiesService;
    }

    [Route("/")]
    public IActionResult Index()
    {
        List<string> cities = _citiesServices.GetCities();
        return View(cities);
    }
}

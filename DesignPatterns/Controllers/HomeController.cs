using DesignPatterns.Creators;
using DesignPatterns.Models;
using DesignPatterns.Models.Builder;
using DesignPatterns.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Controllers
{
    public class HomeController : Controller
    {
        // _logger es una instancia de ILogger<T> utilizada para realizar registros o loggings.
        private readonly ILogger<HomeController> _logger;

        // _vehicleRepository es una instancia de IVehicleRepository utilizada para interactuar con el repositorio de vehículos.
        private readonly IVehicleRepository _vehicleRepository;

        // Constructor de la clase HomeController, que recibe instancias de IVehicleRepository y ILogger<HomeController>.
        public HomeController(IVehicleRepository vehicleRepository, ILogger<HomeController> logger)
        {
            // Se asigna la instancia de IVehicleRepository recibida al campo _vehicleRepository.
            _vehicleRepository = vehicleRepository;

            // Se asigna la instancia de ILogger<HomeController> recibida al campo _logger.
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();
            model.Vehicles = _vehicleRepository.GetVehicles();
            string error = Request.Query.ContainsKey("error") ? Request.Query["error"].ToString() : null;
            ViewBag.ErrorMessage = error;

            return View(model);
        }

        /*[HttpGet]
        public IActionResult AddMustang()
        {
            // Se crea un nuevo constructor de modelos de automóviles (CarModelBuilder).
            var builder = new CarModelBuilder();

            // Se construye un vehículo utilizando el constructor de modelos y se agrega al repositorio de vehículos.
            _vehicleRepository.AddVehicle(builder.Build());

            // Se redirige al usuario a la página de inicio ("/") después de agregar el vehículo.
            return Redirect("/");
        }*/

        [HttpGet]
        public IActionResult AddMustang()
        {
            // Se crea un creador concreto específico para el modelo Mustang.
            Creator creator = new FordMustangCreator();

            // Se utiliza el Factory Method para crear una instancia específica de Vehicle (Mustang) y se agrega al repositorio de vehículos.
            _vehicleRepository.AddVehicle(creator.Create());

            // Se redirige al usuario a la página de inicio ("/") después de agregar el vehículo.
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult AddExplorer()
        {
            // Se crea un creador concreto específico para el modelo Explorer.
            Creator creator = new FordExplorerCreator();

            // Se utiliza el Factory Method para crear una instancia específica de Vehicle (Explorer) y se agrega al repositorio de vehículos.
            _vehicleRepository.AddVehicle(creator.Create());

            // Se redirige al usuario a la página de inicio ("/") después de agregar el vehículo.
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult StartEngine(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.StartEngine();
                return Redirect("/");
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
          
        }

        [HttpGet]
        public IActionResult AddGas(string id)
        {

            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.AddGas();
                return Redirect("/");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult StopEngine(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.StopEngine();
                return Redirect("/");
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
           
           
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

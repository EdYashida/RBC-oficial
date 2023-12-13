using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RBC_oficial.Models;
using RBC_oficial.Repositorio;

namespace RBC_oficial.Controllers;


    
    public class CasoController : Controller
    {
        private readonly ICasoRepositorio _casoRepositorio;
        public CasoController(ICasoRepositorio casoRepositorio)
        {
            _casoRepositorio = casoRepositorio;
        }
        public IActionResult Index()
        {
            
           List<CasoModel> casos= _casoRepositorio.BuscarTodos();
            return View(casos);
        }
        public IActionResult Criar()
        {
            return View();
        }
       [HttpPost]
        public IActionResult Criar(CasoModel caso)
        {
            if(ModelState.IsValid){
            _casoRepositorio.Adicionar(caso);
            return RedirectToAction("Index");
            }

            return View(caso);

            
        }
    }
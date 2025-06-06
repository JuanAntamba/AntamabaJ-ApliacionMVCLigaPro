﻿using AntamabaJ_ApliacionMVCLigaPro.Models;
using AntamabaJ_ApliacionMVCLigaPro.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AntamabaJ_ApliacionMVCLigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            EquipoRepository equipoRepository = new EquipoRepository();
            var equipos = equipoRepository.DevuelveListadoEquipos();

            return View(equipos);
       
        }
        public IActionResult Edit(int Id)
        {
            EquipoRepository repository = new EquipoRepository();
            var equipo = repository.DevuelveInfoEquipo(Id);
            return View(equipo);
        }
    }
}

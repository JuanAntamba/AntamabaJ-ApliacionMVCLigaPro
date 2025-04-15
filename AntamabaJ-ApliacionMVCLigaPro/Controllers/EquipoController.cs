using AntamabaJ_ApliacionMVCLigaPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace AntamabaJ_ApliacionMVCLigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PatidosJugados = 20,
                PartidosGanados = 15,
                PartidosEmpatados = 5,
                PartidosPerdidos =0
            };
            equipos.Add(ldu);

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona SC",
                PatidosJugados = 20,
                PartidosGanados = 10,
                PartidosEmpatados = 5,
                PartidosPerdidos = 5
            };
            equipos.Add(bsc);

            Equipo nacional = new Equipo
            {
                Id = 3,
                Nombre = "Nacional",
                PatidosJugados = 20,
                PartidosGanados = 9,
                PartidosEmpatados = 9,
                PartidosPerdidos = 2
            };
            equipos.Add(nacional);

            Equipo emelec= new Equipo
            {
                Id = 3,
                Nombre = "Emelec",
                PatidosJugados = 20,
                PartidosGanados = 1,
                PartidosEmpatados = 11,
                PartidosPerdidos = 8
            };
            equipos.Add(nacional);

            Equipo idv = new Equipo
            {
                Id = 3,
                Nombre = "Independiente del Valle",
                PatidosJugados = 20,
                PartidosGanados = 5,
                PartidosEmpatados = 10,
                PartidosPerdidos = 5
            };
            equipos.Add(idv);

            return View();
        }
    }
}

using AntamabaJ_ApliacionMVCLigaPro.Interfaces;
using AntamabaJ_ApliacionMVCLigaPro.Models;

namespace AntamabaJ_ApliacionMVCLigaPro.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.Id==Id).First();
            return equipo;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PatidosJugados = 20,
                PartidosGanados = 15,
                PartidosEmpatados = 5,
                PartidosPerdidos = 0
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
            Equipo emelec = new Equipo
            {
                Id = 4,
                Nombre = "Emelec",
                PatidosJugados = 20,
                PartidosGanados = 1,
                PartidosEmpatados = 11,
                PartidosPerdidos = 8
            };
            equipos.Add(emelec);
            Equipo idv = new Equipo
            {
                Id = 5,
                Nombre = "Independiente del Valle",
                PatidosJugados = 20,
                PartidosGanados = 12,
                PartidosEmpatados = 6,
                PartidosPerdidos = 2
            };
            equipos.Add(idv);

            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}

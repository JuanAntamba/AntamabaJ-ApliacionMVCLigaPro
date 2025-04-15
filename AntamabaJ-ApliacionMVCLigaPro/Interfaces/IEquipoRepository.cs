using AntamabaJ_ApliacionMVCLigaPro.Models;

namespace AntamabaJ_ApliacionMVCLigaPro.Interfaces
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int Id);
        bool CrearEquipo();
        bool ActualizarEquipo();
        bool EliminarEquipo();
        

    }
}

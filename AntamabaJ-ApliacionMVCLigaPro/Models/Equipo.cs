﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AntamabaJ_ApliacionMVCLigaPro.Models
{

    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName("Nombre del equipo: ")]
        [Required]
        public string Nombre { get; set; }
        [Range(0, 20)]
        public int PatidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        public int Puntos
        {
            get
            {
                int puntos = (PartidosGanados * 3) + (PartidosEmpatados * 1);
                return puntos;
            }
        }
    }
}

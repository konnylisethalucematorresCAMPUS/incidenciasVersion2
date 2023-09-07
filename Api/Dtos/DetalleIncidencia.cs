using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class DetalleIncidencia
    {
        public int Id_Incidence { get; set; }
        public int Id_Peripheral { get; set; }
        public int Id_LevelIncidence { get; set; }
        public int Id_TypeIncidence { get; set; }
        public int Id_State { get; set; }
        public string ?Description_DetailIncidence { get; set; }

    }
}
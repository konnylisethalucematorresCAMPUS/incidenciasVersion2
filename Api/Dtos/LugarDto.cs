using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class LugarDto
    {
        public int Id {get;set;}
        public string ?Name_Place { get; set; }
        public int ?Id_AreaOrigin { get; set; }
        public string ?Description_Place { get; set; }
    }
}
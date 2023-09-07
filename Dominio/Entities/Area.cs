using System.ComponentModel.DataAnnotations;
using Dominio;

namespace Entities;

public class Area : BaseEntity
{
    
    public ICollection<Lugar> ? Places { get; set; }
    public string ?Name_Area { get; set; }
    public ICollection<AreaUsuario> ? AreaUsuarios { get; set; }

    public string ? Description_Incidence { get; set; }
    public ICollection<Incidencia> ? Incidencias { get; set; }

    public string ?Description_Area { get; set; }
}

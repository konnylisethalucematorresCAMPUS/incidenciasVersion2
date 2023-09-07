using System.ComponentModel.DataAnnotations;
using Entities;
namespace Dominio;

public class Usuario : BaseEntity
{
    public string ? Username { get; set; }
    public string ? Email { get; set; }
    public string ? Password { get; set; }
    public int UserId {get;set;}
    public ICollection<Rol> Rol { get; set; } = new HashSet<Rol>();
    public ICollection<UsuarioRoles> ? UsuariosRoles { get; set; }
}

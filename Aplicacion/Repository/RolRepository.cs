using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository;

public class RolRepository : GenericRepository<Rol>, IRolRepository
{
    public RolRepository(ApiContext context) : base(context)
    {  
        
    }
}

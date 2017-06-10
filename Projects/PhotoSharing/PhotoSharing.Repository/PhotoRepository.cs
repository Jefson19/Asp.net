using PhotoSharing.DataAccess;
using PhotSharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharing.Repository
{
    public class PhotoRepository : BaseRepository<Photo>
    {
       public IEnumerable<Photo>Listar(Expression<Func<Task,bool>> filtro = null)
        {

        }
    }
 }


using PhotoSharingCepedi.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingCepedi.Repository
{
    public abstract class BaseRepository<T> where T : class
    {
        protected DataContext dataContext;

        // Construtores
        public BaseRepository()
        {
            if (dataContext == null)
            {
                dataContext = new DataContext();
            }
        }

        public BaseRepository(DataContext context)
        {
            dataContext = context;
        }

        // Adiciona uma enditade
        public void Adicionar(T entidade)
        {
            dataContext.Set<T>().Add(entidade);
            dataContext.SaveChanges();
        }

        // Lista enditades
        public IEnumerable<T> Listar(Expression<Func<T, bool>> filtro = null)
        {
            if (filtro == null)
            {
                return dataContext.Set<T>().ToList();
            }
            return dataContext.Set<T>()
                .Where(filtro).ToList();
        }

        // Exclui uma enditade
        public void Excluir(int id)
        {
            T entidade = dataContext.Set<T>().Find(id);
            dataContext.Set<T>().Remove(entidade);
            dataContext.SaveChanges();
        }

        // Obtem uma entidade por ID
        public T ObterPorId(int id)
        {
            return dataContext.Set<T>().Find(id);
        }

    }
}

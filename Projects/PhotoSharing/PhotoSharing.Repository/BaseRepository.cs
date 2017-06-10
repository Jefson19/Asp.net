using PhotoSharing.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharing.Repository
{
    public abstract class BaseRepository <T> where T:class //vai receber uma classe generica   
    {
        protected DataContext contexto;

        public BaseRepository()
        {
            if (contexto == null)
            {
                contexto = new DataContext();
            }
        }

        public BaseRepository(DataContext dbcontexto)
        {
            contexto = dbcontexto;
        }

        public void Adicionar(T entidade)
        {
            contexto.Set<T>().Add(entidade);
            contexto.SaveChanges();
        }
        public virtual IEnumerable<T> Listar(
            int quantidade,
            string ordenacao,
            Expression<Func<T,bool>>
            )
        {
            var query = DataContext.Set<T>().AsQueryable();
        }
        public IEnumerable<T> Listar(Expression<Func<T, bool>> filtro = null)
        {
            if (filtro == null)
            {
                return contexto.Set<T>().ToList();
            }
            return contexto.Set<T>().Where(filtro).ToList();
        }



        public void Excluir(int id)
        {
            T entidade = contexto.Set<T>().Find(id);
            contexto.Set<T>().Remove(entidade);
            contexto.SaveChanges();
        }

        public T ObterPorId(int id)
        {
            return contexto.Set<T>().Find(id);
        }
    }
}

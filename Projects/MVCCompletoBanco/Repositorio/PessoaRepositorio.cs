using AcessoDados;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
   public class PessoaRepositorio
    {
        private ContextoDados db;
        public PessoaRepositorio()
        {
            if (db==null)
            {
                db = new ContextoDados();
            }
        }


        public IEnumerable<Pessoa> Listar()
        {
            return db.Pessoas.ToList();
        }
        public Pessoa ObterPorId(int id)
        {
            return db.Pessoas.Find(id);
        }
        public void Adicionar(Pessoa pessoa)
        {
            db.Pessoas.Add(pessoa);
            db.SaveChanges();
        }
        public void Editar(Pessoa pessoa)
        {
            db.Entry(pessoa).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Excluir(int id)
        {
            Pessoa pessoa = ObterPorId(id);
            db.Pessoas.Remove(pessoa);
            db.SaveChanges();
        }
    }
}

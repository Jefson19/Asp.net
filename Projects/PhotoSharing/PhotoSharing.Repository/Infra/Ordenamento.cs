using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharing.Repository.Infra
{
    class Ordenamento
    {
        public bool IsAsc { get; set; }
        public  Exception<Func<T,Key>>ExpressaoOrdenacao { get; set; }
    }
}

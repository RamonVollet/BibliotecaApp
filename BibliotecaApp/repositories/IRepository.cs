using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Repositories
{
    public interface IRepository<T>
    {
        void Inserir(T entidade);
        IEnumerable<T> BuscarTodos();
        void Editar(T entidade);
        void Excluir(int id);
    }
}
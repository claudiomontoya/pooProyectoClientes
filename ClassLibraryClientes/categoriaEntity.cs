using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClientes
{
    public class categoriaEntity : ICrud
    {
        public int actualizar()
        {
            return 3;
        }

        public DataSet buscar(string texto)
        {
            throw new NotImplementedException();
        }

        public int eliminar()
        {
            throw new NotImplementedException();
        }

        public int guardar(object objeto)
        {
            throw new NotImplementedException();
        }

        public DataSet listar()
        {
            throw new NotImplementedException();
        }
    }
}

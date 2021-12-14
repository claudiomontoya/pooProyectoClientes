using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClientes
{
    public interface ICrud
    {
        int guardar(object objeto);
        int eliminar();
        int actualizar();
        DataSet listar();
        DataSet buscar(string texto);
    }
}

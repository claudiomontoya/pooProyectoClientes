using ClassLibraryClientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            clienteEntity cliente = new clienteEntity();

            DataSet data = cliente.listadoClientes();

            Console.WriteLine("rut "+data.Tables[0].Rows[0].ItemArray[0]);
            Console.WriteLine("nombre " + data.Tables[0].Rows[0].ItemArray[1]);
            Console.WriteLine("apellido " + data.Tables[0].Rows[0].ItemArray[2]);
            Console.WriteLine("telefono " + data.Tables[0].Rows[0].ItemArray[3]);
            Console.ReadKey();

        }
    }
}

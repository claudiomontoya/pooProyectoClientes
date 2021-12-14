using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsClientes
{
    public static class global
    {
        public static string usuario { get; set; }

        public static void mensaje(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }

        public static int calcularIMC(int peso, int altura)
        {
            return 0;
        }

    }
}

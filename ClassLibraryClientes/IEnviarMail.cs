using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClientes
{
    public interface IEnviarMail
    {
        void enviar(string asunto, string destinatario, string mensaje);
    }
}

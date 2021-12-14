using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClientes
{
    public class campaniasMarketing
    {
        public IEnviarMail enviarMail;

        public campaniasMarketing(IEnviarMail enviar)
        {
            this.enviarMail = enviar;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.EjemploSenial.Utils.Auditable
{
    public class IAuditable
    {
        void Inicializar(string usuario, string programa, string accion);

        void Auditar();


    }
}

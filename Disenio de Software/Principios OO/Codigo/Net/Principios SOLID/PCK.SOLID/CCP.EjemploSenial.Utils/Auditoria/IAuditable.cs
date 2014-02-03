using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCP.EjemploSenial.Utils
{
    public interface IAuditable
    {
        void Auditar(object usuario, object programa, object accion);
    }
}

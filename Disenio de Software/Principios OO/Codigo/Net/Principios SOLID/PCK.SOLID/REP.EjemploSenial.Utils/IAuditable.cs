using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REP.EjemploSenial.Utils
{
    public interface IAuditable
    {
        void IniAuditoria(string auditor);

        void Auditar(object usuario, object programa, object accion);


    }
}

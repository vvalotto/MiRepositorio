﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Consola
{
    public interface IAuditable
    {
        void Auditar(object usuario, object programa, object accion);
    }
}

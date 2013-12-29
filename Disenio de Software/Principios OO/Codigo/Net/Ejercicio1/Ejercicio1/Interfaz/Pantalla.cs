using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaz;

namespace Interfaz
{        
    public enum TipoPantalla
        {
            TipoMenu,
            TipoFormulario
        };

    abstract public class Pantalla
    {
        public TipoPantalla _pantalla;
        public string _titulo = string.Empty;

        public virtual void MostrarTitulo()
        {
        }

        public virtual void VolverPantallaAnterior()
        {
        }
    }
}

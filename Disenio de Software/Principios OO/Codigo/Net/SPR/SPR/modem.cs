using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPR
{
    
    /// <summary>
    /// Ejemplo de violación al principio de SPR
    /// </summary>
    public interface modem
    {
        //En es caso la funciones de conexión y de transferencia de datos.
        //Si es 


    }


    public interface DataChannel
    {
         void Sender (char c);
         char Recv();        
    }

    public interface Connection
    {    
         void Dial(string pno);
         void Hangup();
    }

    public class ModemImp : Connection, DataChannel
    {
        // Implementación del modem
        public void Dial(string pno)
        {
            throw new NotImplementedException();
        }

        public void Hangup()
        {
            throw new NotImplementedException();
        }

        public void Sender(char c)
        {
            throw new NotImplementedException();
        }

        public char Recv()
        {
            throw new NotImplementedException();
        }
    }
}

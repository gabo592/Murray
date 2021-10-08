using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murray.Observable
{
    public interface ISujeto
    {
        void Notificar();
        void AgregarObservador(IObservador observador);
    }
}

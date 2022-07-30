using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Decorator.Class
{
    public abstract class DipositivoDecorator : IDispositivos
    {
        protected IDispositivos dispositivos;

        public DipositivoDecorator(IDispositivos dispositivos)
        {
            this.dispositivos = dispositivos;
        }

        public abstract string getOrden();
        public abstract string getDisposivoDescription();

        public abstract string getClienteDueñoDisposito();

    }
}

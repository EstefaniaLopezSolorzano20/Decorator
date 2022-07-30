using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Decorator.Class
{
    public class Celular : DipositivoDecorator
    {
        public Celular(IDispositivos dispositivos) : base(dispositivos)
        {
        }

        public override string getOrden()
        {
            return this.dispositivos.getOrden();
        }

        public override string getDisposivoDescription()
        {

            return this.dispositivos.getDisposivoDescription() +"\nHardware adicional: " +"Audifonos" + "+Cargador";
        }

        public override string getClienteDueñoDisposito()
        {
            return this.dispositivos.getClienteDueñoDisposito();
        }

    }
}

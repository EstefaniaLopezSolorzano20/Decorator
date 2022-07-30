using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Class
{
    public class Dispositivo : IDispositivos

    {
        public string orden;

        public string imei;

        public string marca;

        public string modelo;

        public string sistemaoperativo;

        public string nombredueño;

        public string apellidodueño;

        public string ceduladueño;

        public string? chip;

        public string? region;


        public Dispositivo(string orden, string imei, string marca, string modelo, string sistemaoperativo, string nombredueño, string apellidodueño, string ceduladueño, string? chip, string? region)
        {
            this.orden = orden;
            this.imei = imei;
            this.marca = marca;
            this.modelo = modelo;
            this.sistemaoperativo = sistemaoperativo;
            this.nombredueño = nombredueño;
            this.apellidodueño = apellidodueño;
            this.ceduladueño = ceduladueño;
            this.chip = chip;
            this.region = region;
        }


        public string getOrden()
        {
            return "\nNº :"+ this.orden;
        }
    
        public string getDisposivoDescription()
        {
            if (this.chip == null)
            {
                return this.chip = "No tiene chip" + "\nImei:" + this.imei + "\nMarca:" + this.marca + "\nModelo:" + this.modelo + "\nSistemaOperativo:" + this.sistemaoperativo ;
            }
            return "\nImei:" + this.imei + "\nMarca:" + this.marca + "\nModelo:"+ this.modelo +"\nSistemaOperativo:" +this.sistemaoperativo + "\nNumeroChip:" + this.chip + "\nRegion:" + this.region;
        }
        
        public string getClienteDueñoDisposito()
        {
            return "\nNombre del usuario:" + this.nombredueño + "\nApellido del usuario:" + this.apellidodueño + "\nCédula del usuario:" + this.ceduladueño;
        }



    }
}

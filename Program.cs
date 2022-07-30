using System;
using Decorator.Class;
using Decorator.Interfaces;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dispositivo dispositivo1 = new Dispositivo("orden1","123455231","Realme","XT", "Android 12","Stefy", "Lopez", "1317865390","9874751342","Italia");



            Dispositivo dispositivo2 = new Dispositivo("orden2","32312312", "Xiami", "PRO", "Android 13", "Viviana", "Cedeño","13145121221", null, null);

            Dispositivo dispositivo3 = new Dispositivo("orden3", "123455231", "Motorola", "GT", "Android 10", "Yami", "Palacio", "131425334", "09874929302", "España");



            Celular celular = new Celular(dispositivo1);


            Celular celular2 = new Celular(dispositivo3);


            Tablet tablet = new Tablet(dispositivo2);


            Console.WriteLine("---------LISTADO REPARACIÓN CELULARES ----------");
            Console.WriteLine("\n-----Número de orden:\n" + celular.getOrden());
            Console.WriteLine("\n-----Equipo a reparar:\n"+celular.getDisposivoDescription());
            Console.WriteLine("\n-----Propietario del dispostivo: " + celular.getClienteDueñoDisposito());


            Console.WriteLine("\n-----Número de orden:\n" + celular2.getOrden());
            Console.WriteLine("\n-----Equipo a reparar:\n" + celular2.getDisposivoDescription());
            Console.WriteLine("\n-----Propietario del dispostivo: " + celular2.getClienteDueñoDisposito());

            Console.WriteLine("\n---------LISTADO REPARACIÓN TABLET----------");

            Console.WriteLine("\n-----Número de orden:\n" + tablet.getOrden());
            Console.WriteLine("\n-----Equipo a reparar:\n" + tablet.getDisposivoDescription());
            Console.WriteLine("\n-----Propietario del dispositivo: " + tablet.getClienteDueñoDisposito());







        }
    }
}
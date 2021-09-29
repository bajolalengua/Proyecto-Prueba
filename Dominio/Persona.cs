using System.Reflection.Metadata.Ecma335;
using System;
namespace Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Fecha_Nacimiento { get; set; }

        // public void calcular_Edad()
        // {
        //     DateTime nacimiento, actualL;
        //     int edad;
        //     actualL = DateTime.Today;

        //     Console.WriteLine("Ingrese su fecha de naciemiento en el formato DD-MM-YYYY");
        //     nacimiento = Convert.ToDateTime(Console.ReadLine());

        //     if(actualL.Year == nacimiento.Year)
        //     {
        //         Console.WriteLine("Fecha equivocada, se selecciono la fecha actual. Por favor intente nuevamente");
        //     }
        //     else
        //     {
        //         if(nacimiento.Year > actualL.Year)
        //         {
        //             Console.WriteLine("Ha ingresado una fecha futura, por favor ingrese una fecha de naciemiento valida");
        //         }
        //         else
        //         {
        //             edad = actualL.Year - nacimiento.Year;
        //             Console.WriteLine("Edad: " + edad + "años");
        //         }
        //     }
        // }

    }
}
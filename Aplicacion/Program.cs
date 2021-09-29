using System;
using Dominio;
using Persistencia;
namespace Aplicacion
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AplicationContext());
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // addPersona();
            // deletePersona();
            //update_Persona();
            // listar_Personas();
            detailPersona(9);
            Console.WriteLine("Listado");
        }
        
        private static void addPersona(){
            var persona = new Persona{

                Nombre = "Julian Hernandez",
                Fecha_Nacimiento = "18/11/1997"
            };
            _repoPersona.addPersona(persona);
        }
        private static void deletePersona(){
            _repoPersona.DeletePersona(8);
        }
        private static void update_Persona(){
            var persona = new Persona{
                Id = 9,
                Nombre = "Carlos NN",
                Fecha_Nacimiento = "08/05/1990"
            };
            _repoPersona.updatePersona(persona);
        }

        private static void listar_Personas(){
            _repoPersona.GetAllPersonas();
        }

        private static void detailPersona(int idPersona){
            var persona = _repoPersona.GetPersona(idPersona);
            Console.WriteLine("Nombre: "+persona.Nombre+" "+"Fecha de Nacimiento: "+persona.Fecha_Nacimiento);
        }

    }
    
}

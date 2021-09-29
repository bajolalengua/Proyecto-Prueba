using System;
using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        Persona addPersona(Persona persona);
        Persona updatePersona(Persona persona);
        Boolean DeletePersona(int idPersona);
        Persona GetPersona(int idPersona);
    }
}
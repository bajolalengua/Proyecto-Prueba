using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AplicationContext _appContext;
        public RepositorioPersona(AplicationContext appContext){
            _appContext = appContext;
        }
        public Persona addPersona(Persona persona)
        {
            var new_Persona = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return new_Persona.Entity;
        }

        public bool DeletePersona(int idPersona)
        {
            var Delete_Persona = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            if(Delete_Persona == null)
            return false;
            _appContext.Remove(Delete_Persona);
            _appContext.SaveChanges();
            return true;
        }

        public IEnumerable<Persona> GetAllPersonas()
        {
            return _appContext.Personas;
        }

        public Persona GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
        }

        public Persona updatePersona(Persona persona)
        {
            var update_Persona = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if(update_Persona != null){
                update_Persona.Nombre = persona.Nombre;
                update_Persona.Fecha_Nacimiento = persona.Fecha_Nacimiento;
                _appContext.SaveChanges();
            }
            return update_Persona;
        }
    }
}
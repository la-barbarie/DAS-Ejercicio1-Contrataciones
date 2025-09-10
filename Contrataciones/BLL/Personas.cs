using System;
using System.Collections.Generic;
using System.Linq;
using BE.dto;

namespace BLL
{
    public class Personas
    {
        // Inserta una nueva persona en la base de datos
        public int InsertarPersona(string nombre, string apellido, int edad, bool sexo, BE.Nacionalidad nacionalidad, BE.Profesion profesion)
        {
            try
            {
                // Se instancia el mapper de DAL
                DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();

                // Se crea el objeto de negocio Persona
                BE.Persona p = new BE.Persona();

                // Validacion de nombre
                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else p.Nombre = nombre;

                // Validacion de apellido
                if (string.IsNullOrWhiteSpace(apellido)) throw new Exception("El apellido es invalido");
                else p.Apellido = apellido;

                // Se evita que la edad sea negativa
                p.Edad = Math.Abs(edad);

                p.Sexo = sexo; //SEXO ES UN BOOL 
                //0 - Mujer (pq son falsas y mentirosas)
                //1 - Hombre (pq somos superiores y siempre verdaderos)

                // Se asigna nacionalidad y profesion usando los ids
                p.Nacionalidad = nacionalidad.IdNacionalidad;
                p.Profesion = profesion.IdProfesion;

                // Se inserta en la base de datos
                return mp.Insert(p);

            }
            catch (Exception e) { throw e; }

        }

        // Elimina una persona por id
        public int RemoverPersona(int numero)
        {
            DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
            return mp.Delete(numero);
        }

        // Edita los datos de una persona existente
        public int EditarPersona(int id, string nombre, string apellido, int edad, bool sexo, BE.Nacionalidad nacionalidad, BE.Profesion profesion)
        {
            try
            {

                DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();

                BE.Persona p = new BE.Persona();

                p.NumeroPersona = id;

                // Validacion de nombre
                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else p.Nombre = nombre;

                // Validacion de apellido
                if (string.IsNullOrWhiteSpace(apellido)) throw new Exception("El apellido es invalido");
                else p.Apellido = apellido;

                // Evitamos edades negativas
                p.Edad = Math.Abs(edad);

                p.Sexo = sexo; //SEXO ES UN BOOL 
                //0 - Mujer (pq son falsas y mentirosas)
                //1 - Hombre (pq somos superiores y siempre verdaderos)

                // Se asigna nacionalidad y profesion
                p.Nacionalidad = nacionalidad.IdNacionalidad;
                p.Profesion = profesion.IdProfesion;

                // Actualiza en la base de datos
                return mp.Update(p);

            }
            catch (Exception e) { throw e; }
        }

        // Busca una persona por id
        public BE.Persona GetById(int id)
        {
            DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
            return mp.FindById(id);
        }

        // Lista todas las personas
        public List<BE.Persona> ListarPersonas()
        {
            DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
            return mp.GetAll();
        }

        // Obtiene el promedio de edad de todas las personas
        public int GetPromedioEdad()
        {
            DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
            return mp.GetPromedioEdad();
        }

        // Obtiene la cantidad total de personas
        public int GetCantidad()
        {
            DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
            return mp.GetCantidadPersonas();
        }

        // Obtiene la edad minima registrada
        public int GetMinEdad()
        {
            DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
            return mp.GetMinOrMaxAge((int)BE.enums.EOrden.MIN);
        }

        // Obtiene la edad maxima registrada
        public int GetMaxEdad()
        {
            DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
            return mp.GetMinOrMaxAge((int)BE.enums.EOrden.MAX);
        }

        // Obtiene la cantidad de personas para una nacionalidad especifica
        public int GetCantidadPersonasPorNacionalidad(int id) //ID de nacionalidad
        {
            DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
            List<PersonasNacionalidadDTO> promedio = mp.GetCantidadPersonasPorNacionalidad(id);

            int cantidad = 0;
            foreach(PersonasNacionalidadDTO p in promedio)
            {
                p.Nacionalidad.IdNacionalidad = id;
                cantidad++;
            }

            // Retorna la cantidad de personas de esa nacionalidad
            return promedio.Where(p => p.Nacionalidad.IdNacionalidad == id).First().CantidadPersonas;
        }

        // Obtiene el promedio de edad de una nacionalidad especifica
        public int GetPromedioEdadPorNacionalidad(int id) //ID de nacionalidad
        {
            DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
            List<PromedioEdadNacionalidadDTO> promedio = mp.GetPromedioEdadPorNacionalidad(id);

            // Retorna el promedio de edad para la nacionalidad dada
            return promedio.Where(p => p.Nacionalidad.IdNacionalidad == id).First().PromedioEdad;

            //medio nefasto pero veremos si funciona
            // Nota: podria optimizarse para no recorrer dos veces la lista
        }

        public List<PersonaFiltrada> ObtenerPersonasPorFiltros(FiltrosDTO filtros)
        {
            MapperPersona mapper = new MapperPersona();
            return mapper.GetPersonasFiltradas(filtros);
        }
    }
}

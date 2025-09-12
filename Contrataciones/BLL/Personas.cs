using System;
using System.Collections.Generic;
using System.Linq;
using BE.dto;
using DAL.mapper;

namespace BLL
{
    public class Personas
    {
        // Inserta una nueva persona en la base de datos
        public int InsertarPersona(string nombre, string apellido, int edad, bool sexo, BE.Nacionalidad nacionalidad, BE.Profesion profesion)
        {
            try
            {

                DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
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

                /* --- Los comentarios del integrante "X" no representan la opinión general del grupo --- */

                p.Nacionalidad = nacionalidad.IdNacionalidad;
                p.Profesion = profesion.IdProfesion;

                // Se inserta en la base de datos
                return mp.Insert(p);

            }
            catch (Exception e) { throw e; }

        }
        public int EditarPersona(int id, string nombre, string apellido, int edad, bool sexo, BE.Nacionalidad nacionalidad, BE.Profesion profesion)
        {
            try
            {

                DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();

                BE.Persona p = new BE.Persona();

                p.NumeroPersona = id;

                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else p.Nombre = nombre;

                if (string.IsNullOrWhiteSpace(apellido)) throw new Exception("El apellido es invalido");
                else p.Apellido = apellido;

                p.Edad = Math.Abs(edad); //evitamos edades negativas
                p.Sexo = sexo; //SEXO ES UN BOOL 
                               //0 - Mujer (pq son falsas y mentirosas)
                               //1 - Hombre (pq somos superiores y siempre verdaderos)

                p.Nacionalidad = nacionalidad.IdNacionalidad;
                p.Profesion = profesion.IdProfesion;

                return mp.Update(p);

            }
            catch (Exception e) { throw e; }
        }
        public int RemoverPersona(int numero) => new DAL.mapper.MapperPersona().Delete(numero);
        public BE.Persona GetById(int id) => new DAL.mapper.MapperPersona().FindById(id);
        public List<BE.Persona> ListarPersonas() => new DAL.mapper.MapperPersona().GetAll();
        public int GetPromedioEdad() => new DAL.mapper.MapperPersona().GetPromedioEdad();
        public int GetCantidad() => new DAL.mapper.MapperPersona().GetCantidadPersonas();
        public int GetMinEdad() => new DAL.mapper.MapperPersona().GetMinOrMaxAge((int)BE.enums.EOrden.MIN);
        public int GetMaxEdad() => new DAL.mapper.MapperPersona().GetMinOrMaxAge((int)BE.enums.EOrden.MAX);
        public int? GetCantidadPersonasPorNacionalidad(int id) => new DAL.mapper.MapperPersona().GetCantidadPersonasPorNacionalidad(id).Where(p => p.Nacionalidad.IdNacionalidad == id).FirstOrDefault().CantidadPersonas;
        public int? GetPromedioEdadPorNacionalidad(int id) => new DAL.mapper.MapperPersona().GetPromedioEdadPorNacionalidad(id).Where(p => p.Nacionalidad.IdNacionalidad == id).FirstOrDefault().PromedioEdad;
        public List<PersonaFiltrada> ObtenerPersonasPorFiltros(FiltrosDTO filtros) => new MapperPersona().GetPersonasFiltradas(filtros);
    }
}
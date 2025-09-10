using BE.enums;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class Nacionalidad
    {
        // Inserta una nueva nacionalidad en la base de datos
        public int InsertarNacionalidad(string nombre)
        {
            try
            {
                // Instanciamos el mapper para la capa DAL
                DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();

                // Creamos un objeto de negocio Nacionalidad
                BE.Nacionalidad n = new BE.Nacionalidad();

                // Validacion basica
                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else n.Nombre = nombre;

                // Se inserta en la base de datos
                return mp.Insert(n);

            }
            catch (Exception e) { throw e; }

        }

        // Elimina una nacionalidad por id
        public int RemoverProfesion(int numero)
        {
            DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();
            return mp.Delete(numero);
        }

        // Edita el nombre de una nacionalidad existente
        public int EditarPersona(int id, string nombre)
        {
            try
            {

                DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();

                // Se crea el objeto con el id a modificar
                BE.Nacionalidad n = new BE.Nacionalidad();

                n.IdNacionalidad = id;

                // Validacion del nuevo nombre
                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else n.Nombre = nombre;

                // Se actualiza en la base de datos
                return mp.Update(n);

            }
            catch (Exception e) { throw e; }
        }

        // Obtiene una nacionalidad por id
        public BE.Nacionalidad GetById(int id)
        {
            DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();
            return mp.FindById(id);
        }

        // Lista todas las nacionalidades registradas
        public List<BE.Nacionalidad> ListarPersonas()
        {
            DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();
            return mp.GetAll();
        }

        // Obtiene la nacionalidad con menor cantidad de personas registradas
        public BE.dto.PersonasNacionalidadDTO GetMinPersonasRegistradas()
        {
            DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();
            return mp.GetNacionalidadConMasOMenosPersonas(((int)EOrden.MIN));
        }

        // Obtiene la nacionalidad con mayor cantidad de personas registradas
        public BE.dto.PersonasNacionalidadDTO GetMaxPersonasRegistradas()
        {
            DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();
            return mp.GetNacionalidadConMasOMenosPersonas((int)EOrden.MAX);
        }

    }
}


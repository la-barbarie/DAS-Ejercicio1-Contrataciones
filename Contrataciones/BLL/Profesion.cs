using System;
using System.Collections.Generic;

namespace BLL
{
    public class Profesion
    {
        // Inserta una nueva profesion en la base de datos
        public int InsertarProfesion(string nombre)
        {
            try
            {
                // Se instancia el mapper de DAL
                DAL.mapper.MapperTipoProfesion mp = new DAL.mapper.MapperTipoProfesion();

                // Se crea el objeto de negocio Profesion
                BE.Profesion p = new BE.Profesion();

                // Validacion del nombre
                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else p.Nombre = nombre;

                // Inserta en la base de datos
                return mp.Insert(p);

            }
            catch (Exception e) { throw e; }
        }
        public int EditarProfesion(int id, string nombre)
        {
            try
            {

                DAL.mapper.MapperTipoProfesion mp = new DAL.mapper.MapperTipoProfesion();
                
                // Se crea el objeto con el id a modificar
                BE.Profesion p = new BE.Profesion();

                p.IdProfesion = id;

                // Validacion del nuevo nombre
                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else p.Nombre = nombre;

                // Actualiza en la base de datos
                return mp.Update(p);

            }
            catch (Exception e) { throw e; }
        }
        public int RemoverProfesion(int numero) => new DAL.mapper.MapperTipoProfesion().Delete(numero);
        public BE.Profesion GetById(int id) => new DAL.mapper.MapperTipoProfesion().FindById(id);
        public List<BE.Profesion> ListarProfesiones() => new DAL.mapper.MapperTipoProfesion().GetAll();
    }
}


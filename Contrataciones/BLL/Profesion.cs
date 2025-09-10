using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Profesion
    {
        public int InsertarProfesion(string nombre)
        {
            try
            {

                DAL.mapper.MapperTipoProfesion mp = new DAL.mapper.MapperTipoProfesion();

                BE.Profesion p = new BE.Profesion();

                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else p.Nombre = nombre;

                return mp.Insert(p);

            }
            catch (Exception e) { throw e; }

        }
        public int EditarProfesion(int id, string nombre)
        {
            try
            {

                DAL.mapper.MapperTipoProfesion mp = new DAL.mapper.MapperTipoProfesion();

                BE.Profesion p = new BE.Profesion();

                p.IdProfesion = id;

                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else p.Nombre = nombre;

                return mp.Update(p);

            }
            catch (Exception e) { throw e; }
        }
        public int RemoverProfesion(int numero) => new DAL.mapper.MapperTipoProfesion().Delete(numero);
        public BE.Profesion GetById(int id) => new DAL.mapper.MapperTipoProfesion().FindById(id);
        public List<BE.Profesion> ListarProfesiones() => new DAL.mapper.MapperTipoProfesion().GetAll();
    }
}


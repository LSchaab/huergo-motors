using System;
using System.Collections.Generic;
using DTO;
using DAO;

namespace Negocio
{
    public class AccesoriosNegocio
    {
        private readonly AccesoriosDAO accesoriosDAO = new AccesoriosDAO();

        public void Crear(Accesorios accesorio)
        {
            if (accesorio.Nombre == string.Empty || accesorio.Tipo == string.Empty || accesorio.IdVehiculo < 0)
            {
                throw new Exception("Uno o más campos están vacíos");
            }

            if (accesorio.Precio < 0)
            {
                throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
            }

            try
            {
                accesoriosDAO.Crear(accesorio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Borrar(int id)
        {
            try
            {
                accesoriosDAO.BorrarGenerico(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(Accesorios accesorio)
        {
            if (accesorio.Nombre == string.Empty || accesorio.Tipo == string.Empty || accesorio.IdVehiculo < 0)
            {
                throw new Exception("Uno o más campos están vacíos");
            }

            if (accesorio.Precio < 0)
            {
                throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
            }

            try
            {
                accesoriosDAO.Modificar(accesorio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Accesorios LeerPorId(int id)
        {
            try
            {
                return accesoriosDAO.LeerPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Accesorios> LeerTodosPorFiltro(string filtro)
        {
            try
            {
                return accesoriosDAO.LeerTodosPorFiltro(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Accesorios> LeerPorIdVehiculo(int id)
        {
            try
            {
                return accesoriosDAO.LeerPorIdVehiculo(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using DAO;
using DTO;

namespace Negocio
{
    public class VehiculosNegocio
    {
        private readonly VehiculosDAO vehiculosDAO = new VehiculosDAO();

        public void Crear(Vehiculos vehiculo)
        {
            if (vehiculo.Tipo == string.Empty || vehiculo.Modelo == string.Empty)
            {
                throw new Exception("Uno o más campos están vacíos");
            }

            if (vehiculo.PrecioVenta < 0 || vehiculo.Stock <= 0)
            {
                throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
            }

            try
            {
                vehiculosDAO.CrearGenerico(vehiculo);
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
                vehiculosDAO.BorrarGenerico(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(Vehiculos vehiculo)
        {
            if (vehiculo.Tipo == string.Empty || vehiculo.Modelo == string.Empty)
            {
                throw new Exception("Uno o más campos están vacíos");
            }

            if (vehiculo.PrecioVenta < 0 || vehiculo.Stock <= 0)
            {
                throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
            }

            try
            {
                vehiculosDAO.ModificarGenerico(vehiculo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Vehiculos LeerPorId(int id)
        {
            try
            {
                return vehiculosDAO.LeerPorIdGenerico(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Vehiculos> LeerTodosPorFiltro(string filtro)
        {
            try
            {
                return vehiculosDAO.LeerTodosPorFiltroGenerico(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Vehiculos> LeerTodosModelos()
        {
            try
            {
                return vehiculosDAO.LeerTodosModelos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

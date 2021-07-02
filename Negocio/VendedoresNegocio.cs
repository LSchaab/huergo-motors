using System;
using System.Collections.Generic;
using DAO;
using DTO;

namespace Negocio
{
    public class VendedoresNegocio
    {
        private readonly VendedoresDAO vendedoresDAO = new VendedoresDAO();

        public void Crear(Vendedores vendedor)
        {
            if (vendedor.Nombre == string.Empty || vendedor.Apellido == string.Empty || vendedor.Sucursal == string.Empty)
            {
                throw new Exception("Uno o más campos están vacíos");
            }

            try
            {
                vendedoresDAO.CrearGenerico(vendedor);
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
                vendedoresDAO.BorrarGenerico(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(Vendedores vendedor)
        {
            if (vendedor.Nombre == string.Empty || vendedor.Apellido == string.Empty || vendedor.Sucursal == string.Empty)
            {
                throw new Exception("Uno o más campos están vacíos");
            }

            try
            {
                vendedoresDAO.CrearGenerico(vendedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Vendedores LeerPorId(int id)
        {
            try
            {
                return vendedoresDAO.LeerPorIdGenerico(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Vendedores> LeerTodosPorFiltro(string filtro)
        {
            try
            {
                return vendedoresDAO.LeerTodosPorFiltroGenerico(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Vendedores> LeerTodosNombresCompletos()
        {
            try
            {
                return vendedoresDAO.LeerTodosNombresCompletos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

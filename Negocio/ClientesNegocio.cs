using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DAO;
using DTO;

namespace Negocio
{
    public class ClientesNegocio
    {
        // Telefono celular de argentina
        private readonly Regex telefonoRegex = new Regex(@"^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$");

        private readonly Regex emailRegex = new Regex(@"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        
        private readonly ClientesDAO clientesDAO = new ClientesDAO();

        public void Crear(Clientes cliente)
        {
            if (cliente.Nombre == string.Empty || cliente.Direccion == string.Empty || cliente.Telefono == string.Empty || cliente.Email == string.Empty)
            {
                throw new Exception("Uno o más campos están vacíos");
            }

            if (!telefonoRegex.IsMatch(cliente.Telefono) || !emailRegex.IsMatch(cliente.Email))
            {
                throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
            }

            try
            {
                clientesDAO.CrearGenerico(cliente);
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
                clientesDAO.BorrarGenerico(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(Clientes cliente)
        {
            if (cliente.Nombre == string.Empty || cliente.Direccion == string.Empty || cliente.Telefono == string.Empty || cliente.Email == string.Empty)
            {
                throw new Exception("Uno o más campos están vacíos");
            }

            if (!telefonoRegex.IsMatch(cliente.Telefono) || !emailRegex.IsMatch(cliente.Email))
            {
                throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
            }

            try
            {
                clientesDAO.ModificarGenerico(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Clientes LeerPorId(int id)
        {
            try
            {
                return clientesDAO.LeerPorIdGenerico(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Clientes> LeerTodosPorFiltro(string filtro)
        {
            try
            {
                return clientesDAO.LeerTodosPorFiltroGenerico(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

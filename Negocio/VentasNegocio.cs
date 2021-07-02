using System;
using System.Collections.Generic;
using DTO;
using DAO;

namespace Negocio
{
    public class VentasNegocio
    {
        private readonly VentasDAO ventasDAO = new VentasDAO();

        public void CrearVenta(Ventas venta, List<Accesorios> accesorios)
        {
            try
            {
                ventasDAO.CrearVenta(venta, accesorios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ventas> LeerVentasPorFiltro(string filtro)
        {
            try
            {
                return ventasDAO.LeerVentasPorFiltro(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<VentasAccesorios> LeerVentasAccesoriosPorIdVenta(int id)
        {
            try
            {
                return ventasDAO.LeerVentasAccesoriosPorIdVenta(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

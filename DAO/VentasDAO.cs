using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using DTO;

namespace DAO
{
    public class VentasDAO
    {
        public void CrearVenta(Ventas venta, List<Accesorios> accesorios)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAOHelper.dbString))
                {
                    try
                    {
                        conexion.Open();
                    }
                    catch
                    {
                        throw new Exception("Ha ocurrido un error de conexion");
                    }

                    using (SqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        try // Actualiza el stock del vehiculo seleccionado
                        {
                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.Transaction = transaccion;
                                cmd.Connection = conexion;
                                cmd.CommandText = $"UPDATE Vehiculos SET " +
                                    $"Stock=(SELECT Stock FROM Vehiculos WHERE Id={venta.IdVehiculo})-1 " +
                                    $"WHERE Id={venta.IdVehiculo}";
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch
                        {
                            throw new Exception("Ha ocurrido un error actualizando el stock del vehiculo seleccionado");
                        }

                        try // Nueva Venta
                        {
                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.Transaction = transaccion;
                                cmd.Connection = conexion;
                                cmd.CommandText = $"INSERT INTO Ventas " +
                                    $"(Fecha, IdVehiculo, IdCliente, IdVendedor, Observaciones, Total) " +
                                    $"VALUES ('{venta.Fecha:yyyyMMdd}','{venta.IdVehiculo}','{venta.IdCliente}','{venta.IdVendedor}', '{venta.Observaciones}', '{venta.Total.ToString(CultureInfo.InvariantCulture)}')";
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch
                        {
                            throw new Exception("Ha ocurrido un error creando la venta");
                        }

                        try // Nuevas ventas de Accesorios
                        {
                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.Transaction = transaccion;
                                cmd.Connection = conexion;
                                foreach (Accesorios accesorio in accesorios)
                                {
                                    cmd.CommandText = $"INSERT INTO VentasAccesorios (IdVenta, IdAccesorio, Precio) " +
                                        $"VALUES ((SELECT MAX(Id) FROM Ventas), '{accesorio.Id}', '{accesorio.Precio.ToString(CultureInfo.InvariantCulture)}')";
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        catch
                        {
                            throw new Exception("Ha ocurrido un error creando las ventas de accesorios");
                        }

                        transaccion.Commit();
                    }
                }
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
                List<Ventas> ventas = new List<Ventas>();
                DataTable dt = new DataTable();

                string query = $"SELECT a.Id, a.Fecha, a.IdVehiculo, b.Modelo, a.IdCliente, c.Nombre AS NombreCliente, a.IdVendedor, d.Nombre + ' ' + d.Apellido AS NombreVendedor, a.Observaciones, a.Total " +
                    $"FROM Ventas AS a JOIN Vehiculos AS b ON a.IdVehiculo=b.Id " +
                    $"JOIN Clientes AS c ON a.IdCliente=c.Id " +
                    $"JOIN Vendedores AS d ON a.IdVendedor=d.Id " +
                    $"WHERE a.Fecha LIKE '%{filtro}%' or " +
                    $"b.Modelo LIKE '%{filtro}%' or " +
                    $"c.Nombre LIKE '%{filtro}%' or " +
                    $"d.Nombre LIKE '%{filtro}%' or " +
                    $"d.Apellido LIKE '%{filtro}%' or " +
                    $"a.Observaciones LIKE '%{filtro}%' or " +
                    $"a.Total LIKE '%{filtro}%'";

                using (SqlDataAdapter da = new SqlDataAdapter(query, DAOHelper.dbString))
                {
                    da.Fill(dt);
                }

                foreach (DataRow dr in dt.Rows)
                {
                    Ventas venta = new Ventas
                    {
                        Id = (int)dr["Id"],
                        Fecha = (DateTime)dr["Fecha"],
                        IdVehiculo = (int)dr["IdVehiculo"],
                        ModeloVehiculo = (string)dr["Modelo"],
                        IdCliente = (int)dr["IdCliente"],
                        NombreCliente = (string)dr["NombreCliente"],
                        IdVendedor = (int)dr["IdVendedor"],
                        NombreVendedor = (string)dr["NombreVendedor"],
                        Observaciones = (string)dr["Observaciones"],
                        Total = (decimal)dr["Total"]
                    };

                    ventas.Add(venta);
                }

                return ventas;
            }
            catch
            {
                throw new Exception("Ha ocurido un error leyendo las ventas");
            }
        }
    
        public List<VentasAccesorios> LeerVentasAccesoriosPorIdVenta(int id)
        {
            try
            {
                List<VentasAccesorios> ventasAccesorios = new List<VentasAccesorios>();
                DataTable dt = new DataTable();

                string query = $"SELECT a.Id, a.IdVenta, a.IdAccesorio, b.Nombre, a.Precio " +
                    $"FROM VentasAccesorios AS a " +
                    $"JOIN Accesorios AS b ON a.IdAccesorio=b.Id " +
                    $"WHERE a.IdVenta={id}";

                using (SqlDataAdapter da = new SqlDataAdapter(query, DAOHelper.dbString))
                {
                    da.Fill(dt);
                }

                foreach (DataRow dr in dt.Rows)
                {
                    VentasAccesorios ventaAccesorio = new VentasAccesorios
                    {
                        Id = (int)dr["Id"],
                        IdAccesorio = (int)dr["IdAccesorio"],
                        NombreAccesorio = (string)dr["Nombre"],
                        Precio = (decimal)dr["Precio"]
                    };

                    ventasAccesorios.Add(ventaAccesorio);
                }

                return ventasAccesorios;
            }
            catch
            {
                throw new Exception("Ha ocurido un error leyendo las ventas de accesorios");
            }
        }
    }
}

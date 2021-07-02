using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using DTO;

namespace DAO
{
    public class AccesoriosDAO
    {
        public void Crear(Accesorios accesorio)
        {
            try
            {
                string query = $"INSERT INTO Accesorios (Nombre, Tipo, Precio, IdVehiculo) VALUES ('{accesorio.Nombre}','{accesorio.Tipo}','{accesorio.Precio.ToString(CultureInfo.InvariantCulture)}','{accesorio.IdVehiculo}')";

                using (SqlConnection conexion = new SqlConnection(DAOHelper.dbString))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception("Ha ocurido un error creando el accesorio");
            }
        }

        public void Modificar(Accesorios accesorio)
        {
            try
            {
                string query = $"UPDATE Accesorios SET Nombre='{accesorio.Nombre}', Tipo='{accesorio.Tipo}', Precio='{accesorio.Precio.ToString(CultureInfo.InvariantCulture)}', IdVehiculo='{accesorio.IdVehiculo}' WHERE Id={accesorio.Id}";

                using (SqlConnection conexion = new SqlConnection(DAOHelper.dbString))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception("Ha ocurido un error modificando el accesorio");
            }
        }

        public Accesorios LeerPorId(int id)
        {
            try
            {
                Accesorios accesorio = new Accesorios();
                DataTable dt = new DataTable();

                string query = $"SELECT b.Id, b.Nombre, b.Tipo, b.Precio, a.Modelo, b.IdVehiculo FROM Vehiculos AS a JOIN Accesorios AS b ON a.Id=b.IdVehiculo WHERE b.Id={id}";

                using (SqlDataAdapter da = new SqlDataAdapter(query, DAOHelper.dbString))
                {
                    da.Fill(dt);
                }

                accesorio.Id = (int)dt.Rows[0]["Id"];
                accesorio.Nombre = (string)dt.Rows[0]["Nombre"];
                accesorio.Tipo = (string)dt.Rows[0]["Tipo"];
                accesorio.Precio = (decimal)dt.Rows[0]["Precio"];
                accesorio.ModeloVehiculo = (string)dt.Rows[0]["Modelo"];
                accesorio.IdVehiculo = (int)dt.Rows[0]["IdVehiculo"];

                return accesorio;
            }
            catch
            {
                throw new Exception("Ha ocurido un error leyendo el accesorio");
            }
        }

        public List<Accesorios> LeerTodosPorFiltro(string filtro)
        {
            try
            {
                List<Accesorios> accesorios = new List<Accesorios>();
                DataTable dt = new DataTable();

                string query = $"SELECT a.id, a.Nombre, a.Tipo, a.Precio, a.IdVehiculo, b.Modelo FROM Accesorios AS a JOIN Vehiculos AS b ON a.IdVehiculo=b.Id " +
                $"WHERE a.Nombre LIKE '%{filtro}%' or " +
                $"a.Tipo LIKE '%{filtro}%' or " +
                $"a.Precio LIKE '%{filtro}%' or " +
                $"a.IdVehiculo LIKE '%{filtro}%' or " +
                $"b.Modelo LIKE '%{filtro}%' ";

                using (SqlDataAdapter da = new SqlDataAdapter(query, DAOHelper.dbString))
                {
                    da.Fill(dt);
                }

                foreach (DataRow dr in dt.Rows)
                {
                    Accesorios accesorio = new Accesorios
                    {
                        Id = (int)dr["Id"],
                        Nombre = (string)dr["Nombre"],
                        Tipo = (string)dr["Tipo"],
                        Precio = (decimal)dr["Precio"],
                        IdVehiculo = (int)dr["IdVehiculo"],
                        ModeloVehiculo = (string)dr["Modelo"]
                    };

                    accesorios.Add(accesorio);
                }

                return accesorios;
            }
            catch
            {
                throw new Exception("Ha ocurido un error leyendo los accesorios");
            }
        }

        public List<Accesorios> LeerPorIdVehiculo(int id)
        {
            try
            {
                List<Accesorios> accesorios = new List<Accesorios>();
                DataTable dt = new DataTable();

                string query = $"SELECT Id, Nombre, Tipo, Precio FROM Accesorios WHERE IdVehiculo={id}";

                using (SqlDataAdapter da = new SqlDataAdapter(query, DAOHelper.dbString))
                {
                    da.Fill(dt);
                }

                foreach (DataRow dr in dt.Rows)
                {
                    Accesorios accesorio = new Accesorios
                    {
                        Id = (int)dr["Id"],
                        Nombre = (string)dr["Nombre"],
                        Tipo = (string)dr["Tipo"],
                        Precio = (decimal)dr["Precio"]
                    };

                    accesorios.Add(accesorio);
                }
                return accesorios;
            }
            catch
            {
                 throw new Exception("Ha ocurido un error leyendo el accesorio");
            }
        }
    }
}

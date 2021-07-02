using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class VehiculosDAO : DAOBase<Vehiculos>
    {
        public List<Vehiculos> LeerTodosModelos()
        {
            try
            {
                List<Vehiculos> vehiculos = new List<Vehiculos>();
                DataTable dt = new DataTable();

                string query = $"SELECT Id, Modelo FROM Vehiculos";
                
                using (SqlDataAdapter da = new SqlDataAdapter(query, DAOHelper.dbString))
                {
                    da.Fill(dt);
                }

                foreach (DataRow dr in dt.Rows)
                {
                    Vehiculos vehiculo = new Vehiculos
                    {
                        Id = (int)dr["Id"],
                        Modelo = (string)dr["Modelo"]
                    };

                    vehiculos.Add(vehiculo);
                }

                return vehiculos;
            }
            catch
            {
                throw new Exception($"Ha ocurrido un error leyendo registro/s!\nDetalles: VehiculosDAO");
            }
        }
    }
}

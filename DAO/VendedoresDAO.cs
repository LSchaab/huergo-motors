using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class VendedoresDAO : DAOBase<Vendedores>
    {
        public List<Vendedores> LeerTodosNombresCompletos()
        {
            try
            {
                List<Vendedores> vendedores = new List<Vendedores>();
                DataTable dt = new DataTable();

                string query = $"SELECT Id, Nombre, Apellido FROM Vendedores";

                using (SqlDataAdapter da = new SqlDataAdapter(query, DAOHelper.dbString))
                {
                    da.Fill(dt);
                }

                foreach (DataRow dr in dt.Rows)
                {
                    Vendedores vendedor = new Vendedores
                    {
                        Id = (int)dr["Id"],
                        Nombre = (string)dr["Nombre"],
                        Apellido = (string)dr["Apellido"]
                    };

                    vendedores.Add(vendedor);
                }

                return vendedores;
            }
            catch
            {
                throw new Exception("Ha ocurido un error leyendo los vendedores");
            }
        }
    }
}

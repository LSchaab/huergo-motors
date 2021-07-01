using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using DTO;

namespace DAO
{
    // T solo puede ser un hijo de DTOBase
    public class DAOBase<T> where T : DTOBase, new()
    {
        public void CrearGenerico(T dto)
        {
            try
            {
                string tabla = typeof(T).Name;

                string campos = string.Empty;
                string parametros = string.Empty;

                IEnumerable<PropertyInfo> propiedades = typeof(T).GetProperties().Where(p => p.CanWrite);

                using (SqlConnection conexion = new SqlConnection(DAOHelpers.dbString))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        foreach (PropertyInfo propiedad in propiedades)
                        {
                            if (propiedad.Name == "Id")
                            {
                                continue;
                            }

                            campos += $"{propiedad.Name},";
                            parametros += $"@{propiedad.Name},";

                            object valor = propiedad.GetValue(dto, null);
                            cmd.Parameters.AddWithValue($"@{propiedad.Name}", valor);
                        }

                        campos = campos.TrimEnd(',');
                        parametros = parametros.TrimEnd(',');

                        string query = $"INSERT INTO {tabla} ({campos}) VALUES ({parametros})";

                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw new Exception($"Ha ocurrido un error creando un registro: {typeof(T).Name}");
            }
        }
    
        public void BorrarGenerico(int id)
        {
            try
            {
                string tabla = typeof(T).Name;

                string query = $"DELETE FROM {tabla} WHERE Id={id}";

                using (SqlConnection conexion = new SqlConnection(DAOHelpers.dbString))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception($"Ha ocurrido un error eliminando un registro: {typeof(T).Name}");
            }
        }

        public void ModificarGenerico(T dto)
        {
            try
            {
                string tabla = typeof(T).Name;

                string camposValores = string.Empty;

                IEnumerable<PropertyInfo> propiedades = typeof(T).GetProperties().Where(p => p.CanWrite);

                object id = null;

                using (SqlConnection conexion = new SqlConnection(DAOHelpers.dbString))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        foreach (PropertyInfo propiedad in propiedades)
                        {
                            if (propiedad.Name == "Id")
                            {
                                id = propiedad.GetValue(dto, null);
                                continue;
                            }
                            camposValores += $"{propiedad.Name} = @{propiedad.Name},";

                            object valor = propiedad.GetValue(dto, null);
                            cmd.Parameters.AddWithValue($"@{propiedad.Name}", valor);
                        }

                        camposValores = camposValores.TrimEnd(',');

                        string query = $"UPDATE {tabla} SET {camposValores} WHERE Id={id}";

                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw new Exception($"Ha ocurrido un error modificando un registro: {typeof(T).Name}");
            }
        }

        public T LeerPorIdGenerico(int id)
        {
            try
            {
                string tabla = typeof(T).Name;

                DataTable dt = new DataTable();

                IEnumerable<PropertyInfo> propiedades = typeof(T).GetProperties().Where(p => p.CanWrite);

                string query = $"SELECT * FROM {tabla} WHERE Id={id}";

                using (SqlDataAdapter da = new SqlDataAdapter(query, DAOHelpers.dbString))
                {
                    da.Fill(dt);
                }

                T dto = new T();

                foreach (PropertyInfo propiedad in propiedades)
                {
                    object valor = dt.Rows[0][propiedad.Name];
                    propiedad.SetValue(dto, valor, null);
                }

                return dto;
            }
            catch
            {
                throw new Exception($"Ha ocurrido un error leyendo un registro: {typeof(T).Name}");
            }
        }

        public List<T> LeerTodosPorFiltroGenerico(string filtro)
        {
            try
            {
                string tabla = typeof(T).Name;

                DataTable dt = new DataTable();
                List<T> lista = new List<T>();

                string campos = "";

                IEnumerable<PropertyInfo> propiedades = typeof(T).GetProperties().Where(p => p.CanWrite);

                foreach (PropertyInfo propiedad in propiedades)
                {
                    if (propiedad.Name == "Id")
                    {
                        continue;
                    }
                    campos += $" {propiedad.Name} LIKE '%{filtro}%' or";
                }

                // Borra el ultimo "or"
                if (campos.EndsWith("or"))
                {
                    campos = campos.Substring(0, campos.LastIndexOf("or"));
                }

                string query = $"SELECT * FROM {tabla} WHERE {campos}";

                using (SqlDataAdapter da = new SqlDataAdapter(query, DAOHelpers.dbString))
                {
                    da.Fill(dt);
                }

                foreach (DataRow dr in dt.Rows)
                {
                    T dto = new T();

                    foreach (PropertyInfo propiedad in propiedades)
                    {
                        object valor = dr[propiedad.Name];
                        propiedad.SetValue(dto, valor, null);
                    }

                    lista.Add(dto);
                }

                return lista;
            }
            catch
            {
                throw new Exception($"Ha ocurrido un error leyendo registros: {typeof(T).Name}");
            }
        }
    }
}

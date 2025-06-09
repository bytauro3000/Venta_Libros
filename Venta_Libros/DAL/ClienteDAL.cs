using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Venta_Libros.Models;

namespace Venta_Libros.DAL
{
    public class ClienteDAL
    {
        private readonly ConexionSQL conexion = new ConexionSQL();

        public IEnumerable<Clientes> ListarClientes()
        {
            List<Clientes> lista = new List<Clientes>();

            try
            {
                conexion.cn.Open();
                SqlCommand cmd = new SqlCommand("SP_ListarClientes", conexion.cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Clientes
                    {
                        IdCliente = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                        Apellidos = dr.GetString(2),
                        Correo = dr.GetString(3),
                        Direccion = dr.IsDBNull(4) ? null : dr.GetString(4),
                        Telefono = dr.GetString(5),
                        FechaRegistro = dr.GetDateTime(6)
                    });
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                // Aquí puedes agregar manejo de errores o logs si lo deseas
                throw new Exception("Error al listar clientes: " + ex.Message);
            }
            finally
            {
                if (conexion.cn.State == System.Data.ConnectionState.Open)
                    conexion.cn.Close();
            }

            return lista;
        }
    }
}

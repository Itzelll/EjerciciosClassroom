using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ADOGrupos
    {
        string _connection = ConfigurationManager.ConnectionStrings["ContratosEnergia"].ConnectionString;
        SqlCommand comando;

        public List<GruposComerciales> Consultar()
        {
            List<GruposComerciales> _lstGrupos = new List<GruposComerciales>();

            string query = $"select * from GruposComerciales";
            using (SqlConnection con = new SqlConnection(_connection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    _lstGrupos.Add(
                        new GruposComerciales()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nombre = reader["nombre"].ToString(),
                            direccion = reader["direccion"].ToString(),
                            rfc = reader["RFC"].ToString(),
                            telefono = reader["telefono"].ToString(),
                            email = reader["email"].ToString(),
                        }
                    );
                }
                con.Close();
            }
            return _lstGrupos;
        }

        public GruposComerciales Consultar(int id)
        {
            GruposComerciales objGrupo = new GruposComerciales();

            string query = $"select * from GruposComerciales where id={id}";
            using (SqlConnection con = new SqlConnection(_connection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = System.Data.CommandType.Text;
                con.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    objGrupo.nombre = reader["nombre"].ToString();
                    objGrupo.direccion = reader["direccion"].ToString();
                    objGrupo.rfc = reader["RFC"].ToString();
                    objGrupo.telefono = reader["telefono"].ToString();
                    objGrupo.email = reader["email"].ToString();
                }
                con.Close();
                return objGrupo;
            }
        }

        public void Agregar(GruposComerciales grupo)
        {
            string query = $"insert into GruposComerciales (nombre, direccion, RFC, telefono, email) values ('{grupo.nombre}','{grupo.direccion}','{grupo.rfc}','{grupo.telefono}','{grupo.email}')";
            using (SqlConnection con = new SqlConnection(_connection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = System.Data.CommandType.Text;

                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Actualizar(GruposComerciales grupo)
        {
            string query = $"update GruposComerciales set nombre='{grupo.nombre}', direccion='{grupo.direccion}', RFC='{grupo.rfc}', telefono='{grupo.telefono}', email='{grupo.email}' where id={grupo.id} ";
            using (SqlConnection con = new SqlConnection(_connection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = System.Data.CommandType.Text;
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Eliminar(int id)
        {
            string query = $"delete GruposComerciales where id={id}";
            using (SqlConnection con = new SqlConnection(_connection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = System.Data.CommandType.Text;
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

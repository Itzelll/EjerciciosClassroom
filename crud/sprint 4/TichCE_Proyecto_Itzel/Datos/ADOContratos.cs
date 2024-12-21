﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ADOContratos
    {
        string _connection = ConfigurationManager.ConnectionStrings["ContratosEnergia"].ConnectionString;
        SqlCommand comando;

        public List<Contratos> Consultar()
        {
            List<Contratos> _lista = new List<Contratos>();

            string query = $"select * from Contratos";
            using (SqlConnection con = new SqlConnection(_connection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    _lista.Add(
                        new Contratos()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            cliente = Convert.ToInt32(reader["cliente"]),
                            tipoContrato = Convert.ToInt32(reader["tipoContrato"]),
                            fechaInicio = Convert.ToDateTime(reader["fechaInicio"]),
                            fechaFin = Convert.ToDateTime(reader["fechaFinal"]),
                            monto = Convert.ToDecimal(reader["monto"]),
                            descripcion = reader["descripcion"].ToString(),
                        }
                    );
                }
                con.Close();
            }
            return _lista;
        }

        public Contratos Consultar(int id)
        {
            Contratos obj = new Contratos();

            string query = $"select * from Contratos where id={id}";
            using (SqlConnection con = new SqlConnection(_connection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = System.Data.CommandType.Text;
                con.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    obj.cliente = Convert.ToInt32(reader["cliente"]);
                    obj.tipoContrato = Convert.ToInt32(reader["tipoContrato"]);
                    obj.fechaInicio = Convert.ToDateTime(reader["fechaInicio"]);
                    obj.fechaFin = Convert.ToDateTime(reader["fechaFinal"]);
                    obj.monto = Convert.ToDecimal(reader["monto"]);
                    obj.descripcion = reader["descripcion"].ToString();
                }
                con.Close();
                return obj;
            }
        }

        public void Agregar(Contratos contrato)
        {
            string query = "sp_agregarContrato";
            using (SqlConnection con = new SqlConnection(_connection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@cliente", contrato.cliente);
                comando.Parameters.AddWithValue("@tipoContrato", contrato.tipoContrato);
                comando.Parameters.AddWithValue("@fechaInicio", contrato.fechaInicio);
                comando.Parameters.AddWithValue("@fechaFinal", contrato.fechaFin);
                comando.Parameters.AddWithValue("@monto", contrato.monto);
                comando.Parameters.AddWithValue("@descripcion", contrato.descripcion);

                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Actualizar(Contratos contrato)
        {
            string query = "sp_actualizarContrato";
            using (SqlConnection con = new SqlConnection(_connection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", contrato.id);
                comando.Parameters.AddWithValue("@cliente", contrato.cliente);
                comando.Parameters.AddWithValue("@tipoContrato", contrato.tipoContrato);
                comando.Parameters.AddWithValue("@fechaInicio", contrato.fechaInicio);
                comando.Parameters.AddWithValue("@fechaFinal", contrato.fechaFin);
                comando.Parameters.AddWithValue("@monto", contrato.monto);
                comando.Parameters.AddWithValue("@descripcion", contrato.descripcion);

                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Eliminar(int id)
        {
            string query = $"delete Contratos where id={id}";
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
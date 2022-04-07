using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using com.app.comprobante.entity;

namespace proysustidataaccesss
{
    public class CompPagoDo
    {

        #region Declaración de variables 
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlCommand comando;
        DataSet dsDatos = new DataSet();
        string sentencia = string.Empty;
        #endregion


        public CompPagoDo()
        {
             conexion = new SqlConnection("Data Source=localhost;Initial Catalog=dbEncargos;Integrated Security=True");
        } 

        public void Insertar(ComprobantePago com )
        {
            try
            {
                sentencia = "";
                // sentencia = "insert into RESERVACION values (" + idReservacion + "," + idCliente + ",'" + fechaReservacion + "','" + estado + "')";
               // sentencia = "insert into Reservacion values (" + idCliente + ",'" + fechaReservacion + "','" + estado + "')";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
                conexion.Dispose();
            }
        }


        public void Actualizar(ComprobantePago com)
        {

            try
            {
                sentencia = "";
                //sentencia = "update Empleado set nombreEmp ='" + nombreEmp + "', generoEmp = '" + generoEmp + "', cargoEmp ='" + cargoEmp + "',fechaNacEmp ='" + fechaNacEmp + "' WHERE idEmp =" + idEmp;
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Dispose();
            }

            catch (Exception ex)
            {
                throw ex;

            }

            finally
            {
                conexion.Close();
            }
        }
        public DataSet BuscarTodo()
        {
            try
            {
                sentencia = "";
                //sentencia = "Select a.idReservacion, a.idCliente, b.nombreCliente, a.estado from Reservacion a , Cliente b where a.idCliente = b.idCliente";
                sentencia = " select * From CompPago ";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "Comprobantes");

                return dsDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
                conexion.Dispose();
            }
        }


        public DataSet BuscarId(ComprobantePago com)
        {
            try
            {
                sentencia = "";
                sentencia = "select * from CompPago WHERE idEmp =" + com.IdCPago.ToString();
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);//para traer los datos
                adaptador.Fill(dsDatos, "Empleado"); // para llenar los datos
                conexion.Dispose();
                return dsDatos;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }

        }
        //public int generarId() 
        //{
        //    int idGenerado;
        //    sentencia = "select max (idReservacion) from Reservaccion";
        //    conexion.Open();
        //    comando = new SqlCommand(sentencia, conexion);
        //    comando.CommandType = CommandType.Text;
        //    idGenerado =(Int32)comando.ExecuteScalar();
        //    return idGenerado + 1;
        //}


        public void Eliminar(ComprobantePago com)

        {

            try
            {
                sentencia = "";
                sentencia = "delete FROM CompPago WHERE idEmp =" + com.IdCPago.ToString();
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Dispose();
            }

            catch (Exception ex)
            {
                throw ex;
            }


            finally
            {
                conexion.Close();
            }

        }
    }
}

using com.app.comprobante.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace proysustidataaccesss
{
    public class ActaComproDo
    {

        #region Declaración de variables
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlCommand comando;
        DataSet dsDatos = new DataSet();
        string sentencia;
        #endregion


        public ActaComproDo()
        {
            conexion = new SqlConnection(" Data Source=localhost;Initial Catalog=dbEncargos;Integrated Security=True");
            // conexion = new SqlConnection("Data Source=localhost;Initial Catalog=dbEncargos;Integrated Security=True");
        }

        public void Insertar(ActaCompro act)
        {
            try
            {
                sentencia = "";
                sentencia = " insert into ActaDeCompromiso values ('" + act.NumAC + "','" + act.RDNum + "',TRY_CONVERT(DATE,'20/09/2020',103),'";
                sentencia = sentencia + act.TipoGasto + "'," +  act.Monto.ToString() + ",'" + act.Motivo + "'," + act.NumDias.ToString()+ ", TRY_CONVERT(DATE,'20/09/2020',103),TRY_CONVERT(DATE,'20/11/2020',103),TRY_CONVERT(DATE,'20/09/2020',103)," + act.idPersonal.ToString() + ")";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                Console.WriteLine("Exito en la Operacion");
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

        public void Actualizar(ActaCompro act)
        {
            try
            {
                //sentencia = "Update Menu Set concepto ='" + act.Concepto + "','" + act.Tipo + "','" + act.SubTipo + "','" + act.Fecha + "'," + act.Monto + ",'" + act.Mes + "' Where nombreMenu =' " + NombreMenu + "'";
                sentencia = "";
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

        public void Eliminar(ActaCompro act)
        {
            try
            {
                sentencia = " Delete from ActaDeCompromiso Where idactimiento = " + act.IdActaCompromiso.ToString();
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

        public DataSet BuscarTodo()
        {
            try
            {
                sentencia = "Select * from ActaDeCompromiso";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "ActaDeCompromisos");
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

        public DataSet BuscarId(ActaCompro act)
        {
            try
            {
                sentencia = "Select * from ActaDeCompromiso Where idMenu =" + act.IdActaCompromiso.ToString().Trim();
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "MENU");
                conexion.Dispose();
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
    }
}

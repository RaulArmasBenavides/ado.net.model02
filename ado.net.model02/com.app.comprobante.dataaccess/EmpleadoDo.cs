using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using com.app.comprobante.entity;

namespace proysustidataaccesss
{
    public class EmpleadoDo
    {
        #region Declaración de variables 
        SqlConnection conexion;
        SqlDataAdapter adaptador; //Obj que permite realizar el puente hacia la bdd
        SqlCommand comando;//parametriza todo el query, o store procedures
        DataSet dsDatos = new DataSet();// dataset sin tipo sirve para colocar todos los registros que traiga de la bdd q consulte
        string sentencia = string.Empty;
        #endregion



        public EmpleadoDo () 
        {
            conexion = new SqlConnection("Data Source=localhost;Initial Catalog=dbEncargos;Integrated Security=True");
        }

        public void Insertar(Empleado emp) 
       
        {
            try
            {
                sentencia = "";
                sentencia = "insert into Personal values ('" + emp.ApePat + "','" + emp.ApeMat + "','" + emp.Nombre1 + "','" + emp.Nombre2 + "','";
                sentencia = sentencia + emp.Nombre3 + "','" + emp.Domicilio + "','" + emp.Telf1+ "','"+emp.Telf2  + "','" + emp.Telf3 + "','" + emp.CtaAbono + "','"+ emp.Correo + "', CAST('0x1234FFCD5' AS varBinary(MAX)))";
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

        public void Actualizar(int id) 
        {

            try
            {
                sentencia = "";  
                //sentencia = "update Empleado set nombreEmp ='" + nombreEmp + "', generoEmp = '" + generoEmp + "', cargoEmp ='" + cargoEmp + "',fechaNacEmp ='" + fechaNacEmp + "' WHERE idEmp =" + idEmp;
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

        public void Eliminar( int id) 
        
        {

            try
            {
                sentencia = "";
                sentencia = "delete FROM Personal WHERE idEmp =" + id.ToString();
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

        public DataSet buscarTodo()
        {
            try
            {
                sentencia = " select * from Personal";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "Personal");
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

        public DataSet BuscarId(int id)
        {
            try
            {
                sentencia = "select * from Personal WHERE IdPersonal =" + id.ToString();
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);//para traer los datos
                adaptador.Fill(dsDatos, "Empleado"); // para llenar los datos
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

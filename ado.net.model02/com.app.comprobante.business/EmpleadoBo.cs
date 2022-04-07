using System;
using System.Data;
using com.app.comprobante.entity;
using proysustidataaccesss;

namespace proysustibusiness
{
    public class EmpleadoBo
    {
        EmpleadoDo empleado = new EmpleadoDo();

        //public void insertar(string nombre, string genero, string cargo, DateTime fechaNac)
        public void insertar(Empleado emp)
        {
            try
            {
                empleado.Insertar(emp);

            }
            catch (Exception ex)
            {

                throw ex; 
            }
                      
        }

        public void actualizar(int id)
        {

            empleado.Actualizar(id);
        }

        public void eliminar(int id)
        {
            //empleado.IdEmp = id;
            empleado.Eliminar(id);
        }

        public DataSet buscarTodo()
        {
            return empleado.buscarTodo();
        }

        public DataSet buscarId(int id)
        {
            //empleado.IdEmp = id;
            return empleado.BuscarId(id);
        }

    }
}

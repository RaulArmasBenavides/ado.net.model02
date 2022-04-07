using com.app.comprobante.entity;
using proysustidataaccesss;
using System;
using System.Data;

namespace proysustibusiness
{
    public class CompPagoBo
    {
        #region Declaracion de variables 
        ComprobantePago com = null;
        CompPagoDo _doComprobante = null;
        #endregion

        public CompPagoBo ()
        {

        }

        public void Insertar(string concepto, string tipo, string subtipo, string fecha, decimal monto, string mes)
        {

            //mov = new Movimiento();
            _doComprobante = new CompPagoDo();
            try
            {
                //mov.Concepto = concepto.Trim();
                //mov.Descripcion = descripcion.Trim();
                //mov.Fecha = fecha.Trim();
                //mov.Monto = monto;
                //mov.Tipo = tipo.Trim();
                //mov.SubTipo = subtipo.Trim();
                //mov.Mes = mes.Trim();
                _doComprobante.Insertar(com);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(int id, string concepto, string tipo, string subtipo, string fecha, decimal monto, string mes)
        {

            //mov = new Movimiento();
            _doComprobante = new CompPagoDo();
            try
            {
                //menu.IdMenu = id;
                //menu.NombreMenu = nombre;
                //menu.DescripcionMenu = descripcion;
                //menu.PrecioMenu = precio;
                //menu.DisponibilidadMenu = disponibilidad;
                //menu.Actualizar();
                //mov.Concepto = concepto.Trim();
                //mov.Descripcion = descripcion.Trim();
                //mov.Fecha = fecha.Trim();
                //mov.Monto = monto;
                //mov.Tipo = tipo.Trim();
                //mov.SubTipo = subtipo.Trim();
                //mov.Mes = mes.Trim();
                _doComprobante.Actualizar(com);

            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public void Eliminar(ComprobantePago com)
        {
            try
            {
                //mov = new Movimiento();
                _doComprobante.Eliminar(com);

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public DataSet BuscarTodo()
        {
            _doComprobante = new CompPagoDo();
            try
            {
                return _doComprobante.BuscarTodo();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public DataSet BuscarId(int id)
        {
            try
            {
               //mov = new Movimiento();
               //_doMovimiento = new MovimientoDo();
               //mov.idMovimiento = id;
                return _doComprobante.BuscarId(com);
            }
            catch (Exception ex)
            {
                throw ex;
            }
      
        }

   




    }
}

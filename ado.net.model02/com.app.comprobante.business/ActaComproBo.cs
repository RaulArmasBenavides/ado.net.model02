using System;
using System.Data;
using com.app.comprobante.entity;
using proysustidataaccesss;

namespace proysustibusiness
{
    public class ActaComproBo
    {
        #region Declaración de variables 
        ActaComproDo acta = null;
        #endregion


        public void Insertar(ActaCompro comp)
        {
            try
            {
                acta =  new ActaComproDo();
                acta.Insertar(comp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet BuscarTodo()
        {
            acta = new ActaComproDo();
            return acta.BuscarTodo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class NConstrucc
    {
        #region "Constructor
        public NConstrucc()
            :base()
        {

        }
        #endregion

        #region"Propiedades"
        public int id_Nomenc { get; set; }
    public int id_NConstrucc { get; set; }
    public string NCNombre { get; set; }
    public bool Estado { get; set; }
    #endregion

    #region"Metodos"
    public void Seleccionar()
    {
        DataTable objDataTable = this.EjecutarConsulta("S");
        foreach (DataRow objDataRow in objDataTable.Rows)
        {
            this.id_Nomenc = (int)objDataRow["id_Nomenc"];
            this.id_NConstrucc = (int)objDataRow["id_NConstrucc"];
            this.NCNombre = (string)objDataRow["NCNombre"];
            this.Estado = (bool)objDataRow["Estado"];
        }
    }

    public DataTable MostrarTodos()
    {
        return this.EjecutarConsulta("T");
    }

    private DataTable EjecutarConsulta(string OpcionSeleccionar)
    {
        return new AccesoDatos.AccesoDatos().EjecutarProcedimientosConsultas("Usp_Cementerio_NConstrucc_Seleccionar", OpcionSeleccionar, this.id_Nomenc, this.id_NConstrucc);
    }

    public int InsertarActualizar()
    {
        return this.EjecutarInsertarActualizarEliminar("IU");//Insertar o actualizar.
    }

    public int Eliminar()
    {
        return this.EjecutarInsertarActualizarEliminar("D");
    }

    private int EjecutarInsertarActualizarEliminar(string OpcionMantenimiento)
    {
        return new AccesoDatos.AccesoDatos().EjecutarProcedimientoInsertarActualizarEliminar("Usp_Cementerio_NConstrucc_InsertarActualizarEliminar", OpcionMantenimiento, this.id_Nomenc, this.id_NConstrucc, this.NCNombre, this.Estado);

    }
    #endregion

    #region "Metodos Sobre Escritos"
    public override string ToString()//este método sirve para mostrar la descripción de una clase.
    {
        if (this.id_NConstrucc == 0) { return null; }//valida que el id sea diferente de cero
        if (this.NCNombre == null || this.NCNombre == "") { return null; }//valida que la descrip no sea vacío
        return string.Format("Id: {0} Nombre: {1}", this.id_NConstrucc, this.NCNombre);//returna un valor de tipo texto con el id y la descrip, esto sirve como descripcion d ela clase.
    }


    #endregion
}
}

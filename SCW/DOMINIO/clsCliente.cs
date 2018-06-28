using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCW.DOMINIO
{
    class clsCliente
    {
        #region atributos
        String atrNombre;
        String atrDireccionMac;
        bool atrEstado;
        #endregion
        #region Contructores

        #endregion
        #region metodos Accesores o get
        public String getAtrNombre()
        {
            return this.atrNombre;
        }
        public String getAtrDireccionMac()
        {
            return this.atrDireccionMac;
        }
        public bool getAtrEstado()
        {
            return this.atrEstado;
        }
        #endregion
        #region metodos Mutadores o set
        public void setAtrNombre(String parNombre)
        {
            this.atrNombre = parNombre;
        }
        public void setAtrDireccionMac(String parDireccionMac)
        {
            this.atrDireccionMac = parDireccionMac;
        }
        public void setAtrEstado(bool parEstado)
        {
            this.atrEstado = parEstado;
        }
        #endregion
    }
}

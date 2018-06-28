using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCW.PRESENTACION
{
    class clsControl
    {
        #region atributos
        String atrUrl = "http://192.168.0.1/login.html";
        #endregion
        #region Get
        public String getAtrUrl()
        {
            return this.atrUrl;
        }
        #endregion

    }
}

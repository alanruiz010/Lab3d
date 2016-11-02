using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.ADO
{
    public class Provincia
    {
        private int _idProvincia;
        private string _descripcion;

        public int IdProvincia
        {
            get { return _idProvincia; }
            set { _idProvincia = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Provincia(int id, string descripcion)
        {
            this._idProvincia = id;
            this._descripcion = descripcion;
        }
    }
}

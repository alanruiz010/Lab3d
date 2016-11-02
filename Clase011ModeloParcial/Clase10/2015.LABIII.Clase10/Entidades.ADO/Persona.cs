using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.ADO
{
    public class Persona
    {
        private int _dni;
        private string _apellido;
        private string _nombre;
        private string _sexo;
        private Provincia _provincia;

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public Provincia Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }

    }
}

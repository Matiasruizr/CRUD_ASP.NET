using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace PrimeraAplicacionWeb.Models
{
    public class Usuario
    {
        private string _id;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Usuario(string id, string nombre, string email)
        {
            _id = id;
            _nombre = nombre;
            _email = email;

        }

        public override string ToString()
        {
            //String builder
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Id: {0}, ", _id));
            sb.Append(string.Format("Nombre: {0}, ", _nombre));
            sb.Append(string.Format("Email: {0}, ", _email));

            return sb.ToString();
        }
    }
}